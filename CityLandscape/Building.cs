using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLandscape
{
    public class Building
    {
        // definition
        public int m_width;
        public int m_height;
        public System.Drawing.Color[] window_colors;
        public System.Drawing.Color m_building_color;
        public int m_gap;
        // 
        public int m_start_pixel;
        public Config m_config;

        public Building(Config m_config)
        {
            this.m_config = m_config;
        }

        public int width_in_pixels
        {
            get
            {
                return (m_width * 2 + 1) * m_config.m_window_width_in_pixels;
            }
        }
        
        public int total_width_in_pixels
        {
            get
            {
                return width_in_pixels + m_gap;
            }
        }
        
        public int height_in_pixels
        {
            get
            {
                return (m_height * 2 + 1) * m_config.m_window_width_in_pixels;
            }
        }

        public void GenerateBuilding(int start_pixel)
        {
            m_start_pixel = start_pixel;

            // generate size in windows
            m_width = Randomizer.MakeInt(m_config.m_building_width_min, m_config.m_building_width_max);
            m_height = Randomizer.MakeInt(m_config.m_building_height_min, m_config.m_building_height_max);

            // come up with color for the building
            m_building_color = Randomizer.MakeColor(m_config.m_building_color_min, m_config.m_building_color_max);

            // come up with color for the dark windows
            System.Drawing.Color dark_window_color = System.Drawing.Color.FromArgb(255, m_building_color.R / 2, m_building_color.G / 2, m_building_color.B / 2);
            int windows_on = Randomizer.MakeInt(m_config.m_windows_on_min, m_config.m_windows_on_max);

            // for each window come up with a color
            window_colors = new System.Drawing.Color[m_width * m_height];

            for (int x=0;x<m_width;x++)
            {
                for (int y=0;y<m_height; y++)
                {
                    bool window_is_on = Randomizer.MakeBool(windows_on);
                    window_colors[x * m_height + y] = (window_is_on) ?
                        Randomizer.MakeColor(m_config.m_window_color_min, m_config.m_window_color_max) : dark_window_color;
                }
            }

            // generage gap
            m_gap = Randomizer.MakeInt(m_config.m_gap_min, m_config.m_gap_max);

        }
        public System.Drawing.Color GetWindowColor(int x, int y)
        {
            return window_colors[x * m_height + y];
        }

        public void DrawBuilding(System.Drawing.Graphics g, int offsetX, int offsetY, int scaleFactor)
        {
            int scaledWidthInPixels = ScaleValue(width_in_pixels, scaleFactor);
            int scaledHeightInPixels = ScaleValue(height_in_pixels, scaleFactor);
            int scaled_gap_width_in_pizels = ScaleValue(m_gap, scaleFactor);

            int convertedOffsetY = m_config.m_frame_height_in_pixels - (offsetY + scaledHeightInPixels);
            Brush b = new SolidBrush(this.m_building_color);
            g.FillRectangle(b, offsetX, convertedOffsetY, scaledWidthInPixels, scaledHeightInPixels);
            b.Dispose();


            int scaled_window_size = (m_config.m_window_width_in_pixels * scaleFactor) / 100;
            // for all windows
            for (int x=0;x<m_width;x++)
            {
                for (int y=0; y<m_height;y++)
                {
                    Color c = GetWindowColor(x, y);
                    Brush wb = new SolidBrush(c);

                    int unscaled_x = m_config.m_window_width_in_pixels * x * 2 + m_config.m_window_width_in_pixels;
                    int unscaled_y = m_config.m_window_width_in_pixels * y * 2 + m_config.m_window_width_in_pixels;

                    int scaled_x = (unscaled_x * scaleFactor) / 100;
                    int scaled_y = (unscaled_y * scaleFactor) / 100;

                    g.FillRectangle(wb, offsetX + scaled_x, convertedOffsetY + scaled_y, scaled_window_size, scaled_window_size);

                    wb.Dispose();
                }
            }

        }

        private int ScaleValue(int val, int scalefactor)
        {
            return (val * scalefactor) / 100;
        }
    }
}
