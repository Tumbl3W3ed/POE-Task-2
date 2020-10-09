namespace POE
{
    partial class FrmGameView
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
            this.LblMap = new System.Windows.Forms.Label();
            this.LblPlayerStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMap
            // 
            this.LblMap.AutoSize = true;
            this.LblMap.Font = new System.Drawing.Font("Everson Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMap.Location = new System.Drawing.Point(49, 59);
            this.LblMap.Name = "LblMap";
            this.LblMap.Padding = new System.Windows.Forms.Padding(2);
            this.LblMap.Size = new System.Drawing.Size(4, 20);
            this.LblMap.TabIndex = 0;
            // 
            // LblPlayerStats
            // 
            this.LblPlayerStats.AutoSize = true;
            this.LblPlayerStats.Font = new System.Drawing.Font("Everson Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayerStats.Location = new System.Drawing.Point(405, 59);
            this.LblPlayerStats.Name = "LblPlayerStats";
            this.LblPlayerStats.Size = new System.Drawing.Size(0, 16);
            this.LblPlayerStats.TabIndex = 1;
            // 
            // FrmGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblPlayerStats);
            this.Controls.Add(this.LblMap);
            this.Name = "FrmGameView";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.FrmGameView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMap;
        private System.Windows.Forms.Label LblPlayerStats;
    }
}

