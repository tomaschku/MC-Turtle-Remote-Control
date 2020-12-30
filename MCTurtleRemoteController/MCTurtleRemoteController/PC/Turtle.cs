using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MCTurtleRemoteController.PC
{
    public class Turtle
    {
        public readonly int id;

        public Turtle(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Executes any given code on the turtle.
        /// TODO: Result will handled by a callback.
        /// </summary>
        /// <param name="code">The Lua Code to execute</param>
        /// <param name="includeReturn">Wether to prepend "return " to <paramref name="code"/>. (Empty responses of the turtle are ignored => If this is false, nothing will come back from the Turtle)</param>
        public void Eval(string code, bool includeReturn = true)
        {
            if (includeReturn)
                code = "return " + code;

            PCCommand cmd = new PCCommand("eval", code, id.ToString());
            string evalCmd = JsonConvert.SerializeObject(cmd, Formatting.None);
        }

        public void Move(Movement movement)
        {
            string cmd = "turtle.";

            switch (movement)
            {
                case Movement.Forward:
                    cmd += "forward()";
                    break;
                case Movement.Backward:
                    cmd += "back()";
                    break;
                case Movement.Up:
                    cmd += "up()";
                    break;
                case Movement.Down:
                    cmd += "down()";
                    break;
                case Movement.TurnLeft:
                    cmd += "turnLeft()";
                    break;
                case Movement.TurnRight:
                    cmd += "turnRight()";
                    break;
            }

            Eval(cmd, false);
        }

        public void Dig()
        {
            Eval("turtle.dig()", false);
        }
    }
}
