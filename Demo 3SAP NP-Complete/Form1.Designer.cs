namespace Demo_3SAP_NP_Complete {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.button1 = new System.Windows.Forms.Button();
            this.txOutput = new System.Windows.Forms.TextBox();
            this.cbProblem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txOutput
            // 
            this.txOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txOutput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txOutput.Location = new System.Drawing.Point(16, 50);
            this.txOutput.Multiline = true;
            this.txOutput.Name = "txOutput";
            this.txOutput.ReadOnly = true;
            this.txOutput.Size = new System.Drawing.Size(931, 399);
            this.txOutput.TabIndex = 1;
            // 
            // cbProblem
            // 
            this.cbProblem.FormattingEnabled = true;
            this.cbProblem.Items.AddRange(new object[] {
            "Problem size 1",
            "Problem size 2",
            "Problem size 3",
            "Problem size 4"});
            this.cbProblem.Location = new System.Drawing.Point(16, 13);
            this.cbProblem.Name = "cbProblem";
            this.cbProblem.Size = new System.Drawing.Size(217, 21);
            this.cbProblem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.cbProblem);
            this.Controls.Add(this.txOutput);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txOutput;
        private System.Windows.Forms.ComboBox cbProblem;
    }
}

