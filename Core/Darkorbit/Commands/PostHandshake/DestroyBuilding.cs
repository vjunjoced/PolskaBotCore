﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtil.IO;

namespace PolskaBot.Core.Darkorbit.Commands.PostHandshake
{
    class DestroyBuilding : Command
    {
        public const ushort ID = 23972;

        public int BuildingID { get; private set; }
        public short AssetType { get; private set; }

        public DestroyBuilding(EndianBinaryReader reader)
        {
            BuildingID = reader.ReadInt32();
            BuildingID = (int)((uint)BuildingID >> 15 | (uint)BuildingID << 17);
            reader.ReadInt16(); //entering class_455
            AssetType = reader.ReadInt16();
            reader.ReadInt16();
        }
    }
}
