using System.ComponentModel;

namespace Programming.View.Panels
{
    partial class SeasonHandleGroupBoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSeasonHandle = new System.Windows.Forms.GroupBox();
            this.ComboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lbChooseSeason = new System.Windows.Forms.Label();
            this.gbSeasonHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSeasonHandle
            // 
            this.gbSeasonHandle.AutoSize = true;
            this.gbSeasonHandle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSeasonHandle.Controls.Add(this.ComboBoxSeasons);
            this.gbSeasonHandle.Controls.Add(this.btnGo);
            this.gbSeasonHandle.Controls.Add(this.lbChooseSeason);
            this.gbSeasonHandle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSeasonHandle.Location = new System.Drawing.Point(0, 0);
            this.gbSeasonHandle.Name = "gbSeasonHandle";
            this.gbSeasonHandle.Size = new System.Drawing.Size(778, 82);
            this.gbSeasonHandle.TabIndex = 2;
            this.gbSeasonHandle.TabStop = false;
            this.gbSeasonHandle.Text = "Season Handle";
            // 
            // ComboBoxSeasons
            // 
            this.ComboBoxSeasons.FormattingEnabled = true;
            this.ComboBoxSeasons.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxSeasons.Name = "ComboBoxSeasons";
            this.ComboBoxSeasons.Size = new System.Drawing.Size(149, 21);
            this.ComboBoxSeasons.TabIndex = 10;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(161, 40);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lbChooseSeason
            // 
            this.lbChooseSeason.Location = new System.Drawing.Point(6, 16);
            this.lbChooseSeason.Name = "lbChooseSeason";
            this.lbChooseSeason.Size = new System.Drawing.Size(187, 23);
            this.lbChooseSeason.TabIndex = 6;
            this.lbChooseSeason.Text = "Choose season:";
            this.lbChooseSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeasonHandleGroupBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSeasonHandle);
            this.Name = "SeasonHandleGroupBoxControl";
            this.Size = new System.Drawing.Size(778, 82);
            this.gbSeasonHandle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox gbSeasonHandle;

        private System.Windows.Forms.ComboBox ComboBoxSeasons;

        private System.Windows.Forms.Button btnGo;

        private System.Windows.Forms.Label lbChooseSeason;

        #endregion
    }
}