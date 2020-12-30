using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace MCTurtleRemoteController.PC
{
    public class World
    {
        private WebSocketServer ws;
        private List<Turtle> turtles;

        /// <summary>
        /// Creates a new World object.
        /// </summary>
        /// <param name="replaceWorld">Wether to update the world instance in the static variable from <c>TurtleBehavior</c>.</param>
        public World(bool replaceWorld = true)
        {
            turtles = new List<Turtle>();

            if(replaceWorld)
                TurtleBehavior.currentWorld = this;
        }

        public void startWS()
        {
            //Connection URL:  ws://25.98.54.107/turtle
            //ws = new WebSocketServer("ws://25.98.54.107");

            //In Singleplayer, requires allowing "$private" IPs to be "allowed"
            //Connection URL:  ws://127.0.0.1/turtle
            ws = new WebSocketServer("ws://127.0.0.1");
            ws.AddWebSocketService<TurtleBehavior>("/turtle");
            ws.Start();
            Console.WriteLine("Started listening on {0}:{1}...\nWaiting for connection...", ws.Address.ToString(), ws.Port);
        }

        public void stopWS()
        {
            ws.Stop();
        }

        public void broadcastMovement(Movement movement)
        {
            string code = "turtle.";

            switch (movement)
            {
                case Movement.Forward:
                    code += "forward()";
                    break;
                case Movement.Backward:
                    code += "back()";
                    break;
                case Movement.Up:
                    code += "up()";
                    break;
                case Movement.Down:
                    code += "down()";
                    break;
                case Movement.TurnLeft:
                    code += "turnLeft()";
                    break;
                case Movement.TurnRight:
                    code += "turnRight()";
                    break;
            }

            PCCommand cmd = new PCCommand("eval", code, "broadcast");
            string evalCmd = JsonConvert.SerializeObject(cmd, Formatting.None);
            ws.WebSocketServices.Broadcast(evalCmd);
        }

        public void broadcastEval(string code)
        {
            PCCommand cmd = new PCCommand("eval", code, "broadcast");
            string evalCmd = JsonConvert.SerializeObject(cmd, Formatting.None);
            ws.WebSocketServices.Broadcast(evalCmd);
        }
    }
}
