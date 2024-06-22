using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

namespace ReentryUDP
{
    public class UDPSend : MonoBehaviour
    {
        public string IP; // public for debugging only
        public int port; // public for debugging only

        public UnityEngine.UI.Text statusText;

        IPEndPoint remoteEndPoint;
        UdpClient client;

        public void Start()
        {
            InitializeRemote();
        }

        void Update()
        {
            string setText = string.Format("# Reentry Remote #\n# 127.0.0.1 {0} #\n", port);
            if(statusText.text != setText)
                statusText.text = setText;
        }

        public void SendPackage()
        {
            var package = new DomainModels.DataPacket()
            {
                TargetCraft = DomainModels.DataPacket.Craft.CommandModule,
                ID = (int)DomainModels.CommandModuleSwitchID.CMCMode,
                ToPos = (int)DomainModels.PinPosition.Up,
                MessageType = DomainModels.DataPacket.MessageTypes.SetSwitch
            };
            var packageJson = JsonUtility.ToJson(package, true);
            sendJson(packageJson + "\n");
        }

        public void InitializeRemote()
        {
            IP = "127.0.0.1";
            port = 8051;

            remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
            client = new UdpClient();
        }

        private void sendJson(string json)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(json);
                client.Send(data, data.Length, remoteEndPoint);
            }
            catch (Exception err)
            {
                Debug.LogError(err.ToString());
            }
        }
    }
}