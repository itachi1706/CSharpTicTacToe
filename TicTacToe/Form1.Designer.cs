namespace TicTacToe
{
    partial class Form1
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
            this.r11 = new System.Windows.Forms.Button();
            this.r12 = new System.Windows.Forms.Button();
            this.r21 = new System.Windows.Forms.Button();
            this.r22 = new System.Windows.Forms.Button();
            this.r31 = new System.Windows.Forms.Button();
            this.r32 = new System.Windows.Forms.Button();
            this.r13 = new System.Windows.Forms.Button();
            this.r23 = new System.Windows.Forms.Button();
            this.r33 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbSP = new System.Windows.Forms.RadioButton();
            this.rbMP = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSelect = new System.Windows.Forms.GroupBox();
            this.grpGamePlay = new System.Windows.Forms.GroupBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupSelect.SuspendLayout();
            this.grpGamePlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // r11
            // 
            this.r11.Location = new System.Drawing.Point(6, 19);
            this.r11.Name = "r11";
            this.r11.Size = new System.Drawing.Size(75, 23);
            this.r11.TabIndex = 0;
            this.r11.Text = "button1";
            this.r11.UseVisualStyleBackColor = true;
            this.r11.Click += new System.EventHandler(this.r11_Click);
            // 
            // r12
            // 
            this.r12.Location = new System.Drawing.Point(87, 19);
            this.r12.Name = "r12";
            this.r12.Size = new System.Drawing.Size(75, 23);
            this.r12.TabIndex = 1;
            this.r12.Text = "button2";
            this.r12.UseVisualStyleBackColor = true;
            this.r12.Click += new System.EventHandler(this.r12_Click);
            // 
            // r21
            // 
            this.r21.Location = new System.Drawing.Point(5, 48);
            this.r21.Name = "r21";
            this.r21.Size = new System.Drawing.Size(75, 23);
            this.r21.TabIndex = 2;
            this.r21.Text = "button3";
            this.r21.UseVisualStyleBackColor = true;
            this.r21.Click += new System.EventHandler(this.r21_Click);
            // 
            // r22
            // 
            this.r22.Location = new System.Drawing.Point(87, 48);
            this.r22.Name = "r22";
            this.r22.Size = new System.Drawing.Size(75, 23);
            this.r22.TabIndex = 3;
            this.r22.Text = "button4";
            this.r22.UseVisualStyleBackColor = true;
            this.r22.Click += new System.EventHandler(this.r22_Click);
            // 
            // r31
            // 
            this.r31.Location = new System.Drawing.Point(6, 77);
            this.r31.Name = "r31";
            this.r31.Size = new System.Drawing.Size(75, 23);
            this.r31.TabIndex = 4;
            this.r31.Text = "button5";
            this.r31.UseVisualStyleBackColor = true;
            this.r31.Click += new System.EventHandler(this.r31_Click);
            // 
            // r32
            // 
            this.r32.Location = new System.Drawing.Point(87, 77);
            this.r32.Name = "r32";
            this.r32.Size = new System.Drawing.Size(75, 23);
            this.r32.TabIndex = 5;
            this.r32.Text = "button6";
            this.r32.UseVisualStyleBackColor = true;
            this.r32.Click += new System.EventHandler(this.r32_Click);
            // 
            // r13
            // 
            this.r13.Location = new System.Drawing.Point(168, 19);
            this.r13.Name = "r13";
            this.r13.Size = new System.Drawing.Size(75, 23);
            this.r13.TabIndex = 6;
            this.r13.Text = "button7";
            this.r13.UseVisualStyleBackColor = true;
            this.r13.Click += new System.EventHandler(this.r13_Click);
            // 
            // r23
            // 
            this.r23.Location = new System.Drawing.Point(168, 48);
            this.r23.Name = "r23";
            this.r23.Size = new System.Drawing.Size(75, 23);
            this.r23.TabIndex = 7;
            this.r23.Text = "button8";
            this.r23.UseVisualStyleBackColor = true;
            this.r23.Click += new System.EventHandler(this.r23_Click);
            // 
            // r33
            // 
            this.r33.Location = new System.Drawing.Point(168, 77);
            this.r33.Name = "r33";
            this.r33.Size = new System.Drawing.Size(75, 23);
            this.r33.TabIndex = 8;
            this.r33.Text = "button9";
            this.r33.UseVisualStyleBackColor = true;
            this.r33.Click += new System.EventHandler(this.r33_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(169, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbSP
            // 
            this.rbSP.AutoSize = true;
            this.rbSP.Checked = true;
            this.rbSP.Location = new System.Drawing.Point(12, 22);
            this.rbSP.Name = "rbSP";
            this.rbSP.Size = new System.Drawing.Size(63, 17);
            this.rbSP.TabIndex = 11;
            this.rbSP.TabStop = true;
            this.rbSP.Text = "1 Player";
            this.rbSP.UseVisualStyleBackColor = true;
            // 
            // rbMP
            // 
            this.rbMP.AutoSize = true;
            this.rbMP.Location = new System.Drawing.Point(104, 22);
            this.rbMP.Name = "rbMP";
            this.rbMP.Size = new System.Drawing.Size(63, 17);
            this.rbMP.TabIndex = 12;
            this.rbMP.Text = "2 Player";
            this.rbMP.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupSelect
            // 
            this.groupSelect.Controls.Add(this.rbMP);
            this.groupSelect.Controls.Add(this.rbSP);
            this.groupSelect.Location = new System.Drawing.Point(65, 34);
            this.groupSelect.Name = "groupSelect";
            this.groupSelect.Size = new System.Drawing.Size(200, 42);
            this.groupSelect.TabIndex = 14;
            this.groupSelect.TabStop = false;
            this.groupSelect.Text = "Select Mode";
            // 
            // grpGamePlay
            // 
            this.grpGamePlay.Controls.Add(this.r11);
            this.grpGamePlay.Controls.Add(this.r12);
            this.grpGamePlay.Controls.Add(this.r21);
            this.grpGamePlay.Controls.Add(this.r22);
            this.grpGamePlay.Controls.Add(this.r33);
            this.grpGamePlay.Controls.Add(this.r31);
            this.grpGamePlay.Controls.Add(this.r23);
            this.grpGamePlay.Controls.Add(this.r32);
            this.grpGamePlay.Controls.Add(this.r13);
            this.grpGamePlay.Location = new System.Drawing.Point(41, 82);
            this.grpGamePlay.Name = "grpGamePlay";
            this.grpGamePlay.Size = new System.Drawing.Size(250, 100);
            this.grpGamePlay.TabIndex = 15;
            this.grpGamePlay.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(38, 195);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(126, 13);
            this.lblInstructions.TabIndex = 16;
            this.lblInstructions.Text = "Press Start Game to Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.grpGamePlay);
            this.Controls.Add(this.groupSelect);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupSelect.ResumeLayout(false);
            this.groupSelect.PerformLayout();
            this.grpGamePlay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button r11;
        private System.Windows.Forms.Button r12;
        private System.Windows.Forms.Button r21;
        private System.Windows.Forms.Button r22;
        private System.Windows.Forms.Button r31;
        private System.Windows.Forms.Button r32;
        private System.Windows.Forms.Button r13;
        private System.Windows.Forms.Button r23;
        private System.Windows.Forms.Button r33;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbSP;
        private System.Windows.Forms.RadioButton rbMP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupSelect;
        private System.Windows.Forms.GroupBox grpGamePlay;
        private System.Windows.Forms.Label lblInstructions;
    }
}

