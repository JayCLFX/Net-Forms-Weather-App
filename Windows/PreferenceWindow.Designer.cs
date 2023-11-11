namespace Visual_Weather_App.Windows
{
    partial class PreferenceWindow
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
            this.CityInput = new System.Windows.Forms.TextBox();
            this.ApiKeyInput = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(66, 24);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(100, 20);
            this.CityInput.TabIndex = 0;
            // 
            // ApiKeyInput
            // 
            this.ApiKeyInput.Location = new System.Drawing.Point(66, 72);
            this.ApiKeyInput.Name = "ApiKeyInput";
            this.ApiKeyInput.Size = new System.Drawing.Size(100, 20);
            this.ApiKeyInput.TabIndex = 1;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(12, 22);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "API-Key";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(66, 144);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PreferenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual_Weather_App.Properties.Resources.preferences_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(203, 179);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.ApiKeyInput);
            this.Controls.Add(this.CityInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreferenceWindow";
            this.Text = "PreferenceWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.TextBox ApiKeyInput;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
    }
}