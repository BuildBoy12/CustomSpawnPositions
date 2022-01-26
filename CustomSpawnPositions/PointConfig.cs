// -----------------------------------------------------------------------
// <copyright file="PointConfig.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions
{
    using System;
    using System.Collections.Generic;
    using CustomSpawnPositions.Models;
    using CustomSpawnPositions.Points;
    using Exiled.API.Enums;
    using YamlDotNet.Serialization;

    /// <summary>
    /// Handles spawnpoint related configs.
    /// </summary>
    [Serializable]
    public class PointConfig
    {
        /// <summary>
        /// Gets or sets a collection of all point groups.
        /// </summary>
        [YamlIgnore]
        public List<PointGroup> Groups { get; set; } = new List<PointGroup>();

        /// <summary>
        /// Gets or sets a collection of the points where items can spawn.
        /// </summary>
        public Dictionary<PointGroup, List<ItemSpawnPoint>> ItemSpawns { get; set; } =
            new Dictionary<PointGroup, List<ItemSpawnPoint>>
            {
                {
                    new PointGroup
                    {
                        Name = "LCZ_Guns",
                        SpawnAmount = 1,
                    },
                    new List<ItemSpawnPoint>
                    {
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczPlants,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(0f, 3.1f, 7.5f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczCafe,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(1.4f, 1.1f, -5.8f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczCafe,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(10.8f, 1.1f, 5.8f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczCafe,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-3.5f, 1.1f, 5.8f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczAirlock,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(2.056f, 0.1f, -7.169f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczAirlock,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(3.345f, 0.1f, -7.412f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.GunCOM15,
                            RoomType = RoomType.LczAirlock,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-3.5f, 0.1f, -7.438f),
                        },
                    }
                },
                {
                    new PointGroup
                    {
                        Name = "049Cards",
                        SpawnAmount = 1,
                    },
                    new List<ItemSpawnPoint>
                    {
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardContainmentEngineer,
                            RoomType = RoomType.Hcz049,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(6.2f, 265.24f, -9.3f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardContainmentEngineer,
                            RoomType = RoomType.Hcz049,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(2.6f, 265.24f, 2.3f),
                        },
                    }
                },
                {
                    new PointGroup
                    {
                        Name = "ClassDCards",
                        SpawnAmount = 5,
                    },
                    new List<ItemSpawnPoint>
                    {
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(6.1f, 2.1f, 7.25f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(0.86f, 1.9f, 7.38f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-4.39f, 1.9f, 7.36f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-9.623f, 2.06f, 7.4f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-14.9f, 1.9f, 7.37f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-20.08f, 2.3f, 7.38f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-24.83f, 1.9f, 7.38f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-23.149f, 2f, -7.4f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-17.9f, 2f, -7.4f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-12.659f, 2.05f, -7.4f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-7.435f, 1.938f, -7.3f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(-2.2f, 2.04f, -7.29f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(3.044f, 1.934f, -7.331f),
                        },
                        new ItemSpawnPoint
                        {
                            Item = ItemType.KeycardJanitor,
                            RoomType = RoomType.LczClassDSpawn,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(8.378f, 2.15f, -7.3f),
                        },
                    }
                },
                {
                    new PointGroup
                    {
                        Name = "372Radio",
                        SpawnAmount = 1,
                    },
                    new List<ItemSpawnPoint>
                    {
                        new ItemSpawnPoint
                        {
                            Item = ItemType.Radio,
                            RoomType = RoomType.LczGlassBox,
                            Chance = 100,
                            IsRelative = true,
                            Position = new SerializableVector3(12.18f, 0.4f, -8.189f),
                        },
                    }
                },
            };

        /// <summary>
        /// Gets or sets a collection of the points where players can spawn.
        /// </summary>
        public Dictionary<PointGroup, List<PlayerSpawnPoint>> PlayerSpawns { get; set; } =
            new Dictionary<PointGroup, List<PlayerSpawnPoint>>
            {
                {
                    new PointGroup
                    {
                        Name = "ScientistSpawns",
                        SpawnAmount = 2,
                    },
                    new List<PlayerSpawnPoint>
                    {
                        new PlayerSpawnPoint
                        {
                            Role = RoleType.Scientist,
                            RoomType = RoomType.Lcz173,
                            IsRelative = true,
                            Position = new SerializableVector3(9.5f, 17.01f, 16.842f),
                        },
                        new PlayerSpawnPoint
                        {
                            Role = RoleType.Scientist,
                            RoomType = RoomType.Lcz012,
                            IsRelative = true,
                            Position = new SerializableVector3(12.93f, 0.01f, 0.98f),
                        },
                    }
                },
            };
    }
}