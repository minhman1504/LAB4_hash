
namespace LAB4_hash
{
    partial class Menu
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSHA3 = new System.Windows.Forms.CheckBox();
            this.cbSHA2 = new System.Windows.Forms.CheckBox();
            this.cbSHA1 = new System.Windows.Forms.CheckBox();
            this.cbMD5 = new System.Windows.Forms.CheckBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.panelSHA3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSHA3 = new System.Windows.Forms.TextBox();
            this.panelSHA2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSHA2 = new System.Windows.Forms.TextBox();
            this.panelSHA1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.panelMD5 = new System.Windows.Forms.Panel();
            this.MD5 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panelSHA3.SuspendLayout();
            this.panelSHA2.SuspendLayout();
            this.panelSHA1.SuspendLayout();
            this.panelMD5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(882, 73);
            this.panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(366, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "HashAlgos";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.Transparent;
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.cbSHA3);
            this.panelInput.Controls.Add(this.cbSHA2);
            this.panelInput.Controls.Add(this.cbSHA1);
            this.panelInput.Controls.Add(this.cbMD5);
            this.panelInput.Controls.Add(this.btnHash);
            this.panelInput.Controls.Add(this.btnLoadFile);
            this.panelInput.Controls.Add(this.txtInput);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.cbFormat);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 73);
            this.panelInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(882, 313);
            this.panelInput.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(171, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Algorithm";
            // 
            // cbSHA3
            // 
            this.cbSHA3.AutoSize = true;
            this.cbSHA3.Location = new System.Drawing.Point(269, 270);
            this.cbSHA3.Name = "cbSHA3";
            this.cbSHA3.Size = new System.Drawing.Size(97, 27);
            this.cbSHA3.TabIndex = 12;
            this.cbSHA3.Text = "SHA-384";
            this.cbSHA3.UseVisualStyleBackColor = true;
            // 
            // cbSHA2
            // 
            this.cbSHA2.AutoSize = true;
            this.cbSHA2.Location = new System.Drawing.Point(269, 239);
            this.cbSHA2.Name = "cbSHA2";
            this.cbSHA2.Size = new System.Drawing.Size(97, 27);
            this.cbSHA2.TabIndex = 12;
            this.cbSHA2.Text = "SHA-256";
            this.cbSHA2.UseVisualStyleBackColor = true;
            // 
            // cbSHA1
            // 
            this.cbSHA1.AutoSize = true;
            this.cbSHA1.Location = new System.Drawing.Point(269, 211);
            this.cbSHA1.Name = "cbSHA1";
            this.cbSHA1.Size = new System.Drawing.Size(76, 27);
            this.cbSHA1.TabIndex = 12;
            this.cbSHA1.Text = "SHA-1";
            this.cbSHA1.UseVisualStyleBackColor = true;
            // 
            // cbMD5
            // 
            this.cbMD5.AutoSize = true;
            this.cbMD5.Location = new System.Drawing.Point(269, 178);
            this.cbMD5.Name = "cbMD5";
            this.cbMD5.Size = new System.Drawing.Size(66, 27);
            this.cbMD5.TabIndex = 11;
            this.cbMD5.Text = "MD5";
            this.cbMD5.UseVisualStyleBackColor = true;
            // 
            // btnHash
            // 
            this.btnHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHash.BackColor = System.Drawing.Color.White;
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHash.Location = new System.Drawing.Point(437, 203);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(311, 71);
            this.btnHash.TabIndex = 12;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = false;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFile.BackColor = System.Drawing.Color.White;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadFile.Location = new System.Drawing.Point(711, 23);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(106, 33);
            this.btnLoadFile.TabIndex = 6;
            this.btnLoadFile.Text = "SelectFile";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.ForeColor = System.Drawing.SystemColors.Info;
            this.txtInput.Location = new System.Drawing.Point(156, 80);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(660, 90);
            this.txtInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(48, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Input Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Format";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFormat.ForeColor = System.Drawing.SystemColors.Info;
            this.cbFormat.Items.AddRange(new object[] {
            "Normal String",
            "Hex String",
            "Binary File"});
            this.cbFormat.Location = new System.Drawing.Point(155, 23);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(190, 31);
            this.cbFormat.TabIndex = 2;
            this.cbFormat.SelectedValueChanged += new System.EventHandler(this.cbFormat_SelectedValueChanged);
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.Color.Transparent;
            this.panelOutput.Controls.Add(this.panelSHA3);
            this.panelOutput.Controls.Add(this.panelSHA2);
            this.panelOutput.Controls.Add(this.panelSHA1);
            this.panelOutput.Controls.Add(this.panelMD5);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(0, 386);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(882, 317);
            this.panelOutput.TabIndex = 3;
            this.panelOutput.Visible = false;
            // 
            // panelSHA3
            // 
            this.panelSHA3.Controls.Add(this.label6);
            this.panelSHA3.Controls.Add(this.txtSHA3);
            this.panelSHA3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSHA3.Location = new System.Drawing.Point(0, 240);
            this.panelSHA3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSHA3.Name = "panelSHA3";
            this.panelSHA3.Size = new System.Drawing.Size(882, 80);
            this.panelSHA3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "SHA-384";
            // 
            // txtSHA3
            // 
            this.txtSHA3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txtSHA3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSHA3.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSHA3.Location = new System.Drawing.Point(156, 0);
            this.txtSHA3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSHA3.Multiline = true;
            this.txtSHA3.Name = "txtSHA3";
            this.txtSHA3.Size = new System.Drawing.Size(660, 60);
            this.txtSHA3.TabIndex = 6;
            // 
            // panelSHA2
            // 
            this.panelSHA2.Controls.Add(this.label3);
            this.panelSHA2.Controls.Add(this.txtSHA2);
            this.panelSHA2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSHA2.Location = new System.Drawing.Point(0, 160);
            this.panelSHA2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSHA2.Name = "panelSHA2";
            this.panelSHA2.Size = new System.Drawing.Size(882, 80);
            this.panelSHA2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "SHA-256";
            // 
            // txtSHA2
            // 
            this.txtSHA2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txtSHA2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSHA2.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSHA2.Location = new System.Drawing.Point(156, 0);
            this.txtSHA2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSHA2.Multiline = true;
            this.txtSHA2.Name = "txtSHA2";
            this.txtSHA2.Size = new System.Drawing.Size(660, 60);
            this.txtSHA2.TabIndex = 6;
            // 
            // panelSHA1
            // 
            this.panelSHA1.Controls.Add(this.label2);
            this.panelSHA1.Controls.Add(this.txtSHA1);
            this.panelSHA1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSHA1.Location = new System.Drawing.Point(0, 80);
            this.panelSHA1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSHA1.Name = "panelSHA1";
            this.panelSHA1.Size = new System.Drawing.Size(882, 80);
            this.panelSHA1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "SHA-1";
            // 
            // txtSHA1
            // 
            this.txtSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSHA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txtSHA1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSHA1.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSHA1.Location = new System.Drawing.Point(156, 0);
            this.txtSHA1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSHA1.Multiline = true;
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(660, 60);
            this.txtSHA1.TabIndex = 6;
            // 
            // panelMD5
            // 
            this.panelMD5.BackColor = System.Drawing.Color.Transparent;
            this.panelMD5.Controls.Add(this.MD5);
            this.panelMD5.Controls.Add(this.txtMD5);
            this.panelMD5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMD5.Location = new System.Drawing.Point(0, 0);
            this.panelMD5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelMD5.Name = "panelMD5";
            this.panelMD5.Size = new System.Drawing.Size(882, 80);
            this.panelMD5.TabIndex = 3;
            // 
            // MD5
            // 
            this.MD5.AutoSize = true;
            this.MD5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MD5.Location = new System.Drawing.Point(88, 20);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(47, 23);
            this.MD5.TabIndex = 7;
            this.MD5.Text = "MD5";
            // 
            // txtMD5
            // 
            this.txtMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.txtMD5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMD5.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMD5.Location = new System.Drawing.Point(156, 0);
            this.txtMD5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMD5.Multiline = true;
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(660, 60);
            this.txtMD5.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(882, 703);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(900, 750);
            this.Name = "Menu";
            this.Text = "HashAlgos";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelSHA3.ResumeLayout(false);
            this.panelSHA3.PerformLayout();
            this.panelSHA2.ResumeLayout(false);
            this.panelSHA2.PerformLayout();
            this.panelSHA1.ResumeLayout(false);
            this.panelSHA1.PerformLayout();
            this.panelMD5.ResumeLayout(false);
            this.panelMD5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSHA3;
        private System.Windows.Forms.Panel panelSHA2;
        private System.Windows.Forms.Panel panelSHA1;
        private System.Windows.Forms.Panel panelMD5;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.TextBox txtSHA3;
        private System.Windows.Forms.TextBox txtSHA2;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.CheckBox cbMD5;
        private System.Windows.Forms.CheckBox cbSHA3;
        private System.Windows.Forms.CheckBox cbSHA2;
        private System.Windows.Forms.CheckBox cbSHA1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MD5;
        private System.Windows.Forms.Label label7;
    }
}

