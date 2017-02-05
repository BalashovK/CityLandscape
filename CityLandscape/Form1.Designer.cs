namespace CityLandscape
{
    partial class ConfigurationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_generate = new System.Windows.Forms.Button();
            this.t_width = new System.Windows.Forms.TextBox();
            this.t_height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_total_layers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_building_height_min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_layers_offset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_layers_perspective = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_building_height_max = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t_building_width_min = new System.Windows.Forms.TextBox();
            this.t_building_width_max = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t_windows_on_min = new System.Windows.Forms.TextBox();
            this.t_windows_on_max = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.t_folder = new System.Windows.Forms.TextBox();
            this.b_folder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.b_building_color_min = new System.Windows.Forms.Button();
            this.b_building_color_max = new System.Windows.Forms.Button();
            this.b_window_color_max = new System.Windows.Forms.Button();
            this.b_window_color_min = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.t_frames_to_generate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.t_frame_offset = new System.Windows.Forms.TextBox();
            this.b_progress = new System.Windows.Forms.ProgressBar();
            this.label19 = new System.Windows.Forms.Label();
            this.t_gap_max = new System.Windows.Forms.TextBox();
            this.t_gap_min = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label22 = new System.Windows.Forms.Label();
            this.t_window_width_in_pixels = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // b_generate
            // 
            this.b_generate.Location = new System.Drawing.Point(320, 436);
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(75, 23);
            this.b_generate.TabIndex = 1;
            this.b_generate.Text = "Generate";
            this.b_generate.UseVisualStyleBackColor = true;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // t_width
            // 
            this.t_width.Location = new System.Drawing.Point(130, 32);
            this.t_width.Name = "t_width";
            this.t_width.Size = new System.Drawing.Size(100, 20);
            this.t_width.TabIndex = 2;
            this.t_width.Text = "1920";
            // 
            // t_height
            // 
            this.t_height.Location = new System.Drawing.Point(130, 58);
            this.t_height.Name = "t_height";
            this.t_height.Size = new System.Drawing.Size(100, 20);
            this.t_height.TabIndex = 4;
            this.t_height.Text = "1080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // t_total_layers
            // 
            this.t_total_layers.Location = new System.Drawing.Point(130, 105);
            this.t_total_layers.Name = "t_total_layers";
            this.t_total_layers.Size = new System.Drawing.Size(100, 20);
            this.t_total_layers.TabIndex = 6;
            this.t_total_layers.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Layers";
            // 
            // t_building_height_min
            // 
            this.t_building_height_min.Location = new System.Drawing.Point(412, 29);
            this.t_building_height_min.Name = "t_building_height_min";
            this.t_building_height_min.Size = new System.Drawing.Size(53, 20);
            this.t_building_height_min.TabIndex = 8;
            this.t_building_height_min.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Building Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Building Width";
            // 
            // t_layers_offset
            // 
            this.t_layers_offset.Location = new System.Drawing.Point(130, 131);
            this.t_layers_offset.Name = "t_layers_offset";
            this.t_layers_offset.Size = new System.Drawing.Size(100, 20);
            this.t_layers_offset.TabIndex = 12;
            this.t_layers_offset.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Layer Offset";
            // 
            // t_layers_perspective
            // 
            this.t_layers_perspective.Location = new System.Drawing.Point(130, 157);
            this.t_layers_perspective.Name = "t_layers_perspective";
            this.t_layers_perspective.Size = new System.Drawing.Size(100, 20);
            this.t_layers_perspective.TabIndex = 14;
            this.t_layers_perspective.Text = "90";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Layer Perspective %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Windows On %";
            // 
            // t_building_height_max
            // 
            this.t_building_height_max.Location = new System.Drawing.Point(487, 29);
            this.t_building_height_max.Name = "t_building_height_max";
            this.t_building_height_max.Size = new System.Drawing.Size(53, 20);
            this.t_building_height_max.TabIndex = 17;
            this.t_building_height_max.Text = "40";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "-";
            // 
            // t_building_width_min
            // 
            this.t_building_width_min.Location = new System.Drawing.Point(412, 55);
            this.t_building_width_min.Name = "t_building_width_min";
            this.t_building_width_min.Size = new System.Drawing.Size(53, 20);
            this.t_building_width_min.TabIndex = 8;
            this.t_building_width_min.Text = "4";
            // 
            // t_building_width_max
            // 
            this.t_building_width_max.Location = new System.Drawing.Point(487, 55);
            this.t_building_width_max.Name = "t_building_width_max";
            this.t_building_width_max.Size = new System.Drawing.Size(53, 20);
            this.t_building_width_max.TabIndex = 17;
            this.t_building_width_max.Text = "40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "-";
            // 
            // t_windows_on_min
            // 
            this.t_windows_on_min.Location = new System.Drawing.Point(412, 151);
            this.t_windows_on_min.Name = "t_windows_on_min";
            this.t_windows_on_min.Size = new System.Drawing.Size(53, 20);
            this.t_windows_on_min.TabIndex = 8;
            this.t_windows_on_min.Text = "20";
            // 
            // t_windows_on_max
            // 
            this.t_windows_on_max.Location = new System.Drawing.Point(487, 151);
            this.t_windows_on_max.Name = "t_windows_on_max";
            this.t_windows_on_max.Size = new System.Drawing.Size(53, 20);
            this.t_windows_on_max.TabIndex = 17;
            this.t_windows_on_max.Text = "80";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Target Folder";
            // 
            // t_folder
            // 
            this.t_folder.Location = new System.Drawing.Point(130, 343);
            this.t_folder.Name = "t_folder";
            this.t_folder.Size = new System.Drawing.Size(562, 20);
            this.t_folder.TabIndex = 14;
            this.t_folder.Text = "f:\\tmp_images";
            // 
            // b_folder
            // 
            this.b_folder.Location = new System.Drawing.Point(698, 341);
            this.b_folder.Name = "b_folder";
            this.b_folder.Size = new System.Drawing.Size(30, 23);
            this.b_folder.TabIndex = 19;
            this.b_folder.Text = "...";
            this.b_folder.UseVisualStyleBackColor = true;
            this.b_folder.Click += new System.EventHandler(this.b_folder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Building Color";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(471, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "-";
            // 
            // b_building_color_min
            // 
            this.b_building_color_min.BackColor = System.Drawing.Color.Maroon;
            this.b_building_color_min.ForeColor = System.Drawing.Color.White;
            this.b_building_color_min.Location = new System.Drawing.Point(412, 182);
            this.b_building_color_min.Name = "b_building_color_min";
            this.b_building_color_min.Size = new System.Drawing.Size(53, 23);
            this.b_building_color_min.TabIndex = 20;
            this.b_building_color_min.Text = "Min";
            this.b_building_color_min.UseVisualStyleBackColor = false;
            this.b_building_color_min.Click += new System.EventHandler(this.b_building_color_min_Click);
            // 
            // b_building_color_max
            // 
            this.b_building_color_max.BackColor = System.Drawing.Color.Navy;
            this.b_building_color_max.ForeColor = System.Drawing.Color.White;
            this.b_building_color_max.Location = new System.Drawing.Point(487, 182);
            this.b_building_color_max.Name = "b_building_color_max";
            this.b_building_color_max.Size = new System.Drawing.Size(53, 23);
            this.b_building_color_max.TabIndex = 20;
            this.b_building_color_max.Text = "Max";
            this.b_building_color_max.UseVisualStyleBackColor = false;
            this.b_building_color_max.Click += new System.EventHandler(this.b_building_color_max_Click);
            // 
            // b_window_color_max
            // 
            this.b_window_color_max.BackColor = System.Drawing.Color.Orange;
            this.b_window_color_max.Location = new System.Drawing.Point(487, 211);
            this.b_window_color_max.Name = "b_window_color_max";
            this.b_window_color_max.Size = new System.Drawing.Size(53, 23);
            this.b_window_color_max.TabIndex = 23;
            this.b_window_color_max.Text = "Max";
            this.b_window_color_max.UseVisualStyleBackColor = false;
            this.b_window_color_max.Click += new System.EventHandler(this.b_window_color_max_Click);
            // 
            // b_window_color_min
            // 
            this.b_window_color_min.BackColor = System.Drawing.Color.LightPink;
            this.b_window_color_min.Location = new System.Drawing.Point(412, 211);
            this.b_window_color_min.Name = "b_window_color_min";
            this.b_window_color_min.Size = new System.Drawing.Size(53, 23);
            this.b_window_color_min.TabIndex = 24;
            this.b_window_color_min.Text = "Min";
            this.b_window_color_min.UseVisualStyleBackColor = false;
            this.b_window_color_min.Click += new System.EventHandler(this.b_window_color_min_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(471, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(307, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Window Color";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 206);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Frames to generate";
            // 
            // t_frames_to_generate
            // 
            this.t_frames_to_generate.Location = new System.Drawing.Point(130, 206);
            this.t_frames_to_generate.Name = "t_frames_to_generate";
            this.t_frames_to_generate.Size = new System.Drawing.Size(100, 20);
            this.t_frames_to_generate.TabIndex = 14;
            this.t_frames_to_generate.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Frame Offset";
            // 
            // t_frame_offset
            // 
            this.t_frame_offset.Location = new System.Drawing.Point(130, 232);
            this.t_frame_offset.Name = "t_frame_offset";
            this.t_frame_offset.Size = new System.Drawing.Size(100, 20);
            this.t_frame_offset.TabIndex = 14;
            this.t_frame_offset.Text = "5";
            // 
            // b_progress
            // 
            this.b_progress.Location = new System.Drawing.Point(28, 386);
            this.b_progress.Name = "b_progress";
            this.b_progress.Size = new System.Drawing.Size(699, 26);
            this.b_progress.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(471, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "-";
            // 
            // t_gap_max
            // 
            this.t_gap_max.Location = new System.Drawing.Point(487, 81);
            this.t_gap_max.Name = "t_gap_max";
            this.t_gap_max.Size = new System.Drawing.Size(53, 20);
            this.t_gap_max.TabIndex = 28;
            this.t_gap_max.Text = "100";
            // 
            // t_gap_min
            // 
            this.t_gap_min.Location = new System.Drawing.Point(412, 81);
            this.t_gap_min.Name = "t_gap_min";
            this.t_gap_min.Size = new System.Drawing.Size(53, 20);
            this.t_gap_min.TabIndex = 26;
            this.t_gap_min.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(307, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Building Gap";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(307, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Window Width";
            // 
            // t_window_width_in_pixels
            // 
            this.t_window_width_in_pixels.Location = new System.Drawing.Point(412, 124);
            this.t_window_width_in_pixels.Name = "t_window_width_in_pixels";
            this.t_window_width_in_pixels.Size = new System.Drawing.Size(53, 20);
            this.t_window_width_in_pixels.TabIndex = 30;
            this.t_window_width_in_pixels.Text = "20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(557, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "(# of windows)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(557, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "(# of windows)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(557, 127);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "(pixels)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(236, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 32;
            this.label25.Text = "(pixels)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(236, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 13);
            this.label26.TabIndex = 32;
            this.label26.Text = "(pixels)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(236, 232);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "(pixels)";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 480);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.t_window_width_in_pixels);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.t_gap_max);
            this.Controls.Add(this.t_gap_min);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.b_progress);
            this.Controls.Add(this.b_window_color_max);
            this.Controls.Add(this.b_window_color_min);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.b_building_color_max);
            this.Controls.Add(this.b_building_color_min);
            this.Controls.Add(this.b_folder);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t_windows_on_max);
            this.Controls.Add(this.t_building_width_max);
            this.Controls.Add(this.t_building_height_max);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.t_folder);
            this.Controls.Add(this.t_frame_offset);
            this.Controls.Add(this.t_frames_to_generate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.t_layers_perspective);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t_layers_offset);
            this.Controls.Add(this.t_windows_on_min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_building_width_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_building_height_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_total_layers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_width);
            this.Controls.Add(this.b_generate);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurationForm";
            this.Text = "Landscape Generator";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_generate;
        private System.Windows.Forms.TextBox t_width;
        private System.Windows.Forms.TextBox t_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_total_layers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_building_height_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_layers_offset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_layers_perspective;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_building_height_max;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_building_width_min;
        private System.Windows.Forms.TextBox t_building_width_max;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_windows_on_min;
        private System.Windows.Forms.TextBox t_windows_on_max;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_folder;
        private System.Windows.Forms.Button b_folder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button b_building_color_min;
        private System.Windows.Forms.Button b_building_color_max;
        private System.Windows.Forms.Button b_window_color_max;
        private System.Windows.Forms.Button b_window_color_min;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox t_frames_to_generate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox t_frame_offset;
        private System.Windows.Forms.ProgressBar b_progress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox t_gap_max;
        private System.Windows.Forms.TextBox t_gap_min;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox t_window_width_in_pixels;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
    }
}

