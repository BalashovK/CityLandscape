using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLandscape
{
    public class Config
    {
        public int m_frame_width_in_pixels = 1920;
        public int m_frame_height_in_pixels = 1080;
        public int m_total_layers = 10;
        public int m_building_height_min = 2;
        public int m_building_height_max = 20;
        public int m_layers_offset = 5;
        public int m_layers_perspective = 90;
        public int m_building_width_min = 4;
        public int m_building_width_max = 20;
        public int m_windows_on_min = 20;
        public int m_windows_on_max = 80;
        public string m_folder = @"f:\tmp_images\";
        public int m_frames_to_generate = 150;
        public int m_frame_offset = 5;
        public int m_gap_min = 0;
        public int m_gap_max = 100;
// Colors
        public System.Drawing.Color m_building_color_min = System.Drawing.Color.Black;
        public System.Drawing.Color m_building_color_max = System.Drawing.Color.Black;
        public System.Drawing.Color m_window_color_max = System.Drawing.Color.White;
        public System.Drawing.Color m_window_color_min = System.Drawing.Color.White;
        public int m_window_width_in_pixels = 10;

        // 

        public static int ReadInt(System.Windows.Forms.TextBox tb, int defaultValue)
        {
            int returnValue = defaultValue;
            try
            {
                returnValue = Int32.Parse(tb.Text);
            }
            catch (Exception)
            {
                
            }

            return returnValue;
        }
        public static System.Drawing.Color ReadColor(System.Windows.Forms.Button tb)
        {
            return tb.BackColor;
        }

        public int layer_width_in_pixels
        {
            get
            {
                return m_frame_width_in_pixels + m_frame_offset * m_frames_to_generate;
            }
        }

    }
}
