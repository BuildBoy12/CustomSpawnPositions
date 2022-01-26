// -----------------------------------------------------------------------
// <copyright file="ItemSpawnPoint.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Points
{
    using System.Text;
    using Exiled.API.Features;
    using Exiled.API.Features.Items;
    using NorthwoodLib.Pools;
    using UnityEngine;

    /// <summary>
    /// Represents a point on the map where an item can spawn.
    /// </summary>
    public class ItemSpawnPoint : Point
    {
        private float chance;

        /// <summary>
        /// Gets or sets the item to spawn at the <see cref="Point"/>.
        /// </summary>
        public ItemType Item { get; set; }

        /// <summary>
        /// Gets or sets the chance that the item should spawn at the <see cref="Point"/>. Clamped between 0-100.
        /// </summary>
        public float Chance
        {
            get => chance;
            set => chance = Mathf.Clamp(value, 0, 100);
        }

        /// <inheritdoc />
        public override void Spawn()
        {
            if (Chance <= Exiled.Loader.Loader.Random.Next(100))
                return;

            if (!IsRelative)
            {
                new Item(Item).Spawn(Position);
                return;
            }

            foreach (Room room in Map.Rooms)
            {
                if (room.Type == RoomType)
                {
                    Vector3 position = room.Transform.TransformPoint(Position) + Vector3.up;
                    new Item(Item).Spawn(position);
                    Log.Debug($"Spawned a {Item} at a custom spawnpoint at {position} which is inside a {RoomType}.", Plugin.Instance.Config.Debug);
                }
            }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            StringBuilder stringBuilder = StringBuilderPool.Shared.Rent();
            stringBuilder.Append("Item: ").AppendLine(Item.ToString());
            stringBuilder.Append("Chance: ").Append(Chance).Append('/').AppendLine("100");
            stringBuilder.Append("Is Relative:").AppendLine(IsRelative.ToString());
            if (IsRelative)
                stringBuilder.Append("Room: ").AppendLine(RoomType.ToString());

            stringBuilder.AppendLine(Position.ToString());
            return StringBuilderPool.Shared.ToStringReturn(stringBuilder).TrimEnd();
        }
    }
}