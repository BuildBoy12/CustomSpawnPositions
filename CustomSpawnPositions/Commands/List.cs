// -----------------------------------------------------------------------
// <copyright file="List.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommandSystem;
    using CustomSpawnPositions.Points;
    using Exiled.Permissions.Extensions;
    using NorthwoodLib.Pools;

    /// <inheritdoc />
    public class List : ICommand
    {
        /// <inheritdoc />
        public string Command { get; } = "list";

        /// <inheritdoc />
        public string[] Aliases { get; } = { "l" };

        /// <inheritdoc />
        public string Description { get; } = "Lists all configured spawn points.";

        /// <inheritdoc />
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("csp.list"))
            {
                response = "Insufficient permission.";
                return false;
            }

            StringBuilder stringBuilder = StringBuilderPool.Shared.Rent();
            PointConfig pointConfig = Plugin.Instance.Config.PointConfig;

            stringBuilder.AppendLine("Item Spawnpoints:");
            foreach (List<ItemSpawnPoint> itemSpawnPoints in pointConfig.ItemSpawns.Values)
            {
                foreach (ItemSpawnPoint itemSpawnPoint in itemSpawnPoints)
                    stringBuilder.AppendLine(itemSpawnPoint.ToString());
            }

            stringBuilder.AppendLine().AppendLine("Player Spawnpoints:");
            foreach (List<PlayerSpawnPoint> playerSpawnPoints in pointConfig.PlayerSpawns.Values)
            {
                foreach (PlayerSpawnPoint playerSpawnPoint in playerSpawnPoints)
                    stringBuilder.AppendLine(playerSpawnPoint.ToString());
            }

            response = StringBuilderPool.Shared.ToStringReturn(stringBuilder).TrimEnd();
            return true;
        }
    }
}