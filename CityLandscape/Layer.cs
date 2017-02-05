using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLandscape
{
    public class Layer
    {
        public List<Building> m_buildings = new List<Building>();
        public Config m_config;
        int m_scaleFactor;
        int m_yOffset;

        public Layer(Config m_config, int scaleFactor, int yOffset)
        {
            this.m_config = m_config;
            this.m_scaleFactor = scaleFactor;
            this.m_yOffset = yOffset;
        }

        public void GenerateLayer()
        {
            // until we fill the layer with buildings, generate a building and add it to the landscape
            int start_pixel = 0;
            int layer_width_in_pixels = m_config.layer_width_in_pixels;
            while (start_pixel <= layer_width_in_pixels)
            {
                Building b = new Building(m_config);
                b.GenerateBuilding(start_pixel);
                start_pixel += b.width_in_pixels;
                m_buildings.Add(b);
            }
        }
        public void DrawLayer(System.Drawing.Graphics g, int startingPoint)
        {
            int adjusted_starting_point = (startingPoint * m_scaleFactor) / 100;
//            int adjusted_end_point = ((startingPoint + m_config.m_frame_width_in_pixels) * m_scaleFactor) / 100;
            int adjusted_end_point = adjusted_starting_point + (m_config.m_frame_width_in_pixels * 100) / m_scaleFactor;

            // find buildings to draw

            int currentPoint = 0;
            foreach (Building b in m_buildings)
            {
                int adjusted_total_building_width_in_pixels = (b.total_width_in_pixels * m_scaleFactor) / 100;

                if (currentPoint >= adjusted_end_point)
                {
                    break; // done!
                }
                if (currentPoint + adjusted_total_building_width_in_pixels >= adjusted_starting_point)
                {
                    int offsetX = currentPoint - adjusted_starting_point;
                    b.DrawBuilding(g, offsetX, m_yOffset, m_scaleFactor);
                }

                currentPoint += adjusted_total_building_width_in_pixels;

            }

            // call building.DrawBuilding

        }
    }
}
