
namespace MCTurtleRemoteController
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewEntries = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonTurtleTurnRight = new System.Windows.Forms.Button();
            this.buttonTurtleTurnLeft = new System.Windows.Forms.Button();
            this.buttonTurtleDown = new System.Windows.Forms.Button();
            this.buttonTurtleUp = new System.Windows.Forms.Button();
            this.buttonTurtleBackwards = new System.Windows.Forms.Button();
            this.buttonTurtleForwards = new System.Windows.Forms.Button();
            this.buttonTurtleDig = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewEntries
            // 
            this.treeViewEntries.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewEntries.FullRowSelect = true;
            this.treeViewEntries.HotTracking = true;
            this.treeViewEntries.Indent = 10;
            this.treeViewEntries.Location = new System.Drawing.Point(0, 0);
            this.treeViewEntries.Name = "treeViewEntries";
            this.treeViewEntries.Size = new System.Drawing.Size(120, 351);
            this.treeViewEntries.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(523, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonTurtleDig);
            this.panelMain.Controls.Add(this.buttonTurtleTurnRight);
            this.panelMain.Controls.Add(this.buttonTurtleTurnLeft);
            this.panelMain.Controls.Add(this.buttonTurtleDown);
            this.panelMain.Controls.Add(this.buttonTurtleUp);
            this.panelMain.Controls.Add(this.buttonTurtleBackwards);
            this.panelMain.Controls.Add(this.buttonTurtleForwards);
            this.panelMain.Controls.Add(this.treeViewEntries);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(523, 351);
            this.panelMain.TabIndex = 2;
            // 
            // buttonTurtleTurnRight
            // 
            this.buttonTurtleTurnRight.Location = new System.Drawing.Point(353, 82);
            this.buttonTurtleTurnRight.Name = "buttonTurtleTurnRight";
            this.buttonTurtleTurnRight.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleTurnRight.TabIndex = 6;
            this.buttonTurtleTurnRight.Text = "Turn Right";
            this.buttonTurtleTurnRight.UseVisualStyleBackColor = true;
            // 
            // buttonTurtleTurnLeft
            // 
            this.buttonTurtleTurnLeft.Location = new System.Drawing.Point(219, 82);
            this.buttonTurtleTurnLeft.Name = "buttonTurtleTurnLeft";
            this.buttonTurtleTurnLeft.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleTurnLeft.TabIndex = 5;
            this.buttonTurtleTurnLeft.Text = "Turn Left";
            this.buttonTurtleTurnLeft.UseVisualStyleBackColor = true;
            // 
            // buttonTurtleDown
            // 
            this.buttonTurtleDown.Location = new System.Drawing.Point(130, 151);
            this.buttonTurtleDown.Name = "buttonTurtleDown";
            this.buttonTurtleDown.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleDown.TabIndex = 4;
            this.buttonTurtleDown.Text = "Down";
            this.buttonTurtleDown.UseVisualStyleBackColor = true;
            // 
            // buttonTurtleUp
            // 
            this.buttonTurtleUp.Location = new System.Drawing.Point(130, 13);
            this.buttonTurtleUp.Name = "buttonTurtleUp";
            this.buttonTurtleUp.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleUp.TabIndex = 3;
            this.buttonTurtleUp.Text = "Up";
            this.buttonTurtleUp.UseVisualStyleBackColor = true;
            // 
            // buttonTurtleBackwards
            // 
            this.buttonTurtleBackwards.Location = new System.Drawing.Point(286, 151);
            this.buttonTurtleBackwards.Name = "buttonTurtleBackwards";
            this.buttonTurtleBackwards.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleBackwards.TabIndex = 2;
            this.buttonTurtleBackwards.Text = "Backwards";
            this.buttonTurtleBackwards.UseVisualStyleBackColor = true;
            // 
            // buttonTurtleForwards
            // 
            this.buttonTurtleForwards.Location = new System.Drawing.Point(286, 13);
            this.buttonTurtleForwards.Name = "buttonTurtleForwards";
            this.buttonTurtleForwards.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleForwards.TabIndex = 1;
            this.buttonTurtleForwards.Text = "Forwards";
            this.buttonTurtleForwards.UseVisualStyleBackColor = true;
            // 
            // buttonTurtleDig
            // 
            this.buttonTurtleDig.Location = new System.Drawing.Point(441, 13);
            this.buttonTurtleDig.Name = "buttonTurtleDig";
            this.buttonTurtleDig.Size = new System.Drawing.Size(70, 70);
            this.buttonTurtleDig.TabIndex = 7;
            this.buttonTurtleDig.Text = "Dig";
            this.buttonTurtleDig.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 376);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_Main";
            this.Text = "MC Turtle Remote Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewEntries;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonTurtleBackwards;
        private System.Windows.Forms.Button buttonTurtleForwards;
        private System.Windows.Forms.Button buttonTurtleDown;
        private System.Windows.Forms.Button buttonTurtleUp;
        private System.Windows.Forms.Button buttonTurtleTurnRight;
        private System.Windows.Forms.Button buttonTurtleTurnLeft;
        private System.Windows.Forms.Button buttonTurtleDig;
    }
}

