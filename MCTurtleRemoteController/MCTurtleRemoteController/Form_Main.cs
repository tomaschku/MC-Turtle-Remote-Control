using MCTurtleRemoteController.PC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCTurtleRemoteController
{
    public partial class Form_Main : Form
    {
        World world;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            world = new World();
            world.startWS();

            buttonTurtleForwards.Click += delegate { world.broadcastMovement(Movement.Forward); };
            buttonTurtleBackwards.Click += delegate { world.broadcastMovement(Movement.Backward); };
            buttonTurtleUp.Click += delegate { world.broadcastMovement(Movement.Up); };
            buttonTurtleDown.Click += delegate { world.broadcastMovement(Movement.Down); };
            buttonTurtleTurnLeft.Click += delegate { world.broadcastMovement(Movement.TurnLeft); };
            buttonTurtleTurnRight.Click += delegate { world.broadcastMovement(Movement.TurnRight); };
            buttonTurtleDig.Click += delegate { world.broadcastEval("turtle.dig()"); };
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            world.stopWS();
        }
    }
}
