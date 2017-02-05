using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLandscape
{
    public static class Randomizer
    {
        static Random m_random;

        public static void Initialize()
        {
             m_random = new Random();
        }
        public static void InitializeAndSeed()
        {
             m_random = new Random(DateTime.Now.Millisecond);
        }
        public static System.Drawing.Color MakeColor(System.Drawing.Color color_min, System.Drawing.Color color_max)
        {
            return System.Drawing.Color.FromArgb(255,
                MakeInt(color_min.R,color_max.R),
                MakeInt(color_min.G, color_max.G),
                MakeInt(color_min.B, color_max.B)
                );
        }

        public static int MakeInt(int min, int max)
        {
            int rnd = m_random.Next();

            int actual_min = Math.Min(min, max);
            int actual_max = Math.Max(min, max);

            return actual_min + rnd % (1 + actual_max - actual_min);
        }

        public static bool MakeBool (int percentage)
        {
            int rnd = MakeInt(0, 99);
            return rnd < percentage;
        }
    }
}
