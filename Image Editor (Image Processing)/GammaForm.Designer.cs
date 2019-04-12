namespace Image_Editor
{
    partial class GammaForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redGamma = new System.Windows.Forms.TrackBar();
            this.greenGamma = new System.Windows.Forms.TrackBar();
            this.blueGamma = new System.Windows.Forms.TrackBar();
            this.redVal = new System.Windows.Forms.Label();
            this.greenVal = new System.Windows.Forms.Label();
            this.blueVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(86, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue";
            // 
            // redGamma
            // 
            this.redGamma.Location = new System.Drawing.Point(77, 29);
            this.redGamma.Maximum = 5;
            this.redGamma.Name = "redGamma";
            this.redGamma.Size = new System.Drawing.Size(104, 45);
            this.redGamma.TabIndex = 7;
            this.redGamma.Scroll += new System.EventHandler(this.redGamma_Scroll);
            // 
            // greenGamma
            // 
            this.greenGamma.Location = new System.Drawing.Point(77, 74);
            this.greenGamma.Maximum = 5;
            this.greenGamma.Name = "greenGamma";
            this.greenGamma.Size = new System.Drawing.Size(104, 45);
            this.greenGamma.TabIndex = 8;
            this.greenGamma.Scroll += new System.EventHandler(this.greenGamma_Scroll);
            // 
            // blueGamma
            // 
            this.blueGamma.Location = new System.Drawing.Point(77, 117);
            this.blueGamma.Maximum = 5;
            this.blueGamma.Name = "blueGamma";
            this.blueGamma.Size = new System.Drawing.Size(104, 45);
            this.blueGamma.TabIndex = 9;
            this.blueGamma.Scroll += new System.EventHandler(this.blueGamma_Scroll);
            // 
            // redVal
            // 
            this.redVal.AutoSize = true;
            this.redVal.Location = new System.Drawing.Point(187, 29);
            this.redVal.Name = "redVal";
            this.redVal.Size = new System.Drawing.Size(13, 13);
            this.redVal.TabIndex = 10;
            this.redVal.Text = "0";
            // 
            // greenVal
            // 
            this.greenVal.AutoSize = true;
            this.greenVal.Location = new System.Drawing.Point(187, 74);
            this.greenVal.Name = "greenVal";
            this.greenVal.Size = new System.Drawing.Size(13, 13);
            this.greenVal.TabIndex = 11;
            this.greenVal.Text = "0";
            // 
            // blueVal
            // 
            this.blueVal.AutoSize = true;
            this.blueVal.Location = new System.Drawing.Point(187, 117);
            this.blueVal.Name = "blueVal";
            this.blueVal.Size = new System.Drawing.Size(13, 13);
            this.blueVal.TabIndex = 12;
            this.blueVal.Text = "0";
            // 
            // GammaForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 198);
            this.Controls.Add(this.blueVal);
            this.Controls.Add(this.greenVal);
            this.Controls.Add(this.redVal);
            this.Controls.Add(this.blueGamma);
            this.Controls.Add(this.greenGamma);
            this.Controls.Add(this.redGamma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GammaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GammaForm";
            ((System.ComponentModel.ISupportInitialize)(this.redGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar redGamma;
        private System.Windows.Forms.TrackBar greenGamma;
        private System.Windows.Forms.TrackBar blueGamma;
        private System.Windows.Forms.Label redVal;
        private System.Windows.Forms.Label greenVal;
        private System.Windows.Forms.Label blueVal;
    }
}