import time, socket, json
from ReentryUDP.DomainModels import *
from dataclasses import asdict

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
while True:
    for position in [Position.Left, Position.Middle, Position.Right]:
        packet = json.dumps(asdict(DataPacket(Craft.Mercury, MessageType.SetSwitch, MercurySwitchID.CabinLight, position)))
        print(packet)
        sock.sendto(packet.encode(), ('localhost', 8051))
        time.sleep(10)