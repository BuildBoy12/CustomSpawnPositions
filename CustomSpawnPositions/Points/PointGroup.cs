// -----------------------------------------------------------------------
// <copyright file="PointGroup.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions.Points
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a group of points.
    /// </summary>
    public class PointGroup
    {
        private readonly List<Point> points = new List<Point>();

        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the amount of points to spawn.
        /// </summary>
        public int SpawnAmount { get; set; }

        /// <summary>
        /// Adds a point to the group.
        /// </summary>
        /// <param name="point">The point to add.</param>
        public void Add(Point point) => points.Add(point);

        /// <summary>
        /// Adds a collection of points to the group.
        /// </summary>
        /// <param name="pointCollection">The collection to add.</param>
        public void AddRange(IEnumerable<Point> pointCollection) => points.AddRange(pointCollection);

        /// <summary>
        /// Spawns in all of the points.
        /// </summary>
        public void Spawn()
        {
            points.ShuffleList();
            for (int i = 0; i < SpawnAmount; i++)
                points[i].Spawn();
        }
    }
}