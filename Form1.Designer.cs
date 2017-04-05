namespace ShutdownTimer
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
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Location = new System.Drawing.Point(12, 100);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(100, 100);
            this.buttonShutdown.TabIndex = 0;
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(172, 100);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(100, 100);
            this.buttonAbort.TabIndex = 1;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.comboBox.Location = new System.Drawing.Point(50, 50);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(200, 21);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(93, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(114, 20);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Time in minutes:";
            this.labelHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonShutdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shutdown Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelHeader;
    }
}

