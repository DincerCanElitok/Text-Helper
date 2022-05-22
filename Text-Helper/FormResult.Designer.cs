
namespace Text_Helper
{
    partial class FormResult
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
            this.lbl_Result_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.result_Label_info = new System.Windows.Forms.Label();
            this.resultBtn_calculate = new Text_Helper.NoSelectButton();
            this.result_dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Result_title
            // 
            this.lbl_Result_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Result_title.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Result_title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Result_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Result_title.Name = "lbl_Result_title";
            this.lbl_Result_title.Size = new System.Drawing.Size(721, 62);
            this.lbl_Result_title.TabIndex = 0;
            this.lbl_Result_title.Text = "Result";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.result_Label_info);
            this.panel1.Controls.Add(this.resultBtn_calculate);
            this.panel1.Controls.Add(this.result_dataGrid);
            this.panel1.Controls.Add(this.lbl_Result_title);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 460);
            this.panel1.TabIndex = 2;
            // 
            // result_Label_info
            // 
            this.result_Label_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result_Label_info.AutoSize = true;
            this.result_Label_info.ForeColor = System.Drawing.SystemColors.Control;
            this.result_Label_info.Location = new System.Drawing.Point(260, 34);
            this.result_Label_info.Name = "result_Label_info";
            this.result_Label_info.Size = new System.Drawing.Size(228, 20);
            this.result_Label_info.TabIndex = 3;
            this.result_Label_info.Text = "Press \"calculate\" for process data";
            // 
            // resultBtn_calculate
            // 
            this.resultBtn_calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBtn_calculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resultBtn_calculate.FlatAppearance.BorderSize = 2;
            this.resultBtn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultBtn_calculate.ForeColor = System.Drawing.SystemColors.Control;
            this.resultBtn_calculate.Location = new System.Drawing.Point(517, 4);
            this.resultBtn_calculate.Name = "resultBtn_calculate";
            this.resultBtn_calculate.Size = new System.Drawing.Size(198, 52);
            this.resultBtn_calculate.TabIndex = 2;
            this.resultBtn_calculate.Text = "Calculate";
            this.resultBtn_calculate.UseVisualStyleBackColor = true;
            this.resultBtn_calculate.Click += new System.EventHandler(this.resultBtn_calculate_Click);
            // 
            // result_dataGrid
            // 
            this.result_dataGrid.AllowUserToAddRows = false;
            this.result_dataGrid.AllowUserToDeleteRows = false;
            this.result_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_dataGrid.Location = new System.Drawing.Point(0, 62);
            this.result_dataGrid.Name = "result_dataGrid";
            this.result_dataGrid.ReadOnly = true;
            this.result_dataGrid.RowHeadersWidth = 51;
            this.result_dataGrid.RowTemplate.Height = 29;
            this.result_dataGrid.Size = new System.Drawing.Size(721, 398);
            this.result_dataGrid.TabIndex = 1;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResult";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Result_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView result_dataGrid;
        private NoSelectButton resultBtn_calculate;
        private System.Windows.Forms.Label result_Label_info;
    }
}