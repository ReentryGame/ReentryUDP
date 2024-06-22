use reentryudp::domain_models::*;
use strum::IntoEnumIterator;
use serde_json;

// Needed for UDP client
use std::net::UdpSocket;

fn main() {
    let socket = UdpSocket::bind("127.0.0.1:0").unwrap();

    // Forever
    loop {
        // for each of the three pin-positions in the enum except the first one
        for pin_position in PinPosition::iter().skip(1).take(3) {
            // Create a datapacket-struct with the pin-position
            let data_packet = DataPacket {
                TargetCraft: Craft::Mercury as u32,
                MessageType: MessageType::SetSwitch as u32,
                ID: MercurySwitchID::CabinLight as u32,
                ToPos: pin_position as u32,
            };

            // Convert to JSON
            let json = serde_json::to_string(&data_packet).unwrap();

            // print the JSON
            println!("{}", json);
            // Send the JSON to the server
            socket.send_to(json.as_bytes(), "127.0.0.1:8051").unwrap();

            // Wait for 10 second
            std::thread::sleep(std::time::Duration::from_secs(10));
        }
    }
}
