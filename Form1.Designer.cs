namespace DargSim1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Diameter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Mass = new System.Windows.Forms.TextBox();
            this.textBox_Velocity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Angle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Hight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox_Dt = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_ShowNoDrag = new System.Windows.Forms.CheckBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Restart = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numeric_Time = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            legend14.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend14.IsTextAutoFit = false;
            legend14.Name = "Legend";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(255, 13);
            this.chart1.Name = "chart1";
            series27.BorderColor = System.Drawing.Color.Aqua;
            series27.BorderWidth = 2;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Color = System.Drawing.Color.DodgerBlue;
            series27.Legend = "Legend";
            series27.Name = "trajectory";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Color = System.Drawing.Color.Red;
            series28.Legend = "Legend";
            series28.Name = "trajectory without drag";
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Size = new System.Drawing.Size(942, 757);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ball Properties:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "diameter (m) :";
            // 
            // textBox_Diameter
            // 
            this.textBox_Diameter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Diameter.Location = new System.Drawing.Point(131, 40);
            this.textBox_Diameter.Name = "textBox_Diameter";
            this.textBox_Diameter.Size = new System.Drawing.Size(94, 22);
            this.textBox_Diameter.TabIndex = 3;
            this.textBox_Diameter.TextChanged += new System.EventHandler(this.textBox_Diameter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(40, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "mass (kg) :";
            // 
            // textBox_Mass
            // 
            this.textBox_Mass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Mass.Location = new System.Drawing.Point(131, 70);
            this.textBox_Mass.Name = "textBox_Mass";
            this.textBox_Mass.Size = new System.Drawing.Size(94, 22);
            this.textBox_Mass.TabIndex = 5;
            this.textBox_Mass.TextChanged += new System.EventHandler(this.textBox_Mass_TextChanged);
            // 
            // textBox_Velocity
            // 
            this.textBox_Velocity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Velocity.Location = new System.Drawing.Point(131, 177);
            this.textBox_Velocity.Name = "textBox_Velocity";
            this.textBox_Velocity.Size = new System.Drawing.Size(94, 22);
            this.textBox_Velocity.TabIndex = 10;
            this.textBox_Velocity.TextChanged += new System.EventHandler(this.textBox_Velocity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "velocity (m/s) :";
            // 
            // textBox_Angle
            // 
            this.textBox_Angle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Angle.Location = new System.Drawing.Point(131, 147);
            this.textBox_Angle.Name = "textBox_Angle";
            this.textBox_Angle.Size = new System.Drawing.Size(94, 22);
            this.textBox_Angle.TabIndex = 8;
            this.textBox_Angle.TextChanged += new System.EventHandler(this.textBox_Angle_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "angle (deg) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(14, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Starting Conditions:";
            // 
            // textBox_Hight
            // 
            this.textBox_Hight.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Hight.Location = new System.Drawing.Point(131, 206);
            this.textBox_Hight.Name = "textBox_Hight";
            this.textBox_Hight.Size = new System.Drawing.Size(94, 22);
            this.textBox_Hight.TabIndex = 12;
            this.textBox_Hight.TextChanged += new System.EventHandler(this.textBox_Hight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(49, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "hight (m) :";
            // 
            // listBox_Dt
            // 
            this.listBox_Dt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_Dt.FormattingEnabled = true;
            this.listBox_Dt.ItemHeight = 19;
            this.listBox_Dt.Items.AddRange(new object[] {
            "0.1",
            "0.05",
            "0.01",
            "0.005",
            "0.001",
            "0.0005"});
            this.listBox_Dt.Location = new System.Drawing.Point(104, 277);
            this.listBox_Dt.Name = "listBox_Dt";
            this.listBox_Dt.Size = new System.Drawing.Size(121, 80);
            this.listBox_Dt.TabIndex = 13;
            this.listBox_Dt.SelectedIndexChanged += new System.EventHandler(this.listBox_Dt_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(46, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Simulation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(47, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "dt (s) :";
            // 
            // checkBox_ShowNoDrag
            // 
            this.checkBox_ShowNoDrag.AutoSize = true;
            this.checkBox_ShowNoDrag.Location = new System.Drawing.Point(43, 389);
            this.checkBox_ShowNoDrag.Name = "checkBox_ShowNoDrag";
            this.checkBox_ShowNoDrag.Size = new System.Drawing.Size(167, 18);
            this.checkBox_ShowNoDrag.TabIndex = 16;
            this.checkBox_ShowNoDrag.Text = "show trajectory with no drag";
            this.checkBox_ShowNoDrag.UseVisualStyleBackColor = true;
            this.checkBox_ShowNoDrag.CheckedChanged += new System.EventHandler(this.checkBox_ShowNoDrag_CheckedChanged);
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Location = new System.Drawing.Point(52, 413);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(138, 23);
            this.button_Start.TabIndex = 17;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Restart
            // 
            this.button_Restart.Enabled = false;
            this.button_Restart.Location = new System.Drawing.Point(52, 442);
            this.button_Restart.Name = "button_Restart";
            this.button_Restart.Size = new System.Drawing.Size(138, 23);
            this.button_Restart.TabIndex = 18;
            this.button_Restart.Text = "Restart";
            this.button_Restart.UseVisualStyleBackColor = true;
            this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Enabled = false;
            this.button_Reset.Location = new System.Drawing.Point(52, 501);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(138, 23);
            this.button_Reset.TabIndex = 20;
            this.button_Reset.Text = "Reset Parameters";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Enabled = false;
            this.button_Stop.Location = new System.Drawing.Point(52, 471);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(138, 23);
            this.button_Stop.TabIndex = 19;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(30, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "time (s) :";
            // 
            // numeric_Time
            // 
            this.numeric_Time.DecimalPlaces = 1;
            this.numeric_Time.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric_Time.Location = new System.Drawing.Point(104, 363);
            this.numeric_Time.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Time.Name = "numeric_Time";
            this.numeric_Time.Size = new System.Drawing.Size(120, 20);
            this.numeric_Time.TabIndex = 22;
            this.numeric_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Time.ValueChanged += new System.EventHandler(this.numeric_Time_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 781);
            this.Controls.Add(this.numeric_Time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Restart);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.checkBox_ShowNoDrag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox_Dt);
            this.Controls.Add(this.textBox_Hight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Velocity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Angle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Mass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Diameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form1";
            this.Text = "Drag simulator by GuruGuru19";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Diameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Mass;
        private System.Windows.Forms.TextBox textBox_Velocity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Angle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Hight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_Dt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_ShowNoDrag;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Restart;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numeric_Time;
    }
}

