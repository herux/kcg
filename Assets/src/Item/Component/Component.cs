﻿using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Item
{
    public sealed class Component : IComponent // Basic Item Component.
    {
        public string           Label;
        public int              SpriteID;
        [EntityIndex]
        public Enums.ItemType   ItemType;

        // TODO: add model player will be holding when selecting this item.
        // TODO: ability to attach an event to item.
    }
}
