using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLandscape
{
    public partial class ConfigurationForm : Form
    {
        Config m_config = new Config();
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Generator.Generate(m_config, backgroundWorker1);
        }

        private void Screen2Config()
        {
            // colors
            m_config.m_building_color_min = Config.ReadColor(b_building_color_min);
            m_config.m_building_color_max = Config.ReadColor(b_building_color_max);
            m_config.m_window_color_min = Config.ReadColor(b_window_color_min);
            m_config.m_window_color_max = Config.ReadColor(b_window_color_max);
            // strings
            m_config.m_folder = t_folder.Text;
            // integers
            m_config.m_building_height_max = Config.ReadInt(t_building_height_max, m_config.m_building_height_max);
            m_config.m_building_height_min = Config.ReadInt(t_building_height_min, m_config.m_building_height_min);
            m_config.m_building_width_min = Config.ReadInt(t_building_width_min, m_config.m_building_width_min);
            m_config.m_building_width_max = Config.ReadInt(t_building_width_max, m_config.m_building_width_max);

            m_config.m_gap_min = Config.ReadInt(t_gap_min, m_config.m_gap_min);
            m_config.m_gap_max = Config.ReadInt(t_gap_max, m_config.m_gap_max);

            m_config.m_layers_offset = Config.ReadInt(t_layers_offset, m_config.m_layers_offset);
            m_config.m_layers_perspective = Config.ReadInt(t_layers_perspective, m_config.m_layers_perspective);
            m_config.m_total_layers = Config.ReadInt(t_total_layers, m_config.m_total_layers);

            m_config.m_windows_on_min = Config.ReadInt(t_windows_on_min, m_config.m_windows_on_min);
            m_config.m_windows_on_max = Config.ReadInt(t_windows_on_max, m_config.m_windows_on_max);

            m_config.m_frames_to_generate = Config.ReadInt(t_frames_to_generate, m_config.m_frames_to_generate);
            m_config.m_frame_offset = Config.ReadInt(t_frame_offset, m_config.m_frame_offset);

            m_config.m_window_width_in_pixels = Config.ReadInt(t_window_width_in_pixels, m_config.m_window_width_in_pixels);

        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            b_progress.Value = 0;
            Randomizer.Initialize();
            b_progress.Value = 0;
            Screen2Config();
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            b_progress.Value = e.ProgressPercentage;
        }

        private void b_building_color_min_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = b_building_color_min.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b_building_color_min.BackColor = colorDialog1.Color;
            }
        }

        private void b_building_color_max_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = b_building_color_max.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b_building_color_max.BackColor = colorDialog1.Color;
            }

        }

        private void b_window_color_min_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = b_window_color_min.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b_window_color_min.BackColor = colorDialog1.Color;
            }
        }

        private void b_window_color_max_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = b_window_color_max.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b_window_color_max.BackColor = colorDialog1.Color;
            }
        }

        private void b_folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = t_folder.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                t_folder.Text = folderBrowserDialog1.SelectedPath;
            }

        }
    }
}
