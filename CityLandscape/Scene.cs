using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLandscape
{
    public class Scene
    {
        Layer[] m_layers;
        Config m_config;

        public Scene(Config config)
        {
            m_config = config;
            m_layers = new Layer[m_config.m_total_layers];
        }
        public void GenerateLayers()
        {
            // for each layer fill layer with buildings
            int scaleFactor = 100;
            int yOffset = 0;
            for (int i=0; i<m_config.m_total_layers; i++)
            {
                m_layers[i] = new Layer(m_config, scaleFactor, yOffset);
                m_layers[i].GenerateLayer();
                scaleFactor -= (100 - m_config.m_layers_perspective);
                yOffset += m_config.m_layers_offset;
            }
        }
        public void DrawFrame(System.Drawing.Graphics g, int startingPoint)
        {
            // first, draw background image

            // then draw all the layers starting from the back
            for (int i = m_config.m_total_layers - 1; i >=0 ; i--)
            {
                m_layers[i].DrawLayer(g, startingPoint);
            }
        }
    }
}
