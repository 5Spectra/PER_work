namespace PER_Work
{
    partial class FinalTel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalTel));
            this.Try = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.Ponta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfina = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Try
            // 
            this.Try.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Try.Location = new System.Drawing.Point(224, 264);
            this.Try.Name = "Try";
            this.Try.Size = new System.Drawing.Size(133, 34);
            this.Try.TabIndex = 0;
            this.Try.Text = "Tentar novamente";
            this.Try.UseVisualStyleBackColor = true;
            this.Try.Click += new System.EventHandler(this.Try_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(31, 264);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(100, 34);
            this.sair.TabIndex = 1;
            this.sair.Text = "Encerrar";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Ponta
            // 
            this.Ponta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ponta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ponta.Location = new System.Drawing.Point(138, 116);
            this.Ponta.Name = "Ponta";
            this.Ponta.Size = new System.Drawing.Size(94, 61);
            this.Ponta.TabIndex = 2;
            this.Ponta.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sua pontuação foi:";
            // 
            // txtfina
            // 
            this.txtfina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfina.Location = new System.Drawing.Point(54, 9);
            this.txtfina.Name = "txtfina";
            this.txtfina.Size = new System.Drawing.Size(271, 38);
            this.txtfina.TabIndex = 4;
            this.txtfina.Text = "label2";
            this.txtfina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PER_Work.Properties.Resources._03d2c1238354a57477acb4eae97bc4f0;
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PER_Work.Properties.Resources._03d2c1238354a57477acb4eae97bc4f0;
            this.pictureBox2.Location = new System.Drawing.Point(252, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FinalTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 327);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ponta);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Try);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalTel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalTel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Try;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Label Ponta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtfina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}