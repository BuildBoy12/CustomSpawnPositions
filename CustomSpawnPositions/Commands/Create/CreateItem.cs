// -----------------------------------------------------------------------
// <copyright file="CreateItem.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

/*using CustomSpawnPositions.Points;

namespace CustomSpawnPositions.Commands.Create
{
    using System;
    using CommandSystem;
    using Exiled.API.Features;
    using Exiled.API.Features.Items;
    using Exiled.Permissions.Extensions;
    using UnityEngine;

    /// <inheritdoc />
    public class CreateItem : ICommand
    {
        /// <inheritdoc />
        public string Command { get; } = "createitem";

        /// <inheritdoc />
        public string[] Aliases { get; } = { "ci" };

        /// <inheritdoc />
        public string Description { get; } = "Creates a new item spawnpoint";

        /// <inheritdoc />
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("csp.create"))
            {
                response = "Insufficient permission.";
                return false;
            }

            Player player = Player.Get(sender);
            if (player == null)
            {
                response = "This command must be executed from the game level.";
                return false;
            }

            if (arguments.Count == 0)
            {
                response = "Please specify the type of item to spawn.";
                return false;
            }

            if (!Enum.TryParse(arguments.At(0), true, out ItemType itemType))
            {
                response = $"Could not parse \"{arguments.At(0)}\" into an ItemType.";
                return false;
            }

            int chance = 100;
            if (arguments.Count > 1)
                int.TryParse(arguments.At(1), out chance);

            Room room = player.CurrentRoom;
            Vector3 position = room.Transform.InverseTransformDirection(player.Position);
            ItemSpawnPoint itemSpawnPoint = new ItemSpawnPoint
            {
                Chance = chance,
                IsRelative = true,
                Item = itemType,
                Position = position,
                RoomType = room.Type,
            };

            Config spawnPositions = Plugin.Instance.Config;
            spawnPositions.PointConfig.ItemSpawns.Add(itemSpawnPoint);
            spawnPositions.Reload();
            new Item(ItemType.Coin).Spawn(position);
            response = "Spawnpoint created.";
            return true;
        }
    }
}*/