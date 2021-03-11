
namespace Vizualizacao_Supervisorio
{
    partial class frmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
            this.txtLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.imgPrevisio = new System.Windows.Forms.PictureBox();
            this.imgDana = new System.Windows.Forms.PictureBox();
            this.campoLogin = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevisio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDana)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Location = new System.Drawing.Point(51, 106);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(37, 15);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Location = new System.Drawing.Point(49, 162);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(39, 15);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            // 
            // imgPrevisio
            // 
            this.imgPrevisio.Image = global::Sistema_Supervisorio.Properties.Resources.VERSÃO_PREFERENCIAL___AZUL;
            this.imgPrevisio.Location = new System.Drawing.Point(51, 21);
            this.imgPrevisio.Name = "imgPrevisio";
            this.imgPrevisio.Size = new System.Drawing.Size(190, 58);
            this.imgPrevisio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPrevisio.TabIndex = 4;
            this.imgPrevisio.TabStop = false;
            // 
            // imgDana
            // 
            this.imgDana.Image = ((System.Drawing.Image)(resources.GetObject("imgDana.Image")));
            this.imgDana.Location = new System.Drawing.Point(261, 21);
            this.imgDana.Name = "imgDana";
            this.imgDana.Size = new System.Drawing.Size(95, 58);
            this.imgDana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDana.TabIndex = 5;
            this.imgDana.TabStop = false;
            // 
            // campoLogin
            // 
            this.campoLogin.Location = new System.Drawing.Point(123, 103);
            this.campoLogin.Name = "campoLogin";
            this.campoLogin.Size = new System.Drawing.Size(233, 23);
            this.campoLogin.TabIndex = 2;
            // 
            // campoSenha
            // 
            this.campoSenha.Location = new System.Drawing.Point(123, 154);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(233, 23);
            this.campoSenha.TabIndex = 6;
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 217);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.imgDana);
            this.Controls.Add(this.imgPrevisio);
            this.Controls.Add(this.campoLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmEntrada";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevisio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.PictureBox imgPrevisio;
        private System.Windows.Forms.PictureBox imgDana;
        private System.Windows.Forms.TextBox campoLogin;
        private System.Windows.Forms.TextBox campoSenha;
    }
}

