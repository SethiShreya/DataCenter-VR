using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class ContentProvider : MonoBehaviour
{
    public TextMeshProUGUI headingText;
    public TextMeshProUGUI content;
    //public void ShowServerC()
    //{
    //    headingText.text = "Server";

    //    content.text = "A Data server is basically a computer without peripherals like monitors and keyboards\r\n\r\nServers are the engines of the data center. On servers, the processing and memory used to run applications may be physical, virtualized, distributed across containers, or distributed among remote nodes in an edge computing model.";
    //}
    //public void ShowNSC()
    //{
    //    headingText.text = "Network Switch";
    //    content.text = "Switch takes in packets being sent by devices that are connected to its physical ports and sends them out again, but only through the ports that lead to the devices, the packets are intended to reach. Switches can also operate at the network layer where routing occurs. When one device sends a data packet to another device, the packet enters the switch and the switch reads the header to determine what to do with it. The switch matches the destination address or addresses and sends the packet out through the appropriate ports that lead to the destination devices.";
    //}
    //public void ShowNasC()
    //{
    //    headingText.text = "Network Attached Storage\r\n";
    //    content.text = "The purpose of NAS is to enable users to collaborate and share data more effectively.\r\n\r\nNetwork-attached storage (NAS) is dedicated file storage that enables multiple users and heterogeneous client devices to retrieve data from centralized disk capacity. Users on a local area network (LAN) access the shared storage via a standard Ethernet connection.";
    //}
    //public void ShowUPSC()
    //{
    //    headingText.text = "Uninterruptable Power Supply";
    //    content.text = "A device that provides battery backup when the electrical power fails.\r\n\r\nAn uninterruptible power supply (UPS) is a device that allows a computer to keep running for at least a short time when incoming power is interrupted. As long as utility power is flowing, it also replenishes and maintains the energy storage.";
    //}
    //public void ShowFirewallC()
    //{
    //    headingText.text = "Firewall";
    //    content.text = "A firewall is a network security device that monitors incoming and outgoing network traffic and permits or blocks data packets based on a set of security rules. Its purpose is to establish a barrier between your internal network and incoming traffic from external sources (such as the internet) in order to block malicious traffic like viruses and hackers. Firewalls guard traffic at a computer's entry point called ports, which is where information is exchanged with external devices.";
    //}

    public void TakeHeading(string heading)
    {
        headingText.text = heading;
    }

    public void TakeContext(string text)
    { 
        content.text = text;
    }
}
