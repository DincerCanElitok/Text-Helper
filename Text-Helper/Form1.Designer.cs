namespace Text_Helper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_leftmenu = new System.Windows.Forms.Panel();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_Github = new System.Windows.Forms.Button();
            this.btn_Graphic = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_Analyze = new System.Windows.Forms.Button();
            this.pnl_TextHelper = new System.Windows.Forms.Panel();
            this.TextHelperLabel = new System.Windows.Forms.Label();
            this.pictB_TextHelpericon = new System.Windows.Forms.PictureBox();
            this.pnl_Topbar = new System.Windows.Forms.Panel();
            this.btnNoS_Quit = new Text_Helper.NoSelectButton();
            this.btnNoS_Maximize = new Text_Helper.NoSelectButton();
            this.btnNoS_Minimize = new Text_Helper.NoSelectButton();
            this.pnl_FormLoader = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_leftmenu.SuspendLayout();
            this.pnl_TextHelper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictB_TextHelpericon)).BeginInit();
            this.pnl_Topbar.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_leftmenu
            // 
            this.pnl_leftmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_leftmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl_leftmenu.Controls.Add(this.pnl_Nav);
            this.pnl_leftmenu.Controls.Add(this.btn_Github);
            this.pnl_leftmenu.Controls.Add(this.btn_Graphic);
            this.pnl_leftmenu.Controls.Add(this.btn_Result);
            this.pnl_leftmenu.Controls.Add(this.btn_Analyze);
            this.pnl_leftmenu.Controls.Add(this.pnl_TextHelper);
            this.pnl_leftmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_leftmenu.Location = new System.Drawing.Point(0, 31);
            this.pnl_leftmenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_leftmenu.Name = "pnl_leftmenu";
            this.pnl_leftmenu.Size = new System.Drawing.Size(256, 777);
            this.pnl_leftmenu.TabIndex = 0;
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnl_Nav.Location = new System.Drawing.Point(0, 193);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(3, 100);
            this.pnl_Nav.TabIndex = 2;
            // 
            // btn_Github
            // 
            this.btn_Github.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Github.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Github.FlatAppearance.BorderSize = 0;
            this.btn_Github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Github.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Github.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Github.Image = global::Text_Helper.Properties.Resources.github;
            this.btn_Github.Location = new System.Drawing.Point(0, 690);
            this.btn_Github.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Github.Name = "btn_Github";
            this.btn_Github.Size = new System.Drawing.Size(256, 87);
            this.btn_Github.TabIndex = 1;
            this.btn_Github.Text = "Github";
            this.btn_Github.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Github.UseVisualStyleBackColor = true;
            this.btn_Github.Click += new System.EventHandler(this.btn_Github_Click);
            this.btn_Github.Leave += new System.EventHandler(this.btn_Github_Leave);
            // 
            // btn_Graphic
            // 
            this.btn_Graphic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Graphic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Graphic.FlatAppearance.BorderSize = 0;
            this.btn_Graphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Graphic.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Graphic.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Graphic.Image = global::Text_Helper.Properties.Resources.graphic;
            this.btn_Graphic.Location = new System.Drawing.Point(0, 376);
            this.btn_Graphic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Graphic.Name = "btn_Graphic";
            this.btn_Graphic.Size = new System.Drawing.Size(256, 87);
            this.btn_Graphic.TabIndex = 1;
            this.btn_Graphic.Text = "Graphic";
            this.btn_Graphic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Graphic.UseVisualStyleBackColor = true;
            this.btn_Graphic.Click += new System.EventHandler(this.btn_Graphic_Click);
            this.btn_Graphic.Leave += new System.EventHandler(this.btn_Graphic_Leave);
            // 
            // btn_Result
            // 
            this.btn_Result.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Result.FlatAppearance.BorderSize = 0;
            this.btn_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Result.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Result.Image = global::Text_Helper.Properties.Resources.result;
            this.btn_Result.Location = new System.Drawing.Point(0, 289);
            this.btn_Result.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(256, 87);
            this.btn_Result.TabIndex = 1;
            this.btn_Result.Text = "Result";
            this.btn_Result.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            this.btn_Result.Leave += new System.EventHandler(this.btn_Result_Leave);
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Analyze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Analyze.FlatAppearance.BorderSize = 0;
            this.btn_Analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Analyze.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Analyze.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Analyze.Image = global::Text_Helper.Properties.Resources.search1;
            this.btn_Analyze.Location = new System.Drawing.Point(0, 202);
            this.btn_Analyze.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(256, 87);
            this.btn_Analyze.TabIndex = 1;
            this.btn_Analyze.Text = "Analyze";
            this.btn_Analyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            this.btn_Analyze.Leave += new System.EventHandler(this.btn_Analyze_Leave);
            // 
            // pnl_TextHelper
            // 
            this.pnl_TextHelper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_TextHelper.Controls.Add(this.TextHelperLabel);
            this.pnl_TextHelper.Controls.Add(this.pictB_TextHelpericon);
            this.pnl_TextHelper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TextHelper.Location = new System.Drawing.Point(0, 0);
            this.pnl_TextHelper.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TextHelper.Name = "pnl_TextHelper";
            this.pnl_TextHelper.Size = new System.Drawing.Size(256, 202);
            this.pnl_TextHelper.TabIndex = 0;
            // 
            // TextHelperLabel
            // 
            this.TextHelperLabel.AutoSize = true;
            this.TextHelperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextHelperLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TextHelperLabel.Location = new System.Drawing.Point(64, 136);
            this.TextHelperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextHelperLabel.Name = "TextHelperLabel";
            this.TextHelperLabel.Size = new System.Drawing.Size(124, 25);
            this.TextHelperLabel.TabIndex = 1;
            this.TextHelperLabel.Text = "Text Helper";
            // 
            // pictB_TextHelpericon
            // 
            this.pictB_TextHelpericon.Image = global::Text_Helper.Properties.Resources.text_w;
            this.pictB_TextHelpericon.Location = new System.Drawing.Point(80, 45);
            this.pictB_TextHelpericon.Margin = new System.Windows.Forms.Padding(4);
            this.pictB_TextHelpericon.Name = "pictB_TextHelpericon";
            this.pictB_TextHelpericon.Size = new System.Drawing.Size(85, 87);
            this.pictB_TextHelpericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictB_TextHelpericon.TabIndex = 0;
            this.pictB_TextHelpericon.TabStop = false;
            // 
            // pnl_Topbar
            // 
            this.pnl_Topbar.AutoSize = true;
            this.pnl_Topbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Topbar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_Topbar.Controls.Add(this.btnNoS_Quit);
            this.pnl_Topbar.Controls.Add(this.btnNoS_Maximize);
            this.pnl_Topbar.Controls.Add(this.btnNoS_Minimize);
            this.pnl_Topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Topbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Topbar.Name = "pnl_Topbar";
            this.pnl_Topbar.Size = new System.Drawing.Size(1308, 31);
            this.pnl_Topbar.TabIndex = 1;
            this.pnl_Topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Topbar_MouseDown);
            // 
            // btnNoS_Quit
            // 
            this.btnNoS_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoS_Quit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoS_Quit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoS_Quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoS_Quit.BackgroundImage")));
            this.btnNoS_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoS_Quit.Location = new System.Drawing.Point(1267, 0);
            this.btnNoS_Quit.Name = "btnNoS_Quit";
            this.btnNoS_Quit.Size = new System.Drawing.Size(41, 28);
            this.btnNoS_Quit.TabIndex = 1;
            this.btnNoS_Quit.UseVisualStyleBackColor = false;
            this.btnNoS_Quit.Click += new System.EventHandler(this.btnNoS_Quit_Click);
            // 
            // btnNoS_Maximize
            // 
            this.btnNoS_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoS_Maximize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoS_Maximize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoS_Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNoS_Maximize.BackgroundImage")));
            this.btnNoS_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoS_Maximize.Location = new System.Drawing.Point(1230, 0);
            this.btnNoS_Maximize.Name = "btnNoS_Maximize";
            this.btnNoS_Maximize.Size = new System.Drawing.Size(41, 28);
            this.btnNoS_Maximize.TabIndex = 1;
            this.btnNoS_Maximize.UseVisualStyleBackColor = false;
            this.btnNoS_Maximize.Click += new System.EventHandler(this.btnNoS_Maximize_Click);
            // 
            // btnNoS_Minimize
            // 
            this.btnNoS_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoS_Minimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoS_Minimize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoS_Minimize.BackgroundImage = global::Text_Helper.Properties.Resources.minimize;
            this.btnNoS_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoS_Minimize.Location = new System.Drawing.Point(1193, 0);
            this.btnNoS_Minimize.Name = "btnNoS_Minimize";
            this.btnNoS_Minimize.Size = new System.Drawing.Size(41, 28);
            this.btnNoS_Minimize.TabIndex = 1;
            this.btnNoS_Minimize.UseVisualStyleBackColor = false;
            this.btnNoS_Minimize.Click += new System.EventHandler(this.btnNoS_Minimize_Click);
            // 
            // pnl_FormLoader
            // 
            this.pnl_FormLoader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_FormLoader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_FormLoader.Location = new System.Drawing.Point(256, 117);
            this.pnl_FormLoader.Name = "pnl_FormLoader";
            this.pnl_FormLoader.Size = new System.Drawing.Size(1052, 661);
            this.pnl_FormLoader.TabIndex = 2;
            // 
            // pnl_Header
            // 
            this.pnl_Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(256, 31);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1052, 86);
            this.pnl_Header.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Title.Location = new System.Drawing.Point(0, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(263, 59);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Analyze Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1308, 808);
            this.Controls.Add(this.pnl_FormLoader);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_leftmenu);
            this.Controls.Add(this.pnl_Topbar);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnl_leftmenu.ResumeLayout(false);
            this.pnl_TextHelper.ResumeLayout(false);
            this.pnl_TextHelper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictB_TextHelpericon)).EndInit();
            this.pnl_Topbar.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_leftmenu;
        private System.Windows.Forms.Panel pnl_TextHelper;
        private System.Windows.Forms.PictureBox pictB_TextHelpericon;
        private System.Windows.Forms.Button btn_Analyze;
        private System.Windows.Forms.Label TextHelperLabel;
        private System.Windows.Forms.Button btn_Github;
        private System.Windows.Forms.Button btn_Graphic;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.Panel pnl_Nav;
        private System.Windows.Forms.Panel pnl_Topbar;
        private System.Windows.Forms.Panel pnl_FormLoader;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private NoSelectButton btnNoS_Minimize;
        private NoSelectButton btnNoS_Quit;
        private NoSelectButton btnNoS_Maximize;
    }
}

