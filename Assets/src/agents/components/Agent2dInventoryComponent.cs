﻿using Entitas;
using Entitas.CodeGeneration.Attributes;
using System.Collections;

namespace Components
{
    sealed public class Agent2dInventoryComponent : IComponent
    {
        [PrimaryEntityIndexAttribute]
        public int  InventoryID;
        public int  Width;
        public int  Height;
        public int  SelectedSlot;
        // Used to fast searching fist empty slot. Should has the size of width * Heigh.
        public BitArray Slots; // Todo: Implement faster bitfield implementation.
    }
}