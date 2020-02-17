namespace Team_Manager
{
    partial class TeamManager
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
            this.countriesdrpdwn = new Bunifu.Framework.UI.BunifuDropdown();
            this.tactics = new Bunifu.Framework.UI.BunifuDropdown();
            this.generateteambtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flags = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.position = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player0nn = new System.Windows.Forms.TextBox();
            this.player0n = new System.Windows.Forms.TextBox();
            this.player1p = new System.Windows.Forms.TextBox();
            this.player3nn = new System.Windows.Forms.TextBox();
            this.player3n = new System.Windows.Forms.TextBox();
            this.player4p = new System.Windows.Forms.TextBox();
            this.player2p = new System.Windows.Forms.TextBox();
            this.player1n = new System.Windows.Forms.TextBox();
            this.player1nn = new System.Windows.Forms.TextBox();
            this.player2nn = new System.Windows.Forms.TextBox();
            this.player2n = new System.Windows.Forms.TextBox();
            this.player3p = new System.Windows.Forms.TextBox();
            this.player4nn = new System.Windows.Forms.TextBox();
            this.player4n = new System.Windows.Forms.TextBox();
            this.player5p = new System.Windows.Forms.TextBox();
            this.player5nn = new System.Windows.Forms.TextBox();
            this.player5n = new System.Windows.Forms.TextBox();
            this.player6p = new System.Windows.Forms.TextBox();
            this.player6nn = new System.Windows.Forms.TextBox();
            this.player6n = new System.Windows.Forms.TextBox();
            this.player7p = new System.Windows.Forms.TextBox();
            this.player7nn = new System.Windows.Forms.TextBox();
            this.player7n = new System.Windows.Forms.TextBox();
            this.player8p = new System.Windows.Forms.TextBox();
            this.player8nn = new System.Windows.Forms.TextBox();
            this.player8n = new System.Windows.Forms.TextBox();
            this.player9p = new System.Windows.Forms.TextBox();
            this.player9nn = new System.Windows.Forms.TextBox();
            this.player9n = new System.Windows.Forms.TextBox();
            this.player10p = new System.Windows.Forms.TextBox();
            this.player10nn = new System.Windows.Forms.TextBox();
            this.player10n = new System.Windows.Forms.TextBox();
            this.player11p = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.flags)).BeginInit();
            this.SuspendLayout();
            // 
            // countriesdrpdwn
            // 
            this.countriesdrpdwn.BackColor = System.Drawing.Color.Transparent;
            this.countriesdrpdwn.BorderRadius = 3;
            this.countriesdrpdwn.ForeColor = System.Drawing.Color.White;
            this.countriesdrpdwn.Items = new string[0];
            this.countriesdrpdwn.Location = new System.Drawing.Point(6, 8);
            this.countriesdrpdwn.Name = "countriesdrpdwn";
            this.countriesdrpdwn.NomalColor = System.Drawing.SystemColors.Highlight;
            this.countriesdrpdwn.onHoverColor = System.Drawing.SystemColors.HotTrack;
            this.countriesdrpdwn.selectedIndex = -1;
            this.countriesdrpdwn.Size = new System.Drawing.Size(224, 35);
            this.countriesdrpdwn.TabIndex = 0;
            this.countriesdrpdwn.onItemSelected += new System.EventHandler(this.countriesdrpdwn_onItemSelected);
            // 
            // tactics
            // 
            this.tactics.BackColor = System.Drawing.Color.Transparent;
            this.tactics.BorderRadius = 3;
            this.tactics.ForeColor = System.Drawing.Color.White;
            this.tactics.Items = new string[] {
        "4-4-2",
        "4-3-3"};
            this.tactics.Location = new System.Drawing.Point(6, 436);
            this.tactics.Name = "tactics";
            this.tactics.NomalColor = System.Drawing.SystemColors.Highlight;
            this.tactics.onHoverColor = System.Drawing.SystemColors.HotTrack;
            this.tactics.selectedIndex = -1;
            this.tactics.Size = new System.Drawing.Size(134, 35);
            this.tactics.TabIndex = 4;
            this.tactics.onItemSelected += new System.EventHandler(this.tactics_onItemSelected);
            // 
            // generateteambtn
            // 
            this.generateteambtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.generateteambtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.generateteambtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateteambtn.BorderRadius = 0;
            this.generateteambtn.ButtonText = "GENERATE TEAM";
            this.generateteambtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateteambtn.DisabledColor = System.Drawing.Color.Gray;
            this.generateteambtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateteambtn.Iconcolor = System.Drawing.Color.Transparent;
            this.generateteambtn.Iconimage = null;
            this.generateteambtn.Iconimage_right = null;
            this.generateteambtn.Iconimage_right_Selected = null;
            this.generateteambtn.Iconimage_Selected = null;
            this.generateteambtn.IconMarginLeft = 0;
            this.generateteambtn.IconMarginRight = 0;
            this.generateteambtn.IconRightVisible = true;
            this.generateteambtn.IconRightZoom = 0D;
            this.generateteambtn.IconVisible = true;
            this.generateteambtn.IconZoom = 90D;
            this.generateteambtn.IsTab = false;
            this.generateteambtn.Location = new System.Drawing.Point(158, 435);
            this.generateteambtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generateteambtn.Name = "generateteambtn";
            this.generateteambtn.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.generateteambtn.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.generateteambtn.OnHoverTextColor = System.Drawing.Color.White;
            this.generateteambtn.selected = false;
            this.generateteambtn.Size = new System.Drawing.Size(193, 35);
            this.generateteambtn.TabIndex = 7;
            this.generateteambtn.Text = "GENERATE TEAM";
            this.generateteambtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateteambtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.generateteambtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateteambtn.Click += new System.EventHandler(this.generateteambtn_Click);
            // 
            // flags
            // 
            this.flags.Location = new System.Drawing.Point(238, 11);
            this.flags.Name = "flags";
            this.flags.Size = new System.Drawing.Size(32, 32);
            this.flags.TabIndex = 3;
            this.flags.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(139, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 360);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(40, 44);
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(100, 20);
            this.position.TabIndex = 9;
            this.position.Text = "Position";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(148, 44);
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 10;
            this.number.Text = "Number";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(258, 44);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 11;
            this.name.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(248, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 360);
            this.panel2.TabIndex = 9;
            // 
            // player0nn
            // 
            this.player0nn.Location = new System.Drawing.Point(258, 70);
            this.player0nn.Name = "player0nn";
            this.player0nn.Size = new System.Drawing.Size(100, 20);
            this.player0nn.TabIndex = 14;
            // 
            // player0n
            // 
            this.player0n.Location = new System.Drawing.Point(148, 70);
            this.player0n.Name = "player0n";
            this.player0n.Size = new System.Drawing.Size(100, 20);
            this.player0n.TabIndex = 13;
            // 
            // player1p
            // 
            this.player1p.Location = new System.Drawing.Point(39, 70);
            this.player1p.Name = "player1p";
            this.player1p.Size = new System.Drawing.Size(100, 20);
            this.player1p.TabIndex = 12;
            this.player1p.TextChanged += new System.EventHandler(this.player1p_TextChanged);
            // 
            // player3nn
            // 
            this.player3nn.Location = new System.Drawing.Point(258, 184);
            this.player3nn.Name = "player3nn";
            this.player3nn.Size = new System.Drawing.Size(100, 20);
            this.player3nn.TabIndex = 17;
            // 
            // player3n
            // 
            this.player3n.Location = new System.Drawing.Point(148, 184);
            this.player3n.Name = "player3n";
            this.player3n.Size = new System.Drawing.Size(100, 20);
            this.player3n.TabIndex = 16;
            // 
            // player4p
            // 
            this.player4p.Location = new System.Drawing.Point(39, 184);
            this.player4p.Name = "player4p";
            this.player4p.Size = new System.Drawing.Size(100, 20);
            this.player4p.TabIndex = 15;
            // 
            // player2p
            // 
            this.player2p.Location = new System.Drawing.Point(39, 106);
            this.player2p.Name = "player2p";
            this.player2p.Size = new System.Drawing.Size(100, 20);
            this.player2p.TabIndex = 15;
            // 
            // player1n
            // 
            this.player1n.Location = new System.Drawing.Point(148, 106);
            this.player1n.Name = "player1n";
            this.player1n.Size = new System.Drawing.Size(100, 20);
            this.player1n.TabIndex = 16;
            // 
            // player1nn
            // 
            this.player1nn.Location = new System.Drawing.Point(258, 106);
            this.player1nn.Name = "player1nn";
            this.player1nn.Size = new System.Drawing.Size(100, 20);
            this.player1nn.TabIndex = 17;
            // 
            // player2nn
            // 
            this.player2nn.Location = new System.Drawing.Point(258, 144);
            this.player2nn.Name = "player2nn";
            this.player2nn.Size = new System.Drawing.Size(100, 20);
            this.player2nn.TabIndex = 20;
            // 
            // player2n
            // 
            this.player2n.Location = new System.Drawing.Point(148, 144);
            this.player2n.Name = "player2n";
            this.player2n.Size = new System.Drawing.Size(100, 20);
            this.player2n.TabIndex = 19;
            // 
            // player3p
            // 
            this.player3p.Location = new System.Drawing.Point(39, 144);
            this.player3p.Name = "player3p";
            this.player3p.Size = new System.Drawing.Size(100, 20);
            this.player3p.TabIndex = 18;
            // 
            // player4nn
            // 
            this.player4nn.Location = new System.Drawing.Point(258, 223);
            this.player4nn.Name = "player4nn";
            this.player4nn.Size = new System.Drawing.Size(100, 20);
            this.player4nn.TabIndex = 23;
            // 
            // player4n
            // 
            this.player4n.Location = new System.Drawing.Point(148, 223);
            this.player4n.Name = "player4n";
            this.player4n.Size = new System.Drawing.Size(100, 20);
            this.player4n.TabIndex = 22;
            // 
            // player5p
            // 
            this.player5p.Location = new System.Drawing.Point(39, 223);
            this.player5p.Name = "player5p";
            this.player5p.Size = new System.Drawing.Size(100, 20);
            this.player5p.TabIndex = 21;
            // 
            // player5nn
            // 
            this.player5nn.Location = new System.Drawing.Point(258, 256);
            this.player5nn.Name = "player5nn";
            this.player5nn.Size = new System.Drawing.Size(100, 20);
            this.player5nn.TabIndex = 26;
            // 
            // player5n
            // 
            this.player5n.Location = new System.Drawing.Point(148, 256);
            this.player5n.Name = "player5n";
            this.player5n.Size = new System.Drawing.Size(100, 20);
            this.player5n.TabIndex = 25;
            // 
            // player6p
            // 
            this.player6p.Location = new System.Drawing.Point(39, 256);
            this.player6p.Name = "player6p";
            this.player6p.Size = new System.Drawing.Size(100, 20);
            this.player6p.TabIndex = 24;
            // 
            // player6nn
            // 
            this.player6nn.Location = new System.Drawing.Point(257, 286);
            this.player6nn.Name = "player6nn";
            this.player6nn.Size = new System.Drawing.Size(100, 20);
            this.player6nn.TabIndex = 29;
            // 
            // player6n
            // 
            this.player6n.Location = new System.Drawing.Point(147, 286);
            this.player6n.Name = "player6n";
            this.player6n.Size = new System.Drawing.Size(100, 20);
            this.player6n.TabIndex = 28;
            // 
            // player7p
            // 
            this.player7p.Location = new System.Drawing.Point(38, 286);
            this.player7p.Name = "player7p";
            this.player7p.Size = new System.Drawing.Size(100, 20);
            this.player7p.TabIndex = 27;
            // 
            // player7nn
            // 
            this.player7nn.Location = new System.Drawing.Point(258, 315);
            this.player7nn.Name = "player7nn";
            this.player7nn.Size = new System.Drawing.Size(100, 20);
            this.player7nn.TabIndex = 32;
            // 
            // player7n
            // 
            this.player7n.Location = new System.Drawing.Point(148, 315);
            this.player7n.Name = "player7n";
            this.player7n.Size = new System.Drawing.Size(100, 20);
            this.player7n.TabIndex = 31;
            // 
            // player8p
            // 
            this.player8p.Location = new System.Drawing.Point(39, 315);
            this.player8p.Name = "player8p";
            this.player8p.Size = new System.Drawing.Size(100, 20);
            this.player8p.TabIndex = 30;
            // 
            // player8nn
            // 
            this.player8nn.Location = new System.Drawing.Point(258, 345);
            this.player8nn.Name = "player8nn";
            this.player8nn.Size = new System.Drawing.Size(100, 20);
            this.player8nn.TabIndex = 35;
            // 
            // player8n
            // 
            this.player8n.Location = new System.Drawing.Point(148, 345);
            this.player8n.Name = "player8n";
            this.player8n.Size = new System.Drawing.Size(100, 20);
            this.player8n.TabIndex = 34;
            // 
            // player9p
            // 
            this.player9p.Location = new System.Drawing.Point(39, 345);
            this.player9p.Name = "player9p";
            this.player9p.Size = new System.Drawing.Size(100, 20);
            this.player9p.TabIndex = 33;
            // 
            // player9nn
            // 
            this.player9nn.Location = new System.Drawing.Point(258, 378);
            this.player9nn.Name = "player9nn";
            this.player9nn.Size = new System.Drawing.Size(100, 20);
            this.player9nn.TabIndex = 38;
            // 
            // player9n
            // 
            this.player9n.Location = new System.Drawing.Point(148, 378);
            this.player9n.Name = "player9n";
            this.player9n.Size = new System.Drawing.Size(100, 20);
            this.player9n.TabIndex = 37;
            // 
            // player10p
            // 
            this.player10p.Location = new System.Drawing.Point(39, 378);
            this.player10p.Name = "player10p";
            this.player10p.Size = new System.Drawing.Size(100, 20);
            this.player10p.TabIndex = 36;
            // 
            // player10nn
            // 
            this.player10nn.Location = new System.Drawing.Point(259, 409);
            this.player10nn.Name = "player10nn";
            this.player10nn.Size = new System.Drawing.Size(100, 20);
            this.player10nn.TabIndex = 41;
            // 
            // player10n
            // 
            this.player10n.Location = new System.Drawing.Point(149, 409);
            this.player10n.Name = "player10n";
            this.player10n.Size = new System.Drawing.Size(100, 20);
            this.player10n.TabIndex = 40;
            // 
            // player11p
            // 
            this.player11p.Location = new System.Drawing.Point(40, 409);
            this.player11p.Name = "player11p";
            this.player11p.Size = new System.Drawing.Size(100, 20);
            this.player11p.TabIndex = 39;
            // 
            // TeamManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(415, 483);
            this.Controls.Add(this.player10nn);
            this.Controls.Add(this.player10n);
            this.Controls.Add(this.player11p);
            this.Controls.Add(this.player9nn);
            this.Controls.Add(this.player9n);
            this.Controls.Add(this.player10p);
            this.Controls.Add(this.player8nn);
            this.Controls.Add(this.player8n);
            this.Controls.Add(this.player9p);
            this.Controls.Add(this.player7nn);
            this.Controls.Add(this.player7n);
            this.Controls.Add(this.player8p);
            this.Controls.Add(this.player6nn);
            this.Controls.Add(this.player6n);
            this.Controls.Add(this.player7p);
            this.Controls.Add(this.player5nn);
            this.Controls.Add(this.player5n);
            this.Controls.Add(this.player6p);
            this.Controls.Add(this.player4nn);
            this.Controls.Add(this.player4n);
            this.Controls.Add(this.player5p);
            this.Controls.Add(this.player2nn);
            this.Controls.Add(this.player2n);
            this.Controls.Add(this.player3p);
            this.Controls.Add(this.player1nn);
            this.Controls.Add(this.player1n);
            this.Controls.Add(this.player3nn);
            this.Controls.Add(this.player2p);
            this.Controls.Add(this.player3n);
            this.Controls.Add(this.player4p);
            this.Controls.Add(this.player0nn);
            this.Controls.Add(this.player0n);
            this.Controls.Add(this.player1p);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.position);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.generateteambtn);
            this.Controls.Add(this.tactics);
            this.Controls.Add(this.flags);
            this.Controls.Add(this.countriesdrpdwn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(431, 522);
            this.MinimumSize = new System.Drawing.Size(431, 522);
            this.Name = "TeamManager";
            this.Text = "Team Manager";
            this.Load += new System.EventHandler(this.TeamManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown countriesdrpdwn;
        private System.Windows.Forms.PictureBox flags;
        private Bunifu.Framework.UI.BunifuDropdown tactics;
        private Bunifu.Framework.UI.BunifuFlatButton generateteambtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox player0nn;
        private System.Windows.Forms.TextBox player0n;
        private System.Windows.Forms.TextBox player1p;
        private System.Windows.Forms.TextBox player3nn;
        private System.Windows.Forms.TextBox player3n;
        private System.Windows.Forms.TextBox player4p;
        private System.Windows.Forms.TextBox player2p;
        private System.Windows.Forms.TextBox player1n;
        private System.Windows.Forms.TextBox player1nn;
        private System.Windows.Forms.TextBox player2nn;
        private System.Windows.Forms.TextBox player2n;
        private System.Windows.Forms.TextBox player3p;
        private System.Windows.Forms.TextBox player4nn;
        private System.Windows.Forms.TextBox player4n;
        private System.Windows.Forms.TextBox player5p;
        private System.Windows.Forms.TextBox player5nn;
        private System.Windows.Forms.TextBox player5n;
        private System.Windows.Forms.TextBox player6p;
        private System.Windows.Forms.TextBox player6nn;
        private System.Windows.Forms.TextBox player6n;
        private System.Windows.Forms.TextBox player7p;
        private System.Windows.Forms.TextBox player7nn;
        private System.Windows.Forms.TextBox player7n;
        private System.Windows.Forms.TextBox player8p;
        private System.Windows.Forms.TextBox player8nn;
        private System.Windows.Forms.TextBox player8n;
        private System.Windows.Forms.TextBox player9p;
        private System.Windows.Forms.TextBox player9nn;
        private System.Windows.Forms.TextBox player9n;
        private System.Windows.Forms.TextBox player10p;
        private System.Windows.Forms.TextBox player10nn;
        private System.Windows.Forms.TextBox player10n;
        private System.Windows.Forms.TextBox player11p;
    }
}

