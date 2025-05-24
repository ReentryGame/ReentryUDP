import time, socket, json
from ReentryUDP.DomainModels import *
from dataclasses import asdict

key_dict = {
    (Craft.CommandModule, 'V'): CommandModuleButtonID.AGCVerb,
    (Craft.CommandModule, 'N'): CommandModuleButtonID.AGCNoun,
    (Craft.CommandModule, 'C'): CommandModuleButtonID.AGCClear,
    (Craft.CommandModule, 'P'): CommandModuleButtonID.AGCPro,
    (Craft.CommandModule, 'K'): CommandModuleButtonID.AGCKeyRel,
    (Craft.CommandModule, 'E'): CommandModuleButtonID.AGCEntr,
    (Craft.CommandModule, 'R'): CommandModuleButtonID.AGCRset,
    (Craft.CommandModule, '0'): CommandModuleButtonID.AGC0,
    (Craft.CommandModule, '1'): CommandModuleButtonID.AGC1,
    (Craft.CommandModule, '2'): CommandModuleButtonID.AGC2,
    (Craft.CommandModule, '3'): CommandModuleButtonID.AGC3,
    (Craft.CommandModule, '4'): CommandModuleButtonID.AGC4,
    (Craft.CommandModule, '5'): CommandModuleButtonID.AGC5,
    (Craft.CommandModule, '6'): CommandModuleButtonID.AGC6,
    (Craft.CommandModule, '7'): CommandModuleButtonID.AGC7,
    (Craft.CommandModule, '8'): CommandModuleButtonID.AGC8,
    (Craft.CommandModule, '9'): CommandModuleButtonID.AGC9,
    (Craft.CommandModule, '+'): CommandModuleButtonID.AGCPluss,
    (Craft.CommandModule, '-'): CommandModuleButtonID.AGCMinus,
    (Craft.LunarModule, 'V'): LunarModuleButtonID.LGCVerb,
    (Craft.LunarModule, 'N'): LunarModuleButtonID.LGCNoun,
    (Craft.LunarModule, 'C'): LunarModuleButtonID.LGCClr,
    (Craft.LunarModule, 'P'): LunarModuleButtonID.LGCPro,
    (Craft.LunarModule, 'K'): LunarModuleButtonID.LGCKeyRel,
    (Craft.LunarModule, 'E'): LunarModuleButtonID.LGCEntr,
    (Craft.LunarModule, 'R'): LunarModuleButtonID.LGCRset,
    (Craft.LunarModule, '0'): LunarModuleButtonID.LGC0,
    (Craft.LunarModule, '1'): LunarModuleButtonID.LGC1,
    (Craft.LunarModule, '2'): LunarModuleButtonID.LGC2,
    (Craft.LunarModule, '3'): LunarModuleButtonID.LGC3,
    (Craft.LunarModule, '4'): LunarModuleButtonID.LGC4,
    (Craft.LunarModule, '5'): LunarModuleButtonID.LGC5,
    (Craft.LunarModule, '6'): LunarModuleButtonID.LGC6,
    (Craft.LunarModule, '7'): LunarModuleButtonID.LGC7,
    (Craft.LunarModule, '8'): LunarModuleButtonID.LGC8,
    (Craft.LunarModule, '9'): LunarModuleButtonID.LGC9,
    (Craft.LunarModule, '+'): LunarModuleButtonID.LGCPlus,
    (Craft.LunarModule, '-'): LunarModuleButtonID.LGCNeg,
}

def main():
    sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    selected_agc = Craft.CommandModule

    while True:
        print(f'{"CMC>" if selected_agc == Craft.CommandModule else "LGC>"}', end=' ')
        command = input().strip()
        if command == 'exit':
            break
        elif command == 'CMC':
            selected_agc = Craft.CommandModule
        elif command == 'LGC':
            selected_agc = Craft.LunarModule
        # V for Verb
        # N for Noun
        # C for Clear
        # P for Proceed
        # K for KeyRelease
        # E for Enter
        # R for Reset
        # + for Plus
        # - for Minus
        
        else:
            while len(command) > 0:
                cmd = command[0]
                command = command[1:]
                packet = DataPacket(selected_agc, MessageType.PushButton, key_dict[(selected_agc, cmd)], 0)
                print(f'Sending {packet}')
                sock.sendto(json.dumps(asdict(packet)).encode(), ('localhost', 8051))
                time.sleep(1)


if __name__ == '__main__':
    main()