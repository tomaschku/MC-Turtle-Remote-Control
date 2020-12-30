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
    public class TurtleBehavior : WebSocketBehavior
    {
        /// <summary>
        /// The World where new turtles should be added
        /// 
        /// TODO: Dependency Injection or similar is probably better
        /// </summary>
        public static World currentWorld;

        public TurtleBehavior()
        {
            IgnoreExtensions = true;
        }

        //Triggered when turtle connects
        protected override void OnOpen()
        {
            base.OnOpen();
        }

        //Triggered when receiving message from turtle
        protected override void OnMessage(MessageEventArgs e)
        {
            if(e.IsPing)
            {
                Console.WriteLine("WS got pinged");
                return;
            }
            if(e.IsBinary)
            {
                Console.WriteLine("WS received binary data");
                return;
            }
            if(!e.IsText)
            {
                return;
            }

            Console.WriteLine("WS received text data: {0}", e.Data);

            TurtleCommand cmd = null;

            try
            {
                cmd = JsonConvert.DeserializeObject<TurtleCommand>(e.Data);
            } catch(Exception ex)
            {
                Console.WriteLine("Error decoding Json from turtle: " + ex.ToString());
            }

            if(cmd == null) {
                return;
            };

            switch (cmd.type)
            {
                case "register":

                    break;
                case "result":

                    break;
                default:
                    Console.WriteLine($"Error understanding Turtle command: Invalid type \"{cmd.type}\"");
                    break;
            }
        }

        //Triggered when turtle disconnects
        protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
        }
    }
}
