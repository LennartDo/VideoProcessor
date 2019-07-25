namespace VideoProcessor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputDir = new System.Windows.Forms.TextBox();
            this.btInputDirDialog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.btOutputDirDialog = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Directory:";
            // 
            // tbInputDir
            // 
            this.tbInputDir.Location = new System.Drawing.Point(28, 47);
            this.tbInputDir.Name = "tbInputDir";
            this.tbInputDir.Size = new System.Drawing.Size(240, 20);
            this.tbInputDir.TabIndex = 1;
            // 
            // btInputDirDialog
            // 
            this.btInputDirDialog.Location = new System.Drawing.Point(274, 47);
            this.btInputDirDialog.Name = "btInputDirDialog";
            this.btInputDirDialog.Size = new System.Drawing.Size(27, 20);
            this.btInputDirDialog.TabIndex = 2;
            this.btInputDirDialog.Text = "...";
            this.btInputDirDialog.UseVisualStyleBackColor = true;
            this.btInputDirDialog.Click += new System.EventHandler(this.btInputDirDialog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory:";
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.Location = new System.Drawing.Point(28, 107);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(240, 20);
            this.tbOutputDir.TabIndex = 4;
            // 
            // btOutputDirDialog
            // 
            this.btOutputDirDialog.Location = new System.Drawing.Point(274, 107);
            this.btOutputDirDialog.Name = "btOutputDirDialog";
            this.btOutputDirDialog.Size = new System.Drawing.Size(27, 20);
            this.btOutputDirDialog.TabIndex = 5;
            this.btOutputDirDialog.Text = "...";
            this.btOutputDirDialog.UseVisualStyleBackColor = true;
            this.btOutputDirDialog.Click += new System.EventHandler(this.btOutputDirDialog_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(26, 155);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(275, 23);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Process Folder";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 200);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btOutputDirDialog);
            this.Controls.Add(this.tbOutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btInputDirDialog);
            this.Controls.Add(this.tbInputDir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Video Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputDir;
        private System.Windows.Forms.Button btInputDirDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.Button btOutputDirDialog;
        private System.Windows.Forms.Button btStart;
    }
}

