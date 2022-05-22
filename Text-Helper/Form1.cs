using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Text_Helper
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Panel panel1;
        private Button btn_Analyze;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Github;
        private Button btn_Graphic;
        private Button btn_Result;
        private Panel pnl_TitleBar;
        private Panel pnl_FormLoader;
        private NoSelectButton noSelectButton1;
        private NoSelectButton noSelectButton3;
        private NoSelectButton noSelectButton2;
        private Panel pnl_Nav;

        public Form1()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }
        protected override void WndProc(ref Message m) //resizeble form
        {
            const UInt32 WM_NCHITTEST = 0x0084;
            const UInt32 WM_MOUSEMOVE = 0x0200;

            const UInt32 HTLEFT = 10;
            const UInt32 HTRIGHT = 11;
            const UInt32 HTBOTTOMRIGHT = 17;
            const UInt32 HTBOTTOM = 15;
            const UInt32 HTBOTTOMLEFT = 16;
            const UInt32 HTTOP = 12;
            const UInt32 HTTOPLEFT = 13;
            const UInt32 HTTOPRIGHT = 14;

            const int RESIZE_HANDLE_SIZE = 10;
            bool handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                Size formSize = this.Size;
                Point screenPoint = new Point(m.LParam.ToInt32());
                Point clientPoint = this.PointToClient(screenPoint);

                Dictionary<UInt32, Rectangle> boxes = new Dictionary<UInt32, Rectangle>() {
            {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOM, new Rectangle(RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, formSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE)},
            {HTRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE)},
            {HTTOPRIGHT, new Rectangle(formSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOP, new Rectangle(RESIZE_HANDLE_SIZE, 0, formSize.Width - 2*RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTTOPLEFT, new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE) },
            {HTLEFT, new Rectangle(0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, formSize.Height - 2*RESIZE_HANDLE_SIZE) }
        };

                foreach (KeyValuePair<UInt32, Rectangle> hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Analyze.PerformClick();
            btn_Analyze.Select();
        }


        private void btn_Analyze_Click(object sender, EventArgs e)
        {
            pnl_Nav.BackColor = Color.FromArgb(0, 126, 249);
            pnl_Nav.Height = btn_Analyze.Height;
            pnl_Nav.Top = btn_Analyze.Top;
            pnl_Nav.Left = btn_Analyze.Left;
            btn_Analyze.BackColor = Color.FromArgb(46,51,73);

            this.pnl_FormLoader.Controls.Clear();
            FormAnalyze form_Analyze_Vrb = new FormAnalyze() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            form_Analyze_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(form_Analyze_Vrb);
            form_Analyze_Vrb.Show();
        }
        private void btn_Result_Click(object sender, EventArgs e)
        {
            pnl_Nav.BackColor = Color.FromArgb(0, 126, 249);
            pnl_Nav.Height = btn_Result.Height;
            pnl_Nav.Top = btn_Result.Top;
            btn_Result.BackColor = Color.FromArgb(46, 51, 73);

            this.pnl_FormLoader.Controls.Clear();
            FormResult form_Result_Vrb = new FormResult() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            form_Result_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(form_Result_Vrb);
            form_Result_Vrb.Show();
        }
        private void btn_Graphic_Click(object sender, EventArgs e)
        {
            pnl_Nav.BackColor = Color.FromArgb(0, 126, 249); 
            pnl_Nav.Height = btn_Graphic.Height;
            pnl_Nav.Top = btn_Graphic.Top;
            btn_Graphic.BackColor = Color.FromArgb(46, 51, 73);

            this.pnl_FormLoader.Controls.Clear();
            FormGraphic form_Graphic_Vrb = new FormGraphic() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            form_Graphic_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(form_Graphic_Vrb);
            form_Graphic_Vrb.Show();
        }
        private void btn_Github_Click(object sender, EventArgs e)
        {
            pnl_Nav.BackColor = Color.Gray;
            btn_Github.BackColor = Color.FromArgb(46, 51, 73);

            this.pnl_FormLoader.Controls.Clear();
            FormGithub form_Github_Vrb = new FormGithub() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            form_Github_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnl_FormLoader.Controls.Add(form_Github_Vrb);
            form_Github_Vrb.Show();
        }

        private void btn_Analyze_Leave(object sender, EventArgs e)
        {
            btn_Analyze.BackColor = Color.FromArgb(24,30,54);
        }

        private void btn_Result_Leave(object sender, EventArgs e)
        {
            btn_Result.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Graphic_Leave(object sender, EventArgs e)
        {
            btn_Graphic.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btn_Github_Leave(object sender, EventArgs e)
        {
            btn_Github.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNoS_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNoS_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnNoS_Minimize_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;                
        }
        private void pnl_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_Resize_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Nav = new System.Windows.Forms.Panel();
            this.btn_Github = new System.Windows.Forms.Button();
            this.btn_Graphic = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.btn_Analyze = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_TitleBar = new System.Windows.Forms.Panel();
            this.noSelectButton3 = new Text_Helper.NoSelectButton();
            this.noSelectButton2 = new Text_Helper.NoSelectButton();
            this.noSelectButton1 = new Text_Helper.NoSelectButton();
            this.pnl_FormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnl_Nav);
            this.panel1.Controls.Add(this.btn_Github);
            this.panel1.Controls.Add(this.btn_Graphic);
            this.panel1.Controls.Add(this.btn_Result);
            this.panel1.Controls.Add(this.btn_Analyze);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 548);
            this.panel1.TabIndex = 0;
            // 
            // pnl_Nav
            // 
            this.pnl_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnl_Nav.Location = new System.Drawing.Point(3, 198);
            this.pnl_Nav.Name = "pnl_Nav";
            this.pnl_Nav.Size = new System.Drawing.Size(3, 94);
            this.pnl_Nav.TabIndex = 1;
            // 
            // btn_Github
            // 
            this.btn_Github.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Github.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Github.FlatAppearance.BorderSize = 0;
            this.btn_Github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Github.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Github.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Github.Image = global::Text_Helper.Properties.Resources.github;
            this.btn_Github.Location = new System.Drawing.Point(0, 471);
            this.btn_Github.Name = "btn_Github";
            this.btn_Github.Size = new System.Drawing.Size(186, 77);
            this.btn_Github.TabIndex = 1;
            this.btn_Github.Text = "Github";
            this.btn_Github.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Github.UseVisualStyleBackColor = true;
            this.btn_Github.Click += new System.EventHandler(this.btn_Github_Click);
            this.btn_Github.Leave += new System.EventHandler(this.btn_Github_Leave);
            // 
            // btn_Graphic
            // 
            this.btn_Graphic.AutoSize = true;
            this.btn_Graphic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Graphic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Graphic.FlatAppearance.BorderSize = 0;
            this.btn_Graphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Graphic.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Graphic.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Graphic.Image = global::Text_Helper.Properties.Resources.graphic;
            this.btn_Graphic.Location = new System.Drawing.Point(0, 284);
            this.btn_Graphic.Name = "btn_Graphic";
            this.btn_Graphic.Size = new System.Drawing.Size(186, 70);
            this.btn_Graphic.TabIndex = 1;
            this.btn_Graphic.Text = "Graphic";
            this.btn_Graphic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Graphic.UseVisualStyleBackColor = true;
            this.btn_Graphic.Click += new System.EventHandler(this.btn_Graphic_Click);
            this.btn_Graphic.Leave += new System.EventHandler(this.btn_Graphic_Leave);
            // 
            // btn_Result
            // 
            this.btn_Result.AutoSize = true;
            this.btn_Result.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Result.FlatAppearance.BorderSize = 0;
            this.btn_Result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Result.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Result.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Result.Image = global::Text_Helper.Properties.Resources.result;
            this.btn_Result.Location = new System.Drawing.Point(0, 214);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(186, 70);
            this.btn_Result.TabIndex = 1;
            this.btn_Result.Text = "Result";
            this.btn_Result.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Result.UseVisualStyleBackColor = true;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            this.btn_Result.Leave += new System.EventHandler(this.btn_Result_Leave);
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.AutoSize = true;
            this.btn_Analyze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Analyze.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Analyze.FlatAppearance.BorderSize = 0;
            this.btn_Analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Analyze.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Analyze.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Analyze.Image = ((System.Drawing.Image)(resources.GetObject("btn_Analyze.Image")));
            this.btn_Analyze.Location = new System.Drawing.Point(0, 144);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(186, 70);
            this.btn_Analyze.TabIndex = 1;
            this.btn_Analyze.Text = "Analyze";
            this.btn_Analyze.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            this.btn_Analyze.Leave += new System.EventHandler(this.btn_Analyze_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Helper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Text_Helper.Properties.Resources.text_w;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_TitleBar
            // 
            this.pnl_TitleBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_TitleBar.Controls.Add(this.noSelectButton3);
            this.pnl_TitleBar.Controls.Add(this.noSelectButton2);
            this.pnl_TitleBar.Controls.Add(this.noSelectButton1);
            this.pnl_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TitleBar.Location = new System.Drawing.Point(2, 2);
            this.pnl_TitleBar.Name = "pnl_TitleBar";
            this.pnl_TitleBar.Size = new System.Drawing.Size(973, 25);
            this.pnl_TitleBar.TabIndex = 0;
            this.pnl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseDown);
            // 
            // noSelectButton3
            // 
            this.noSelectButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noSelectButton3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.noSelectButton3.BackgroundImage = global::Text_Helper.Properties.Resources.minimize;
            this.noSelectButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noSelectButton3.FlatAppearance.BorderSize = 0;
            this.noSelectButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noSelectButton3.Image = ((System.Drawing.Image)(resources.GetObject("noSelectButton3.Image")));
            this.noSelectButton3.Location = new System.Drawing.Point(898, 0);
            this.noSelectButton3.Name = "noSelectButton3";
            this.noSelectButton3.Size = new System.Drawing.Size(25, 25);
            this.noSelectButton3.TabIndex = 0;
            this.noSelectButton3.UseVisualStyleBackColor = false;
            this.noSelectButton3.Click += new System.EventHandler(this.btnNoS_Minimize_Click);
            // 
            // noSelectButton2
            // 
            this.noSelectButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noSelectButton2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.noSelectButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noSelectButton2.BackgroundImage")));
            this.noSelectButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noSelectButton2.FlatAppearance.BorderSize = 0;
            this.noSelectButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noSelectButton2.Image = ((System.Drawing.Image)(resources.GetObject("noSelectButton2.Image")));
            this.noSelectButton2.Location = new System.Drawing.Point(923, 0);
            this.noSelectButton2.Name = "noSelectButton2";
            this.noSelectButton2.Size = new System.Drawing.Size(25, 25);
            this.noSelectButton2.TabIndex = 0;
            this.noSelectButton2.UseVisualStyleBackColor = false;
            this.noSelectButton2.Click += new System.EventHandler(this.btnNoS_Maximize_Click);
            // 
            // noSelectButton1
            // 
            this.noSelectButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noSelectButton1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.noSelectButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noSelectButton1.BackgroundImage")));
            this.noSelectButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noSelectButton1.FlatAppearance.BorderSize = 0;
            this.noSelectButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noSelectButton1.Location = new System.Drawing.Point(946, 0);
            this.noSelectButton1.Name = "noSelectButton1";
            this.noSelectButton1.Size = new System.Drawing.Size(25, 25);
            this.noSelectButton1.TabIndex = 0;
            this.noSelectButton1.UseVisualStyleBackColor = false;
            this.noSelectButton1.Click += new System.EventHandler(this.btnNoS_Quit_Click);
            // 
            // pnl_FormLoader
            // 
            this.pnl_FormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_FormLoader.Location = new System.Drawing.Point(188, 27);
            this.pnl_FormLoader.Name = "pnl_FormLoader";
            this.pnl_FormLoader.Size = new System.Drawing.Size(787, 548);
            this.pnl_FormLoader.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(977, 577);
            this.Controls.Add(this.pnl_FormLoader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(951, 577);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    }

}
