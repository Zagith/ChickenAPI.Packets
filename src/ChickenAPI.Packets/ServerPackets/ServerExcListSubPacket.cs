﻿using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    public class ServerExcListSubPacket : IPacket
    {
        [PacketIndex(0)]
        public short? ExchangeSlot { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public PocketType PocketType { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public short ItemVnum { get; set; }

        [PacketIndex(3, IsOptional = true)]
        [Range(-2, short.MaxValue)]
        public short AmountOrRare { get; set; }

        [PacketIndex(4, IsOptional = true)]
        [Range(0, byte.MaxValue)]
        public byte Upgrade { get; set; }
    }
}