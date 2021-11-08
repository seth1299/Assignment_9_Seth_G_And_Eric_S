﻿using Newtonsoft.Json;
using System;
using System.IO;


namespace Zork
{

    public class Game
    {
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public IOutputService Output { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;
            while (IsRunning)
            {
                Output.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Output.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Output.Write("\n>");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        IsRunning = false;
                        break;

                    case Commands.LOOK:
                        Output.WriteLine(Player.Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if (Player.Move(direction) == false)
                        {
                            Output.WriteLine("The way is shut!");
                        }
                        break;

                    default:
                        Output.WriteLine("Unknown Command.");
                        break;
                
                }
            }
        }

        public static Game Load(string filename, IOutputService output)
        {

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
            game.Player = game.World.SpawnPlayer();
            game.Output = output;

            return game;
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

    }
}

