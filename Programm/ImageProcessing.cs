using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;


namespace FR_GA
{
    static internal class ImageProcessing
    {
        public struct Pixel
        {
            public byte blue;
            public byte green;
            public byte red;
        }
        static public void ConvertRGBToGray(ref Bitmap img)
        {
            for (int i = 0; i < img.Width; i++)
            {
                Application.DoEvents();
                for (int j = 0; j < img.Height; j++)
                {
                    int R = img.GetPixel(i, j).R;
                    int G = img.GetPixel(i, j).G;
                    int B = img.GetPixel(i, j).B;
                    int gray = (int)(0.2989 * R + 0.5870 * G + 0.1140 * B);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    img.SetPixel(i, j, newColor);
                }
            }
        }
        static public void ConvertRGBToGrayPoniter(ref Bitmap img)
        {
            GraphicsUnit mnn = GraphicsUnit.Pixel;
            RectangleF bounds = img.GetBounds(ref mnn);
            BitmapData bmpData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* pixel;
                int width = (int)bounds.Width * sizeof(Pixel);
                for (int j = 0; j < bounds.Height; j++)
                {
                    for (int i = 0; i < bounds.Width; i++)
                    {
                        pixel = (byte*)bmpData.Scan0.ToPointer();
                        if (width % 4 != 0)
                        {
                            width = 4 * (width / 4 + 1);
                        }
                        Pixel* MyP = (Pixel*)(pixel + j * width + i * sizeof(Pixel));
                        int R = MyP->red;
                        int G = MyP->green;
                        int B = MyP->blue;
                        int gray = (int)(0.2989 * R + 0.5870 * G + 0.1140 * B);
                        MyP->red = (byte)gray;
                        MyP->green = (byte)gray;
                        MyP->blue = (byte)gray;
                        //MyP++;
                    }
                }
                img.UnlockBits(bmpData);
            }
        }
        public static int[,] BitmapToArray2D(Bitmap bmp)
        {
            Image<Gray, Single> img = new Image<Gray, Single>(bmp);
            Bitmap image = img.ToBitmap();

            int[,] array2D = null;
            if (image.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                array2D = new int[image.Width, image.Height];
                BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
                int paddingOffset = bitmapData.Stride - (bitmapData.Width * 1); //1 == 1-byte per pixel
                unsafe
                {
                    byte* memoryAddress = (byte*)bitmapData.Scan0;
                    for (int i = 0; i < bitmapData.Width; i++)
                    {
                        for (int j = 0; j < bitmapData.Height; j++)
                        {
                            byte tempByte = memoryAddress[0];
                            array2D[i, j] = (int)tempByte;
                            int tempArrayElement = array2D[i, j];
                            //1-byte per pixel
                            memoryAddress += 1;
                        }

                        memoryAddress += paddingOffset;
                    }
                }

                image.UnlockBits(bitmapData);
            }
            else
            {
                throw new Exception("8 bit/pixel indexed image required.");
            }

            return array2D;
        }
        public static Bitmap Array2DToBitmap(int[,] image)
        {
            Bitmap output = new Bitmap(image.GetLength(0), image.GetLength(1));
            BitmapData bitmapData = output.LockBits(new Rectangle(0, 0, image.GetLength(0), image.GetLength(1)), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int paddingOffset = bitmapData.Stride - (bitmapData.Width * 1); //1 == 1-byte per pixel
            unsafe
            {
                byte* memoryAddress = (byte*)bitmapData.Scan0;
                for (int i = 0; i < bitmapData.Height; i++)
                {
                    for (int j = 0; j < bitmapData.Width; j++)
                    {
                        int tempInt = image[j, i];
                        memoryAddress[0] = (byte)tempInt;
                        byte tempByte = memoryAddress[0];
                        //1-byte per pixel
                        memoryAddress += 1;
                    }

                    memoryAddress += paddingOffset;
                }
            }

            output.UnlockBits(bitmapData);
            return output;
        }
        public static void ResizeBitmap(ref Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            bmp = result;
        }
    }
}
