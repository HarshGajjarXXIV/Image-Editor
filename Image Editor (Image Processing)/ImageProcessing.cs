using System;
using System.Drawing;

namespace Image_Editor
{
    class ImageProcessing
    {
        public ImageProcessing()
        {

        }

        public static bool ConvertToGray(Bitmap bmap)
        {
            for(int i=0; i< bmap.Width; i++)
            {
                for(int j=0; j< bmap.Height; j++)
                {
                    Color clr = bmap.GetPixel(i, j);
                    int gray = (byte)(.299 * clr.R + .587 * clr.G + .114 * clr.B);
                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return true;
        }

        public static bool ConvertToInvert(Bitmap bmap)
        {
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    Color clr = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(255 - clr.R, 255 - clr.G, 255 - clr.B));
                }
            }
            return true;
        }

        public static bool RedFilter(Bitmap bmap)
        {
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    Color clr = bmap.GetPixel(i, j);
                    int R = clr.R;
                    int G = 0;
                    int B = 0;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)R, (byte)G, (byte)B));
                }
            }
            return true;
        }

        public static bool GreenFilter(Bitmap bmap)
        {
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    Color clr = bmap.GetPixel(i, j);
                    int R = 0;
                    int G = clr.G;
                    int B = 0;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)R, (byte)G, (byte)B));
                }
            }
            return true;
        }

        public static bool BlueFilter(Bitmap bmap)
        {
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    Color clr = bmap.GetPixel(i, j);
                    int R = 0;
                    int G = 0;
                    int B = clr.B;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)R, (byte)G, (byte)B));
                }
            }
            return true;
        }

        public static bool SetBrightness(Bitmap bmap, int brightness)
        {
            Color clr;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    clr = bmap.GetPixel(i, j);
                    int R = clr.R + brightness;
                    int G = clr.G + brightness;
                    int B = clr.B + brightness;

                    if (R < 0) R = 1;
                    if (R > 255) R = 255;

                    if (G < 0) G = 1;
                    if (G > 255) G = 255;

                    if (B < 0) B = 1;
                    if (B > 255) B = 255;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)R, (byte)G, (byte)B));
                }
            }
            return true;
        }

        public static bool SetContrast(Bitmap bmap, double contrast)
        {
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color clr;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    clr = bmap.GetPixel(i, j);
                    double R = clr.R / 255.0;
                    R -= 0.5;
                    R *= contrast;
                    R += 0.5;
                    R *= 255;
                    if (R < 0) R = 0;
                    if (R > 255) R = 255;

                    double G = clr.G / 255.0;
                    G -= 0.5;
                    G *= contrast;
                    G += 0.5;
                    G *= 255;
                    if (G < 0) G = 0;
                    if (G > 255) G = 255;

                    double B = clr.B / 255.0;
                    B -= 0.5;
                    B *= contrast;
                    B += 0.5;
                    B *= 255;
                    if (B < 0) B = 0;
                    if (B > 255) B = 255;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)R, (byte)G, (byte)B));
                }
            }
            return true;
        }

        public static bool SetGamma(Bitmap bmap, double gammaRed, double gammaGreen, double gammaBlue)
        {
            Color clr;
            byte[] redGamma = GammaArray(gammaRed);
            byte[] greenGamma = GammaArray(gammaGreen);
            byte[] blueGamma = GammaArray(gammaBlue);
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    clr = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(redGamma[clr.R], greenGamma[clr.G], blueGamma[clr.B]));
                }
            }
            return true;
        }

        private static byte[] GammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; ++i)
            {
                gammaArray[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }
            return gammaArray;
        }

        public static bool RotateRight(Bitmap bmap)
        {
            bmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return true;
        }

        public static bool RotateLeft(Bitmap bmap)
        {
            bmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return true;
        }

        public static bool FlipHorizontal(Bitmap bmap)
        {
            bmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return true;
        }

        public static bool FlipVertical(Bitmap bmap)
        {
            bmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return true;
        }

    }
}
