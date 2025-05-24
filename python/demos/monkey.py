import time, socket, json, random
from ReentryUDP.DomainModels import *
from dataclasses import asdict

print('Monkey is alive!')
# Inspired by https://folklore.org/Monkey_Lives.html?sort=date

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
positions = [_ for _ in list(Position.__dict__.values()) if type(_) is int]
switches = [_ for _ in list(GeminiSwitchID.__dict__.values()) if type(_) is int]
buttons = [_ for _ in list(GeminiButtonID.__dict__.values()) if type(_) is int]

while True:
    #time.sleep(random.randint(1, 30))
    time.sleep(.1)
    print('Ape nothing but a heartbreak')
    packet_type = random.choice([MessageType.SetSwitch, MessageType.PushButton])
    packet = None
    if packet_type == MessageType.SetSwitch:
        packet = json.dumps(asdict(DataPacket(Craft.Gemini, packet_type, random.choice(switches), random.choice(positions))))
    else:
        packet = json.dumps(asdict(DataPacket(Craft.Gemini, packet_type, random.choice(buttons), 0)))
    print(f'Sending: {packet}')
    sock.sendto(packet.encode(), ('localhost', 8051))
