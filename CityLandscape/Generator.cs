using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLandscape
{
    public class Generator
    {
        public static void Generate(Config config, System.ComponentModel.BackgroundWorker bgWorker)
        {

            Scene scene = new Scene(config);
            scene.GenerateLayers();

            bgWorker.ReportProgress(10);


            int current_frame_offset = 0;
            for (int i = 0; i<config.m_frames_to_generate; i++ )
            {
                Bitmap bm = GenerateFrame(config, scene, current_frame_offset);
                SaveFrame(config, bm, i);

                bm.Dispose();

                current_frame_offset += config.m_frame_offset;
                bgWorker.ReportProgress(10 + (i * 90) / config.m_frames_to_generate);
            }
            bgWorker.ReportProgress(100);
        }

        private static Bitmap GenerateFrame(Config config, Scene scene, int frameOffset)
        {
            Bitmap bm = new Bitmap(config.m_frame_width_in_pixels, config.m_frame_height_in_pixels);
            Graphics g = Graphics.FromImage(bm);

            scene.DrawFrame(g, frameOffset);

            g.Dispose();

            return bm;
        }

        private static void SaveFrame(Config config, Bitmap frame, int FrameNumber)
        {

            string fn = string.Format("{0:00000000}.png", FrameNumber);
            string full_fn = System.IO.Path.Combine(config.m_folder, fn);
            // save frame here
            frame.Save(full_fn, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
