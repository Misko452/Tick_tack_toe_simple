namespace Piskvorky
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.B3 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piškvorky";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.Location = new System.Drawing.Point(21, 396);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(327, 49);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Hrát";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(115, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hra vypnutá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hráč 1: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(229, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hráč 2: 0";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2.Location = new System.Drawing.Point(21, 451);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(327, 49);
            this.Button2.TabIndex = 14;
            this.Button2.Text = "Reset bodů";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(146, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Skóre";
            // 
            // C3
            // 
            this.C3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C3.Enabled = false;
            this.C3.Image = global::Piskvorky.Properties.Resources.stahování;
            this.C3.Location = new System.Drawing.Point(237, 279);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(111, 111);
            this.C3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C3.TabIndex = 9;
            this.C3.TabStop = false;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // B3
            // 
            this.B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B3.Enabled = false;
            this.B3.Image = global::Piskvorky.Properties.Resources.stahování;
            this.B3.Location = new System.Drawing.Point(129, 279);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(111, 111);
            this.B3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B3.TabIndex = 8;
            this.B3.TabStop = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // A3
            // 
            this.A3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A3.Enabled = false;
            this.A3.Image = global::Piskvorky.Properties.Resources.stahování;
            this.A3.Location = new System.Drawing.Point(21, 279);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(111, 111);
            this.A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A3.TabIndex = 7;
            this.A3.TabStop = false;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // C2
            // 
            this.C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C2.Enabled = false;
            this.C2.Image = global::Piskvorky.Properties.Resources.stahování;
            this.C2.Location = new System.Drawing.Point(237, 173);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(111, 111);
            this.C2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C2.TabIndex = 6;
            this.C2.TabStop = false;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // B2
            // 
            this.B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B2.Enabled = false;
            this.B2.Image = global::Piskvorky.Properties.Resources.stahování;
            this.B2.Location = new System.Drawing.Point(129, 173);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(111, 111);
            this.B2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B2.TabIndex = 5;
            this.B2.TabStop = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // A2
            // 
            this.A2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A2.Enabled = false;
            this.A2.Image = global::Piskvorky.Properties.Resources.stahování;
            this.A2.Location = new System.Drawing.Point(21, 173);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(111, 111);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 4;
            this.A2.TabStop = false;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // C1
            // 
            this.C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1.Enabled = false;
            this.C1.Image = global::Piskvorky.Properties.Resources.stahování;
            this.C1.Location = new System.Drawing.Point(237, 65);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(111, 111);
            this.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1.TabIndex = 3;
            this.C1.TabStop = false;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // B1
            // 
            this.B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B1.Enabled = false;
            this.B1.Image = global::Piskvorky.Properties.Resources.stahování;
            this.B1.Location = new System.Drawing.Point(129, 65);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(111, 111);
            this.B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B1.TabIndex = 2;
            this.B1.TabStop = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // A1
            // 
            this.A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.A1.Enabled = false;
            this.A1.Image = global::Piskvorky.Properties.Resources.stahování;
            this.A1.Location = new System.Drawing.Point(21, 65);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(111, 111);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 0;
            this.A1.TabStop = false;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 636);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.PictureBox C1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox B2;
        private System.Windows.Forms.PictureBox C2;
        private System.Windows.Forms.PictureBox A3;
        private System.Windows.Forms.PictureBox B3;
        private System.Windows.Forms.PictureBox C3;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label label5;
    }
}

