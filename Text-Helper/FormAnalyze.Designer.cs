
namespace Text_Helper
{
    partial class FormAnalyze
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
            this.lbl_Analyze_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.analyze_label_process = new System.Windows.Forms.Label();
            this.analyze_button = new Text_Helper.NoSelectButton();
            this.analyze_textbox_keyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.analyze_textbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Analyze_title
            // 
            this.lbl_Analyze_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Analyze_title.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Analyze_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Analyze_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Analyze_title.Name = "lbl_Analyze_title";
            this.lbl_Analyze_title.Size = new System.Drawing.Size(721, 62);
            this.lbl_Analyze_title.TabIndex = 0;
            this.lbl_Analyze_title.Text = "Analyze";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.analyze_label_process);
            this.panel1.Controls.Add(this.analyze_button);
            this.panel1.Controls.Add(this.analyze_textbox_keyword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.analyze_textbox);
            this.panel1.Controls.Add(this.lbl_Analyze_title);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 460);
            this.panel1.TabIndex = 1;
            // 
            // analyze_label_process
            // 
            this.analyze_label_process.AutoSize = true;
            this.analyze_label_process.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.analyze_label_process.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.analyze_label_process.ForeColor = System.Drawing.SystemColors.Control;
            this.analyze_label_process.Location = new System.Drawing.Point(0, 404);
            this.analyze_label_process.Name = "analyze_label_process";
            this.analyze_label_process.Size = new System.Drawing.Size(227, 20);
            this.analyze_label_process.TabIndex = 2;
            this.analyze_label_process.Text = "Press Analyze button for process ";
            // 
            // analyze_button
            // 
            this.analyze_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.analyze_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.analyze_button.FlatAppearance.BorderSize = 2;
            this.analyze_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyze_button.ForeColor = System.Drawing.SystemColors.Control;
            this.analyze_button.Location = new System.Drawing.Point(0, 424);
            this.analyze_button.Name = "analyze_button";
            this.analyze_button.Size = new System.Drawing.Size(721, 36);
            this.analyze_button.TabIndex = 3;
            this.analyze_button.Text = "Analyze";
            this.analyze_button.UseVisualStyleBackColor = true;
            this.analyze_button.Click += new System.EventHandler(this.analyze_button_Click);
            // 
            // analyze_textbox_keyword
            // 
            this.analyze_textbox_keyword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analyze_textbox_keyword.Location = new System.Drawing.Point(347, 83);
            this.analyze_textbox_keyword.Name = "analyze_textbox_keyword";
            this.analyze_textbox_keyword.Size = new System.Drawing.Size(241, 27);
            this.analyze_textbox_keyword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(167, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the keyword:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(95, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Put the text you want it check";
            // 
            // analyze_textbox
            // 
            this.analyze_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analyze_textbox.Location = new System.Drawing.Point(95, 153);
            this.analyze_textbox.Multiline = true;
            this.analyze_textbox.Name = "analyze_textbox";
            this.analyze_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.analyze_textbox.Size = new System.Drawing.Size(493, 232);
            this.analyze_textbox.TabIndex = 1;
            // 
            // FormAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnalyze";
            this.Text = "FormAnalyze";
            this.Load += new System.EventHandler(this.FormAnalyze_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Analyze_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox analyze_textbox_keyword;
        private NoSelectButton analyze_button;
        private System.Windows.Forms.Label analyze_label_process;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox analyze_textbox;
        private System.Windows.Forms.Label label3;
    }
}