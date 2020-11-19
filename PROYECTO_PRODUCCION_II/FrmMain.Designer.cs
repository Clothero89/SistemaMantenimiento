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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMantPred
            // 
            this.btnMantPred.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMantPred.FlatAppearance.BorderSize = 0;
            this.btnMantPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnMantPred.Location = new System.Drawing.Point(0, 168);
            this.btnMantPred.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantPred.Name = "btnMantPred";
            this.btnMantPred.Size = new System.Drawing.Size(200, 100);
            this.btnMantPred.TabIndex = 1;
            this.btnMantPred.Text = "Mantenimiento Predictivo";
            this.btnMantPred.UseVisualStyleBackColor = true;
            this.btnMantPred.Click += new System.EventHandler(this.btnMantPred_Click);
            // 
            // btnMantCorre
            // 
            this.btnMantCorre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMantCorre.FlatAppearance.BorderSize = 0;
            this.btnMantCorre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantCorre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantCorre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnMantCorre.Location = new System.Drawing.Point(2, 272);
            this.btnMantCorre.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantCorre.Name = "btnMantCorre";
            this.btnMantCorre.Size = new System.Drawing.Size(200, 100);
            this.btnMantCorre.TabIndex = 2;
            this.btnMantCorre.Text = "Matenimiento Correctivo";
            this.btnMantCorre.UseVisualStyleBackColor = true;
            this.btnMantCorre.Click += new System.EventHandler(this.btnMantCorre_Click);
            // 
            // btnOrdenMant
            // 
            this.btnOrdenMant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOrdenMant.FlatAppearance.BorderSize = 0;
            this.btnOrdenMant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenMant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnOrdenMant.Location = new System.Drawing.Point(0, 376);
            this.btnOrdenMant.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenMant.Name = "btnOrdenMant";
            this.btnOrdenMant.Size = new System.Drawing.Size(200, 100);
            this.btnOrdenMant.TabIndex = 3;
            this.btnOrdenMant.Text = "Ordenes de Mantenimiento";
            this.btnOrdenMant.UseVisualStyleBackColor = true;
            this.btnOrdenMant.Click += new System.EventHandler(this.btnOrdenMant_Click);
            // 
            // btnMantPrev
            // 
            this.btnMantPrev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMantPrev.FlatAppearance.BorderSize = 0;
            this.btnMantPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnMantPrev.Location = new System.Drawing.Point(0, 64);
            this.btnMantPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnMantPrev.Name = "btnMantPrev";
            this.btnMantPrev.Size = new System.Drawing.Size(200, 100);
            this.btnMantPrev.TabIndex = 0;
            this.btnMantPrev.Text = "Mantenimiento Preventivo";
            this.btnMantPrev.UseVisualStyleBackColor = true;
            this.btnMantPrev.Click += new System.EventHandler(this.btnMantPrev_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMantPrev);
            this.panel1.Controls.Add(this.btnOrdenMant);
            this.panel1.Controls.Add(this.btnMantPred);
            this.panel1.Controls.Add(this.btnMantCorre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 627);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(0, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir del sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 627);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrdenMant;
        private System.Windows.Forms.Button btnMantCorre;
        private System.Windows.Forms.Button btnMantPred;
        private System.Windows.Forms.Button btnMantPrev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}