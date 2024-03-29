﻿using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("c_mode")]
    public class CModePacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short Morph { get; set; }

        [PacketIndex(3)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(4)]
        public short MorphDesign { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public byte MorphBonus { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public byte? Size { get; set; }
    }
}