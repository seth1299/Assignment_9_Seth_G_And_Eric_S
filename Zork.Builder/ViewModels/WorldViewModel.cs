using System;
using System.ComponentModel;
namespace Zork.Builder.ViewModels
{
    internal class WorldViewModel
    {
        public BindingList<Player> Players { get; set; }

        private World _world;

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
    }
}
