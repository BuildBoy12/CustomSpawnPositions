// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace CustomSpawnPositions
{
    using System.IO;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using Exiled.Loader;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public sealed class Config : IConfig
    {
        private string filePath;

        /// <summary>
        /// Gets the role related configs.
        /// </summary>
        [YamlIgnore]
        public PointConfig PointConfig { get; private set; }

        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets or sets the name of the file to write to.
        /// </summary>
        public string FileName { get; set; } = "global.yml";

        /// <summary>
        /// Reloads the config file using the contents of <see cref="PointConfig"/>.
        /// </summary>
        public void Reload()
        {
            File.WriteAllText(filePath, Loader.Serializer.Serialize(PointConfig));
            PointConfig = Loader.Deserializer.Deserialize<PointConfig>(File.ReadAllText(filePath));
        }

        /// <summary>
        /// Loads the item configs.
        /// </summary>
        public void LoadPoints()
        {
            string folderPath = Path.Combine(Paths.Configs, "SpawnPositions");
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            filePath = Path.Combine(folderPath, FileName);
            if (!File.Exists(filePath))
            {
                PointConfig = new PointConfig();
                File.WriteAllText(filePath, Loader.Serializer.Serialize(PointConfig));
                return;
            }

            PointConfig = Loader.Deserializer.Deserialize<PointConfig>(File.ReadAllText(filePath));
            File.WriteAllText(filePath, Loader.Serializer.Serialize(PointConfig));
        }
    }
}