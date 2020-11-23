namespace WA_Agnelli_GiocoCar_BGW
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.trag = new System.Windows.Forms.PictureBox();
            this.pct_giri = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trag)).BeginInit();
            this.SuspendLayout();
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::WA_Agnelli_GiocoCar_BGW.Properties.Resources.macchinarossa;
            this.car1.Location = new System.Drawing.Point(43, 72);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(196, 80);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 0;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::WA_Agnelli_GiocoCar_BGW.Properties.Resources.macchinabianca;
            this.car2.Location = new System.Drawing.Point(43, 279);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(196, 80);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(201, 129);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(366, 160);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // trag
            // 
            this.trag.Location = new System.Drawing.Point(790, 1);
            this.trag.Name = "trag";
            this.trag.Size = new System.Drawing.Size(53, 463);
            this.trag.TabIndex = 3;
            this.trag.TabStop = false;
            // 
            // pct_giri
            // 
            this.pct_giri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pct_giri.Location = new System.Drawing.Point(-2, 1);
            this.pct_giri.Multiline = true;
            this.pct_giri.Name = "pct_giri";
            this.pct_giri.Size = new System.Drawing.Size(42, 39);
            this.pct_giri.TabIndex = 4;
            this.pct_giri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pct_giri.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WA_Agnelli_GiocoCar_BGW.Properties.Resources.road_trip_background_10864211;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pct_giri);
            this.Controls.Add(this.trag);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox trag;
        private System.Windows.Forms.TextBox pct_giri;
    }
}

