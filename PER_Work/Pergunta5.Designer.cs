namespace PER_Work
{
    partial class Pergunta5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta5));
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.Perg = new System.Windows.Forms.Label();
            this.Conf = new System.Windows.Forms.Button();
            this.nivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB1.Location = new System.Drawing.Point(27, 65);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(95, 19);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "radioButton1";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB2.Location = new System.Drawing.Point(27, 109);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(95, 19);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "radioButton2";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB3.Location = new System.Drawing.Point(27, 153);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(95, 19);
            this.RB3.TabIndex = 2;
            this.RB3.TabStop = true;
            this.RB3.Text = "radioButton3";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB4.Location = new System.Drawing.Point(27, 196);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(95, 19);
            this.RB4.TabIndex = 3;
            this.RB4.TabStop = true;
            this.RB4.Text = "radioButton4";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // Perg
            // 
            this.Perg.AutoSize = true;
            this.Perg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perg.Location = new System.Drawing.Point(56, 9);
            this.Perg.Name = "Perg";
            this.Perg.Size = new System.Drawing.Size(171, 20);
            this.Perg.TabIndex = 4;
            this.Perg.Text = "Qual a capital da Síria?";
            // 
            // Conf
            // 
            this.Conf.Location = new System.Drawing.Point(155, 233);
            this.Conf.Name = "Conf";
            this.Conf.Size = new System.Drawing.Size(124, 23);
            this.Conf.TabIndex = 5;
            this.Conf.Text = "Confirmar";
            this.Conf.UseVisualStyleBackColor = true;
            this.Conf.Click += new System.EventHandler(this.Conf_Click);
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Location = new System.Drawing.Point(27, 242);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(30, 13);
            this.nivel.TabIndex = 6;
            this.nivel.Text = "Hard";
            // 
            // Pergunta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 268);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.Conf);
            this.Controls.Add(this.Perg);
            this.Controls.Add(this.RB4);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pergunta5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.Label Perg;
        private System.Windows.Forms.Button Conf;
        private System.Windows.Forms.Label nivel;
    }
}