﻿using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("pidx_sub_packet")]
    public class PidxSubPacket : IPacket
    {
        [PacketIndex(0)]
        public bool IsGrouped { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }
    }
}