namespace PROYECTO_PRODUCCION_II
{
    partial class FrmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelButtom = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnAcced = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelButtom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtom
            // 
            this.panelButtom.Controls.Add(this.txtPass);
            this.panelButtom.Controls.Add(this.txtUser);
            this.panelButtom.Controls.Add(this.btnAcced);
            this.panelButtom.Controls.Add(this.panel2);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtom.Location = new System.Drawing.Point(0, 0);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(447, 630);
            this.panelButtom.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(82, 432);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(285, 34);
            this.txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(82, 385);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(285, 34);
            this.txtUser.TabIndex = 2;
            // 
            // btnAcced
            // 
            this.btnAcced.Location = new System.Drawing.Point(82, 486);
            this.btnAcced.Name = "btnAcced";
            this.btnAcced.Size = new System.Drawing.Size(285, 44);
            this.btnAcced.TabIndex = 1;
            this.btnAcced.Text = "ACCEDER";
            this.btnAcced.UseVisualStyleBackColor = true;
            this.btnAcced.Click += new System.EventHandler(this.btnAcced_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 293);
            this.panel2.TabIndex = 0;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 630);
            this.Controls.Add(this.panelButtom);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESION";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.panelButtom.ResumeLayout(false);
            this.panelButtom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnAcced;
        private System.Windows.Forms.Panel panel2;
    }
}

