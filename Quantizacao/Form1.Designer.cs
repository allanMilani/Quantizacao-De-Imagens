
namespace Quantizacao
{
    partial class Form1
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
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub4 = new System.Windows.Forms.Button();
            this.btnSub8 = new System.Windows.Forms.Button();
            this.btnSub16 = new System.Windows.Forms.Button();
            this.btnSub32 = new System.Windows.Forms.Button();
            this.btnSub64 = new System.Windows.Forms.Button();
            this.btnSub128 = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnSub256 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(20, 453);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(92, 36);
            this.btnSub2.TabIndex = 0;
            this.btnSub2.Text = "Subdivisão 2";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSub4
            // 
            this.btnSub4.Location = new System.Drawing.Point(133, 453);
            this.btnSub4.Name = "btnSub4";
            this.btnSub4.Size = new System.Drawing.Size(92, 36);
            this.btnSub4.TabIndex = 1;
            this.btnSub4.Text = "Subdivisão 4";
            this.btnSub4.UseVisualStyleBackColor = true;
            this.btnSub4.Click += new System.EventHandler(this.btnSub4_Click);
            // 
            // btnSub8
            // 
            this.btnSub8.Location = new System.Drawing.Point(245, 453);
            this.btnSub8.Name = "btnSub8";
            this.btnSub8.Size = new System.Drawing.Size(96, 36);
            this.btnSub8.TabIndex = 2;
            this.btnSub8.Text = "Subdivisão 8";
            this.btnSub8.UseVisualStyleBackColor = true;
            this.btnSub8.Click += new System.EventHandler(this.btnSub8_Click);
            // 
            // btnSub16
            // 
            this.btnSub16.Location = new System.Drawing.Point(356, 453);
            this.btnSub16.Name = "btnSub16";
            this.btnSub16.Size = new System.Drawing.Size(96, 36);
            this.btnSub16.TabIndex = 3;
            this.btnSub16.Text = "Subdivisão 16";
            this.btnSub16.UseVisualStyleBackColor = true;
            this.btnSub16.Click += new System.EventHandler(this.btnSub16_Click);
            // 
            // btnSub32
            // 
            this.btnSub32.Location = new System.Drawing.Point(20, 513);
            this.btnSub32.Name = "btnSub32";
            this.btnSub32.Size = new System.Drawing.Size(92, 36);
            this.btnSub32.TabIndex = 4;
            this.btnSub32.Text = "Subdivisão 32";
            this.btnSub32.UseVisualStyleBackColor = true;
            this.btnSub32.Click += new System.EventHandler(this.btnSub32_Click);
            // 
            // btnSub64
            // 
            this.btnSub64.Location = new System.Drawing.Point(133, 513);
            this.btnSub64.Name = "btnSub64";
            this.btnSub64.Size = new System.Drawing.Size(92, 36);
            this.btnSub64.TabIndex = 5;
            this.btnSub64.Text = "Subdivisão 64";
            this.btnSub64.UseVisualStyleBackColor = true;
            this.btnSub64.Click += new System.EventHandler(this.btnSub64_Click);
            // 
            // btnSub128
            // 
            this.btnSub128.Location = new System.Drawing.Point(245, 513);
            this.btnSub128.Name = "btnSub128";
            this.btnSub128.Size = new System.Drawing.Size(96, 36);
            this.btnSub128.TabIndex = 6;
            this.btnSub128.Text = "Subdivisão 128";
            this.btnSub128.UseVisualStyleBackColor = true;
            this.btnSub128.Click += new System.EventHandler(this.btnSub128_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(20, 12);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(428, 425);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 7;
            this.pbImagem.TabStop = false;
            // 
            // btnSub256
            // 
            this.btnSub256.Location = new System.Drawing.Point(356, 513);
            this.btnSub256.Name = "btnSub256";
            this.btnSub256.Size = new System.Drawing.Size(96, 36);
            this.btnSub256.TabIndex = 8;
            this.btnSub256.Text = "Subdivisão 256";
            this.btnSub256.UseVisualStyleBackColor = true;
            this.btnSub256.Click += new System.EventHandler(this.btnSub256_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 572);
            this.Controls.Add(this.btnSub256);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.btnSub128);
            this.Controls.Add(this.btnSub64);
            this.Controls.Add(this.btnSub32);
            this.Controls.Add(this.btnSub16);
            this.Controls.Add(this.btnSub8);
            this.Controls.Add(this.btnSub4);
            this.Controls.Add(this.btnSub2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnSub4;
        private System.Windows.Forms.Button btnSub8;
        private System.Windows.Forms.Button btnSub16;
        private System.Windows.Forms.Button btnSub32;
        private System.Windows.Forms.Button btnSub64;
        private System.Windows.Forms.Button btnSub128;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnSub256;
    }
}

