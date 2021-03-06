namespace PluginUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WallHoleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BaseHoleDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BaseLengthTextBox = new System.Windows.Forms.TextBox();
            this.BaseWidthTextBox = new System.Windows.Forms.TextBox();
            this.BaseHeightTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HandleDiameterLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HeadHeightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.MalletParametersPictureBox = new System.Windows.Forms.PictureBox();
            this.WallThicknessTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MalletParametersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WallHoleDiameterTextBox
            // 
            this.WallHoleDiameterTextBox.Location = new System.Drawing.Point(232, 267);
            this.WallHoleDiameterTextBox.Name = "WallHoleDiameterTextBox";
            this.WallHoleDiameterTextBox.Size = new System.Drawing.Size(43, 20);
            this.WallHoleDiameterTextBox.TabIndex = 39;
            this.WallHoleDiameterTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.WallHoleDiameterTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(9, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "(от 5 до 11 мм)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(9, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Диаметр на стенке детали(Е)";
            // 
            // BaseHoleDiameterTextBox
            // 
            this.BaseHoleDiameterTextBox.Location = new System.Drawing.Point(232, 217);
            this.BaseHoleDiameterTextBox.Name = "BaseHoleDiameterTextBox";
            this.BaseHoleDiameterTextBox.Size = new System.Drawing.Size(43, 20);
            this.BaseHoleDiameterTextBox.TabIndex = 36;
            this.BaseHoleDiameterTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.BaseHoleDiameterTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // BaseLengthTextBox
            // 
            this.BaseLengthTextBox.Location = new System.Drawing.Point(232, 167);
            this.BaseLengthTextBox.Name = "BaseLengthTextBox";
            this.BaseLengthTextBox.Size = new System.Drawing.Size(43, 20);
            this.BaseLengthTextBox.TabIndex = 35;
            this.BaseLengthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.BaseLengthTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // BaseWidthTextBox
            // 
            this.BaseWidthTextBox.Location = new System.Drawing.Point(232, 117);
            this.BaseWidthTextBox.Name = "BaseWidthTextBox";
            this.BaseWidthTextBox.Size = new System.Drawing.Size(43, 20);
            this.BaseWidthTextBox.TabIndex = 34;
            this.BaseWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.BaseWidthTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // BaseHeightTextBox
            // 
            this.BaseHeightTextBox.BackColor = System.Drawing.Color.White;
            this.BaseHeightTextBox.Location = new System.Drawing.Point(232, 67);
            this.BaseHeightTextBox.Name = "BaseHeightTextBox";
            this.BaseHeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.BaseHeightTextBox.TabIndex = 33;
            this.BaseHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.BaseHeightTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "(от 1 до 5 мм)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Диаметр отверстия в основании(Д)";
            // 
            // HandleDiameterLabel
            // 
            this.HandleDiameterLabel.AutoSize = true;
            this.HandleDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HandleDiameterLabel.Location = new System.Drawing.Point(9, 182);
            this.HandleDiameterLabel.Name = "HandleDiameterLabel";
            this.HandleDiameterLabel.Size = new System.Drawing.Size(101, 15);
            this.HandleDiameterLabel.TabIndex = 30;
            this.HandleDiameterLabel.Text = "(от 12 до 22 мм)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Длина основания детали(Г)";
            // 
            // HeadHeightLabel
            // 
            this.HeadHeightLabel.AutoSize = true;
            this.HeadHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadHeightLabel.Location = new System.Drawing.Point(9, 132);
            this.HeadHeightLabel.Name = "HeadHeightLabel";
            this.HeadHeightLabel.Size = new System.Drawing.Size(101, 15);
            this.HeadHeightLabel.TabIndex = 28;
            this.HeadHeightLabel.Text = "(от 12 до 22 мм)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ширина основания детали(В)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "(от 7 до 13 мм)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Высота основания(Б)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "(от 20 до 30 мм)";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.HeightTextBox.Location = new System.Drawing.Point(232, 17);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(43, 20);
            this.HeightTextBox.TabIndex = 23;
            this.toolTip.SetToolTip(this.HeightTextBox, "Высота детали должна быть меньше 30 мм");
            this.HeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.HeightTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Высота детали(А)";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(12, 366);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(214, 23);
            this.BuildButton.TabIndex = 21;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // MalletParametersPictureBox
            // 
            this.MalletParametersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MalletParametersPictureBox.Image")));
            this.MalletParametersPictureBox.Location = new System.Drawing.Point(285, 12);
            this.MalletParametersPictureBox.Name = "MalletParametersPictureBox";
            this.MalletParametersPictureBox.Size = new System.Drawing.Size(152, 412);
            this.MalletParametersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MalletParametersPictureBox.TabIndex = 20;
            this.MalletParametersPictureBox.TabStop = false;
            // 
            // WallThicknessTextBox
            // 
            this.WallThicknessTextBox.Location = new System.Drawing.Point(232, 317);
            this.WallThicknessTextBox.Name = "WallThicknessTextBox";
            this.WallThicknessTextBox.Size = new System.Drawing.Size(43, 20);
            this.WallThicknessTextBox.TabIndex = 42;
            this.WallThicknessTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            this.WallThicknessTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "(от 2 до 5 мм)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ширина стенки детали(Ж)";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipTitle = "Ошибка ввода";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 428);
            this.Controls.Add(this.WallThicknessTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WallHoleDiameterTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BaseHoleDiameterTextBox);
            this.Controls.Add(this.BaseLengthTextBox);
            this.Controls.Add(this.BaseWidthTextBox);
            this.Controls.Add(this.BaseHeightTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HandleDiameterLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HeadHeightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.MalletParametersPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Построение карданной вилки в КОМПАС-3D";
            ((System.ComponentModel.ISupportInitialize)(this.MalletParametersPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WallHoleDiameterTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BaseHoleDiameterTextBox;
        private System.Windows.Forms.TextBox BaseLengthTextBox;
        private System.Windows.Forms.TextBox BaseWidthTextBox;
        private System.Windows.Forms.TextBox BaseHeightTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label HandleDiameterLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label HeadHeightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.PictureBox MalletParametersPictureBox;
        private System.Windows.Forms.TextBox WallThicknessTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

