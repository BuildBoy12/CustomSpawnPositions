// -----------------------------------------------------------------------
// <copyright file="CustomSpawnPositions.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Commands
{
    using System;
    using System.Text;
    using CommandSystem;
    using CustomSpawnPositions.Commands.Create;
    using NorthwoodLib.Pools;

    /// <inheritdoc />
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class ParentCmd : ParentCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentCmd"/> class.
        /// </summary>
        public ParentCmd() => LoadGeneratedCommands();

        /// <inheritdoc />
        public override string Command { get; } = "customspawnpositions";

        /// <inheritdoc />
        public override string[] Aliases { get; } = { "csp" };

        /// <inheritdoc />
        public override string Description { get; } = "The parent command to interact with custom spawn positions";

        /// <inheritdoc />
        public sealed override void LoadGeneratedCommands()
        {
            // RegisterCommand(new CreateItem());
            RegisterCommand(new CreatePlayer());
            RegisterCommand(new List());
        }

        /// <inheritdoc />
        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            StringBuilder stringBuilder = StringBuilderPool.Shared.Rent();
            stringBuilder.AppendLine("Please enter a valid subcommand! Available:");
            foreach (ICommand command in AllCommands)
            {
                stringBuilder.AppendLine(command.Aliases != null && command.Aliases.Length > 0
                    ? $"{command.Command} | Aliases: {string.Join(", ", command.Aliases)}"
                    : command.Command);
            }

            response = StringBuilderPool.Shared.ToStringReturn(stringBuilder).TrimEnd();
            return false;
        }
    }
}