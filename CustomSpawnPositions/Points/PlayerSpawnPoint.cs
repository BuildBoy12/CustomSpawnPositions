// -----------------------------------------------------------------------
// <copyright file="PlayerSpawnPoint.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Points
{
    using System.Collections.Generic;
    using System.Text;
    using Exiled.API.Features;
    using NorthwoodLib.Pools;
    using UnityEngine;

    /// <summary>
    /// Represents a point on the map where a player can spawn.
    /// </summary>
    public class PlayerSpawnPoint : Point
    {
        private static readonly IReadOnlyDictionary<RoleType, string> RoleTags = new Dictionary<RoleType, string>
        {
            [RoleType.Scp173] = "SP_173",
            [RoleType.ClassD] = "SP_CDP",
            [RoleType.Scp106] = "SP_106",
            [RoleType.Scp049] = "SP_049",
            [RoleType.Scientist] = "SP_RSC",
            [RoleType.ChaosConscript] = "SP_CI",
            [RoleType.Scp096] = "SP_096",
            [RoleType.NtfSergeant] = "SP_MTF",
            [RoleType.NtfCaptain] = "SP_MTF",
            [RoleType.NtfPrivate] = "SP_MTF",
            [RoleType.FacilityGuard] = "SP_GUARD",
            [RoleType.Scp93953] = "SP_939",
            [RoleType.Scp93989] = "SP_939",
            [RoleType.ChaosRifleman] = "SP_CI",
            [RoleType.ChaosRepressor] = "SP_CI",
            [RoleType.ChaosMarauder] = "SP_CI",
        };

        /// <summary>
        /// Gets or sets the role to spawn at the <see cref="Point"/>.
        /// </summary>
        public RoleType Role { get; set; }

        /// <inheritdoc />
        public override void Spawn()
        {
            if (!RoleTags.TryGetValue(Role, out string roleTag))
                return;

            if (!IsRelative)
            {
                GameObject spawnpoint = new GameObject();
                spawnpoint.transform.position = Position;
                spawnpoint.tag = roleTag;
                return;
            }

            foreach (Room room in Map.Rooms)
            {
                if (room.Type == RoomType)
                {
                    GameObject spawnpoint = new GameObject();
                    spawnpoint.transform.position = room.Transform.TransformPoint(Position);
                    spawnpoint.tag = roleTag;
                    Log.Debug($"Created a custom role spawnpoint at {spawnpoint.transform.position}", Plugin.Instance.Config.Debug);
                }
            }
        }

        /// <inheritdoc />
        public override string ToString()
        {
            StringBuilder stringBuilder = StringBuilderPool.Shared.Rent();
            stringBuilder.Append("Role: ").AppendLine(Role.ToString());
            stringBuilder.Append("Is Relative:").AppendLine(IsRelative.ToString());
            if (IsRelative)
                stringBuilder.Append("Room: ").AppendLine(RoomType.ToString());

            stringBuilder.AppendLine(Position.ToString());
            return StringBuilderPool.Shared.ToStringReturn(stringBuilder).TrimEnd();
        }
    }
}