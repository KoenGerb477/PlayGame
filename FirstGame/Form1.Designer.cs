namespace FirstGame
{
    partial class FirstGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstGame));
            this.goButton = new System.Windows.Forms.Button();
            this.light1Label = new System.Windows.Forms.Label();
            this.light2Label = new System.Windows.Forms.Label();
            this.light3Label = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.White;
            this.goButton.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(146, 156);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(245, 121);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "PRESS TO PLAY";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // light1Label
            // 
            this.light1Label.BackColor = System.Drawing.Color.Red;
            this.light1Label.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light1Label.Location = new System.Drawing.Point(92, 173);
            this.light1Label.Name = "light1Label";
            this.light1Label.Size = new System.Drawing.Size(90, 90);
            this.light1Label.TabIndex = 3;
            this.light1Label.Text = "3";
            this.light1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.light1Label.Visible = false;
            // 
            // light2Label
            // 
            this.light2Label.BackColor = System.Drawing.Color.Red;
            this.light2Label.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light2Label.Location = new System.Drawing.Point(222, 174);
            this.light2Label.Name = "light2Label";
            this.light2Label.Size = new System.Drawing.Size(90, 90);
            this.light2Label.TabIndex = 4;
            this.light2Label.Text = "2";
            this.light2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.light2Label.Visible = false;
            // 
            // light3Label
            // 
            this.light3Label.BackColor = System.Drawing.Color.Red;
            this.light3Label.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light3Label.Location = new System.Drawing.Point(362, 173);
            this.light3Label.Name = "light3Label";
            this.light3Label.Size = new System.Drawing.Size(90, 90);
            this.light3Label.TabIndex = 5;
            this.light3Label.Text = "1";
            this.light3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.light3Label.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.BackColor = System.Drawing.Color.Transparent;
            this.goLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.Black;
            this.goLabel.Location = new System.Drawing.Point(202, 203);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(123, 27);
            this.goLabel.TabIndex = 6;
            this.goLabel.Text = "GOOOO!!!!!";
            this.goLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.goLabel.Visible = false;
            // 
            // FirstGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 438);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.light3Label);
            this.Controls.Add(this.light2Label);
            this.Controls.Add(this.light1Label);
            this.Controls.Add(this.goButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstGame";
            this.Text = "First Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label light1Label;
        private System.Windows.Forms.Label light2Label;
        private System.Windows.Forms.Label light3Label;
        private System.Windows.Forms.Label goLabel;
    }
}

