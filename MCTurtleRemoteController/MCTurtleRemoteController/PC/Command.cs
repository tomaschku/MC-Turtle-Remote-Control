using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCTurtleRemoteController.PC
{
    //NOTE: This distinction is only here to make (de-)serialization on the PC side (aka in C#) easier and more understandable.
    //      The Turtle (or Computer) does not care, as long as all required fields are there

    /// <summary>
    /// Used for communication from PC -> Turtle
    /// </summary>
    public class PCCommand
    {
        public PCCommand(string type, string code, string target)
        {
            this.type = type;
            this.code = code;
            this.target = target;
        }

        /// <summary>
        /// (PCCommand) eval: Code to be executed by the turtle
        /// </summary>
        public string type;

        /// <summary>
        /// The code to execute (include a "return" statement if the returned result should not be empty)
        /// </summary>
        public string code;

        /// <summary>
        /// The target which should parse the message. (Can be either the id of the turtle or simply "broadcast".)
        /// </summary>
        public string target;
    }

    /// <summary>
    /// Used for communication from Turtle -> PC
    /// </summary>
    public class TurtleCommand
    {
        //Just here for completeness sake - doesn't really make sense to use explicitly
        public TurtleCommand(string id, string type, string result)
        {
            this.id = id;
            this.type = type;
            this.result = result;
        }

        /// <summary>
        /// The ID of the turtle. (Required)
        /// </summary>
        public string id;

        /// <summary>
        /// (TurtleCommand) register: The id of a turtle so it can be registered and specifically interacted with by the PC.
        /// (TurtleCommand) result: Turtle is returning the result of an operation.
        /// </summary>
        public string type;

        /// <summary>
        /// The result of the operation.
        /// (PCCommand) eval: The returned result
        /// (TurtleCommand) register: Reserved (Empty)
        /// </summary>
        public string result;
    }
}
