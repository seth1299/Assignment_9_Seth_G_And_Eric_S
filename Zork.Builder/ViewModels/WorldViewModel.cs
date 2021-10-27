using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;

namespace Zork.Builder.ViewModels
{
    internal class WorldViewModel
    {
        public BindingList<Player> Players { get; set; }

        private World _world;

        private bool IsWorldLoaded;

        public World World
        {
            set
            {
                if (_world != value)
                {
                    _world = value;
                    if (_world != null)
                    {
                        Players = new BindingList<Player>(_world.Players);
                    }
                    else
                    {
                        Players = new BindingList<Player>(Array.Empty<Player>());
                    }
                }
            }
        }

        public WorldViewModel(World world = null)
        {
            World = world;
        }

        public void SaveWorld(string filename)
        {
            if (!IsWorldLoaded)
            {
                throw new InvalidOperationException("No world loaded.");
            }
            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidProgramException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            
            using (StreamWriter streamWriter = new StreamWriter(filename))       
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _world);
            }
        }
    }
}
