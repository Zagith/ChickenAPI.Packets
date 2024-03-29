﻿using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("NsTeST")]
    public class NsTeStSubPacket : IPacket
    {
        [PacketIndex(0)]
        public string Host { get; set; }

        [PacketIndex(1, SpecialSeparator = ":")]
        public int? Port { get; set; }

        [PacketIndex(2, SpecialSeparator = ":")]
        public int? Color { get; set; }

        [PacketIndex(3, SpecialSeparator = ":")]
        public int WorldCount { get; set; }

        [PacketIndex(4)]
        public int WorldId { get; set; }

        [PacketIndex(5)]
        public string Name { get; set; }
    }
}