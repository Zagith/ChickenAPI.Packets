﻿using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("f_repos")]
    public class FReposPacket : IPacket
    {
        [PacketIndex(0)]
        public byte OldSlot { get; set; }

        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketIndex(2)]
        public byte NewSlot { get; set; }

        [PacketIndex(3)]
        public byte? Unknown { get; set; }
    }
}