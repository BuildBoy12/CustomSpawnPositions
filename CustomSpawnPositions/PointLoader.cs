// -----------------------------------------------------------------------
// <copyright file="PointLoader.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions
{
    using System.Collections.Generic;
    using CustomSpawnPositions.Points;

    /// <summary>
    /// Handles the generation of spawnpoints.
    /// </summary>
    public static class PointLoader
    {
        /// <summary>
        /// Loads all required items.
        /// </summary>
        public static void Reload()
        {
            PointConfig pointConfig = Plugin.Instance.Config.PointConfig;
            pointConfig.Groups.Clear();

            if (pointConfig.ItemSpawns != null)
            {
                foreach (KeyValuePair<PointGroup, List<ItemSpawnPoint>> kvp in pointConfig.ItemSpawns)
                {
                    kvp.Key.AddRange(kvp.Value);
                    pointConfig.Groups.Add(kvp.Key);
                }
            }

            if (pointConfig.PlayerSpawns != null)
            {
                foreach (KeyValuePair<PointGroup, List<PlayerSpawnPoint>> kvp in pointConfig.PlayerSpawns)
                {
                    kvp.Key.AddRange(kvp.Value);
                    pointConfig.Groups.Add(kvp.Key);
                }
            }

            foreach (PointGroup pointGroup in pointConfig.Groups)
                pointGroup.Spawn();
        }
    }
}