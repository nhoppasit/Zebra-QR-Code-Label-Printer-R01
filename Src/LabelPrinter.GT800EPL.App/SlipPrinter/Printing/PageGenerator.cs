using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SlipPrinter.Printing
{
    public class PageGenerator
    {
        public static BitmapImage GetImage(UserControl pageControl, out int imageWidth, out int imageHeight)
        {
            pageControl.Width = 520;
            pageControl.Height = 400;
            imageWidth = (int)pageControl.Width;
            imageHeight = (int)pageControl.Height;

            pageControl.Measure(new Size(width: double.PositiveInfinity, height: double.PositiveInfinity));
            var sz = pageControl.DesiredSize;
            var rect = new Rect(sz);
            pageControl.Arrange(rect);
            var bmp = new RenderTargetBitmap((int)(rect.Width), (int)(rect.Height), 96, 96, 
                PixelFormats.Default);
            bmp.Render(pageControl);

            var bitmapImage = new BitmapImage();
            var bitmapEncoder = new PngBitmapEncoder();
            bitmapEncoder.Frames.Add(BitmapFrame.Create(bmp));

            using (var stream = new MemoryStream())
            {
                bitmapEncoder.Save(stream);
                stream.Seek(0, SeekOrigin.Begin);

                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }
    }

}
