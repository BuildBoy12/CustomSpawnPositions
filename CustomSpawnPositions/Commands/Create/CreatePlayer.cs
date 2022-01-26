// -----------------------------------------------------------------------
// <copyright file="CreatePlayer.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Commands.Create
{
    using System;
    using CommandSystem;
    using Exiled.Permissions.Extensions;

    /// <inheritdoc />
    public class CreatePlayer : ICommand
    {
        /// <inheritdoc />
        public string Command { get; } = "createplayer";

        /// <inheritdoc />
        public string[] Aliases { get; } = { "cp" };

        /// <inheritdoc />
        public string Description { get; } = "Creates a new player spawnpoint";

        /// <inheritdoc />
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("csp.create"))
            {
                response = "Insufficient permission.";
                return false;
            }

            response = "Not implemented.";
            return false;
        }
    }
}