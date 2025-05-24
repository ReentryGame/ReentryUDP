/*
 
    -----------------------
    UDP-Receive (send to)
    -----------------------
    // https://forum.unity.com/threads/super-simple-udp-server-example.79256/
    // [url]http://msdn.microsoft.com/de-de/library/bb979228.aspx#ID0E3BAC[/url]
   
   
    // > receive
    // 127.0.0.1 : 8051
   
    // send
    // nc -u 127.0.0.1 8051
 
*/
using UnityEngine;
using System.Collections;

using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine.UI;

namespace ReentryUDP
{
    public class UDPReceive : MonoBehaviour
    {
        public Text monitor_Text;

        Thread receiveThread;
        UdpClient client;
        public int port;

        StringBuilder output = new StringBuilder();

        // start from unity3d
        public void Start()
        {
            init();
        }

        private void init()
        {
            port = 8052;

            receiveThread = new Thread(
                new ThreadStart(ReceiveData));
            receiveThread.IsBackground = true;
            receiveThread.Start();

        }

        private void ReceiveData()
        {
            client = new UdpClient(port);
            while (true)
            {
                try
                {
                    IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = client.Receive(ref anyIP);

                    string text = Encoding.UTF8.GetString(data);
                    Dictionary<string, float> packet = JsonConvert.DeserializeObject<Dictionary<string, float>>(text);

                    foreach (var e in packet)
                    {
                        Debug.Log(">> " + e.Key + ": " + e.Value);
                    }

                    output.Clear();
                    output.AppendLine(string.Format("DC Volts: {0} vdc.", packet["_gaugeDCVolts"].ToString("0.0")));


                }
                catch (Exception err)
                {
                    Debug.LogError(err.ToString());
                }
            }
        }

        private void Update()
        {
            monitor_Text.text = output.ToString();
        }

        void OnDisable()
        {
            if (receiveThread != null)
                receiveThread.Abort();

            if (client != null)
                client.Close();
        }
    }
}
