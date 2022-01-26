// -----------------------------------------------------------------------
// <copyright file="Point.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Points
{
    using CustomSpawnPositions.Models;
    using Exiled.API.Enums;

    /// <summary>
    /// Represents a location on the generated map.
    /// </summary>
    public abstract class Point
    {
        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="Position"/> is relative to the <see cref="RoomType"/>.
        /// </summary>
        public bool IsRelative { get; set; }

        /// <summary>
        /// Gets or sets the type of room the <see cref="Position"/> is relative to.
        /// </summary>
        public RoomType RoomType { get; set; }

        /// <summary>
        /// Gets or sets the location of the point.
        /// </summary>
        public SerializableVector3 Position { get; set; }

        /// <summary>
        /// Spawns in the object associated to the point.
        /// </summary>
        public abstract void Spawn();
    }
}