using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace ImageEditorCSharp
{
    public static class Zrgb
    {
        public static Bitmap RGBCanvas(this Bitmap newBitmap, int bitmapWidth)
        {
            float ratio = 1.0f;
            int maxSide = newBitmap.Width > newBitmap.Height ?
                          newBitmap.Width : newBitmap.Height;

            ratio = (float)maxSide / (float)bitmapWidth;

            Bitmap bitmapResult = (newBitmap.Width > newBitmap.Height ?
                                    new Bitmap(bitmapWidth, (int)(newBitmap.Height / ratio))
                                    : new Bitmap((int)(newBitmap.Width / ratio), bitmapWidth));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(newBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            newBitmap.Width, newBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }

        public static Bitmap ColorTint(this Bitmap newBitmap, float blueTint, 
                                       float greenTint, float redTint)
        {
            BitmapData sourceData = newBitmap.LockBits(new Rectangle(0, 0,
                                    newBitmap.Width, newBitmap.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            newBitmap.UnlockBits(sourceData);

            float blue = 0;
            float green = 0;
            float red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = pixelBuffer[k] + (255 - pixelBuffer[k]) * blueTint;
                green = pixelBuffer[k + 1] + (255 - pixelBuffer[k + 1]) * greenTint;
                red = pixelBuffer[k + 2] + (255 - pixelBuffer[k + 2]) * redTint;

                if (blue > 255)
                { blue = 255; }

                if (green > 255)
                { green = 255; }

                if (red > 255)
                { red = 255; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;

            }

            Bitmap resultBitmap = new Bitmap(newBitmap.Width, newBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }
}
