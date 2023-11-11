namespace VisualWeatherApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CityLabel = new System.Windows.Forms.Label();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.Weather_Info = new System.Windows.Forms.PictureBox();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DayLabel = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.AirPressureSymbol = new System.Windows.Forms.PictureBox();
            this.AirPressure = new System.Windows.Forms.Label();
            this.AirPressureLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WindSpeedSymbol = new System.Windows.Forms.PictureBox();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.Visibility = new System.Windows.Forms.Label();
            this.VisibilityPicture = new System.Windows.Forms.PictureBox();
            this.VisibilityLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Weather_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirPressureSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindSpeedSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisibilityPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityLabel.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CityLabel.Location = new System.Drawing.Point(37, 108);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(30, 13);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeatherLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.WeatherLabel.Location = new System.Drawing.Point(37, 92);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(70, 16);
            this.WeatherLabel.TabIndex = 1;
            this.WeatherLabel.Text = "weather";
            // 
            // Weather_Info
            // 
            this.Weather_Info.BackColor = System.Drawing.Color.Transparent;
            this.Weather_Info.BackgroundImage = global::Visual_Weather_App.Properties.Resources.Clouds_Info;
            this.Weather_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Weather_Info.Location = new System.Drawing.Point(26, 11);
            this.Weather_Info.Name = "Weather_Info";
            this.Weather_Info.Size = new System.Drawing.Size(100, 80);
            this.Weather_Info.TabIndex = 2;
            this.Weather_Info.TabStop = false;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TemperatureLabel.Location = new System.Drawing.Point(35, 134);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(72, 27);
            this.TemperatureLabel.TabIndex = 3;
            this.TemperatureLabel.Text = "temp";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResetButton.Location = new System.Drawing.Point(16, 299);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset Location";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.DayLabel.Location = new System.Drawing.Point(31, 283);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(31, 13);
            this.DayLabel.TabIndex = 6;
            this.DayLabel.Text = "day";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.Color.Transparent;
            this.Humidity.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Humidity.Location = new System.Drawing.Point(692, 34);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(79, 16);
            this.Humidity.TabIndex = 7;
            this.Humidity.Text = "Humidity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Visual_Weather_App.Properties.Resources.Humidity_symbol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(652, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 27);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HumidityLabel.Location = new System.Drawing.Point(712, 61);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(34, 16);
            this.HumidityLabel.TabIndex = 9;
            this.HumidityLabel.Text = "00%";
            // 
            // AirPressureSymbol
            // 
            this.AirPressureSymbol.BackColor = System.Drawing.Color.Transparent;
            this.AirPressureSymbol.BackgroundImage = global::Visual_Weather_App.Properties.Resources.AirPressure_Symbol;
            this.AirPressureSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AirPressureSymbol.Location = new System.Drawing.Point(652, 94);
            this.AirPressureSymbol.Name = "AirPressureSymbol";
            this.AirPressureSymbol.Size = new System.Drawing.Size(24, 27);
            this.AirPressureSymbol.TabIndex = 10;
            this.AirPressureSymbol.TabStop = false;
            // 
            // AirPressure
            // 
            this.AirPressure.AutoSize = true;
            this.AirPressure.BackColor = System.Drawing.Color.Transparent;
            this.AirPressure.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirPressure.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AirPressure.Location = new System.Drawing.Point(682, 94);
            this.AirPressure.Name = "AirPressure";
            this.AirPressure.Size = new System.Drawing.Size(115, 16);
            this.AirPressure.TabIndex = 11;
            this.AirPressure.Text = "Air Pressure";
            // 
            // AirPressureLabel
            // 
            this.AirPressureLabel.AutoSize = true;
            this.AirPressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirPressureLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirPressureLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AirPressureLabel.Location = new System.Drawing.Point(691, 122);
            this.AirPressureLabel.Name = "AirPressureLabel";
            this.AirPressureLabel.Size = new System.Drawing.Size(106, 16);
            this.AirPressureLabel.TabIndex = 12;
            this.AirPressureLabel.Text = "1009.483 PS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(691, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Wind Speed";
            // 
            // WindSpeedSymbol
            // 
            this.WindSpeedSymbol.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedSymbol.BackgroundImage = global::Visual_Weather_App.Properties.Resources.Wind_Symbol;
            this.WindSpeedSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindSpeedSymbol.Location = new System.Drawing.Point(652, 169);
            this.WindSpeedSymbol.Name = "WindSpeedSymbol";
            this.WindSpeedSymbol.Size = new System.Drawing.Size(24, 27);
            this.WindSpeedSymbol.TabIndex = 14;
            this.WindSpeedSymbol.TabStop = false;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.WindSpeedLabel.Location = new System.Drawing.Point(692, 209);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(52, 16);
            this.WindSpeedLabel.TabIndex = 15;
            this.WindSpeedLabel.Text = "speed";
            // 
            // Visibility
            // 
            this.Visibility.AutoSize = true;
            this.Visibility.BackColor = System.Drawing.Color.Transparent;
            this.Visibility.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visibility.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Visibility.Location = new System.Drawing.Point(691, 248);
            this.Visibility.Name = "Visibility";
            this.Visibility.Size = new System.Drawing.Size(97, 16);
            this.Visibility.TabIndex = 16;
            this.Visibility.Text = "Visibility";
            // 
            // VisibilityPicture
            // 
            this.VisibilityPicture.BackColor = System.Drawing.Color.Transparent;
            this.VisibilityPicture.BackgroundImage = global::Visual_Weather_App.Properties.Resources.Visibility_Symbol;
            this.VisibilityPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisibilityPicture.Location = new System.Drawing.Point(652, 237);
            this.VisibilityPicture.Name = "VisibilityPicture";
            this.VisibilityPicture.Size = new System.Drawing.Size(24, 27);
            this.VisibilityPicture.TabIndex = 17;
            this.VisibilityPicture.TabStop = false;
            // 
            // VisibilityLabel
            // 
            this.VisibilityLabel.AutoSize = true;
            this.VisibilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.VisibilityLabel.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisibilityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VisibilityLabel.Location = new System.Drawing.Point(694, 280);
            this.VisibilityLabel.Name = "VisibilityLabel";
            this.VisibilityLabel.Size = new System.Drawing.Size(52, 16);
            this.VisibilityLabel.TabIndex = 18;
            this.VisibilityLabel.Text = "speed";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(778, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 26);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.VisibilityLabel);
            this.Controls.Add(this.VisibilityPicture);
            this.Controls.Add(this.Visibility);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.WindSpeedSymbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AirPressureLabel);
            this.Controls.Add(this.AirPressure);
            this.Controls.Add(this.AirPressureSymbol);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.Weather_Info);
            this.Controls.Add(this.WeatherLabel);
            this.Controls.Add(this.CityLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Weather_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirPressureSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindSpeedSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisibilityPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.PictureBox Weather_Info;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.PictureBox AirPressureSymbol;
        private System.Windows.Forms.Label AirPressure;
        private System.Windows.Forms.Label AirPressureLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox WindSpeedSymbol;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label Visibility;
        private System.Windows.Forms.PictureBox VisibilityPicture;
        private System.Windows.Forms.Label VisibilityLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}