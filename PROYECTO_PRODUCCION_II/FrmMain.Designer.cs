namespace PROYECTO_PRODUCCION_II
{
    partial class FrmMain
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
            this.btnMantPred = new System.Windows.Forms.Button();
            this.btnMantCorre = new System.Windows.Forms.Button();
            this.btnOrdenMant = new System.Windows.Forms.Button();
            this.btnMantPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMantPred
            // 
            this.btnMantPred.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMantPred.Location = new System.Drawing.Point(649, 144);
            this.btnMantPred.Name = "btnMantPred";
            this.btnMantPred.Size = new System.Drawing.Size(253, 126);
            this.btnMantPred.TabIndex = 1;
            this.btnMantPred.Text = "Mantenimiento Predictivo";
            this.btnMantPred.UseVisualStyleBackColor = true;
            this.btnMantPred.Click += new System.EventHandler(this.btnMantPred_Click);
            // 
            // btnMantCorre
            // 
            this.btnMantCorre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMantCorre.Location = new System.Drawing.Point(649, 276);
            this.btnMantCorre.Name = "btnMantCorre";
            this.btnMantCorre.Size = new System.Drawing.Size(253, 126);
            this.btnMantCorre.TabIndex = 2;
            this.btnMantCorre.Text = "Matenimiento Correctivo";
            this.btnMantCorre.UseVisualStyleBackColor = true;
            this.btnMantCorre.Click += new System.EventHandler(this.btnMantCorre_Click);
            // 
            // btnOrdenMant
            // 
            this.btnOrdenMant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOrdenMant.Location = new System.Drawing.Point(649, 408);
            this.btnOrdenMant.Name = "btnOrdenMant";
            this.btnOrdenMant.Size = new System.Drawing.Size(253, 126);
            this.btnOrdenMant.TabIndex = 3;
            this.btnOrdenMant.Text = "Ordenes de Mantenimiento";
            this.btnOrdenMant.UseVisualStyleBackColor = true;
            this.btnOrdenMant.Click += new System.EventHandler(this.btnOrdenMant_Click);
            // 
            // btnMantPrev
            // 
            this.btnMantPrev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMantPrev.Location = new System.Drawing.Point(649, 12);
            this.btnMantPrev.Name = "btnMantPrev";
            this.btnMantPrev.Size = new System.Drawing.Size(253, 126);
            this.btnMantPrev.TabIndex = 0;
            this.btnMantPrev.Text = "Mantenimiento Preventivo";
            this.btnMantPrev.UseVisualStyleBackColor = true;
            this.btnMantPrev.Click += new System.EventHandler(this.btnMantPrev_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 550);
            this.Controls.Add(this.btnMantPrev);
            this.Controls.Add(this.btnOrdenMant);
            this.Controls.Add(this.btnMantCorre);
            this.Controls.Add(this.btnMantPred);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrdenMant;
        private System.Windows.Forms.Button btnMantCorre;
        private System.Windows.Forms.Button btnMantPred;
        private System.Windows.Forms.Button btnMantPrev;
    }
}