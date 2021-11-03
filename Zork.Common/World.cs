﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork

{
    public class World
    {
        public List<Room> Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room); //unhandled

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }


        }
        [JsonProperty]
        private string StartingLocation { get; set; }
        public IList<Player> Players { get; set; }

        private Dictionary<string, Room> mRoomsByName;


    }
}
