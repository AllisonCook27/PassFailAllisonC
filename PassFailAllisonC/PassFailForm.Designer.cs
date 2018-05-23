namespace PassFailAllisonC
{
    partial class PassFailForm
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
            this.btnParseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParseFile
            // 
            this.btnParseFile.Font = new System.Drawing.Font("Dutch801 XBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseFile.Location = new System.Drawing.Point(83, 92);
            this.btnParseFile.Name = "btnParseFile";
            this.btnParseFile.Size = new System.Drawing.Size(100, 36);
            this.btnParseFile.TabIndex = 0;
            this.btnParseFile.Text = "Parse File";
            this.btnParseFile.UseVisualStyleBackColor = true;
            this.btnParseFile.Click += new System.EventHandler(this.btnParseFile_Click);
            // 
            // PassFailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnParseFile);
            this.Name = "PassFailForm";
            this.Text = "Pass Fail by Allison C";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParseFile;
    }
}

