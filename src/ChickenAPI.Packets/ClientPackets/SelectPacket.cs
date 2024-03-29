﻿using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("select", AnonymousAccess = true)]
    public class SelectPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }
    }
}