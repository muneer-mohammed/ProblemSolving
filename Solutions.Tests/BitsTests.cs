using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Solutions.Geeks;

namespace Solutions.Tests
{
    [TestFixture]
    class BitsTests
    {
        /*  https://www.geeksforgeeks.org/image-processing-java-set-2-get-set-pixels/
        */
        [Test] 
        public void ShiftRight_Number_ShiftedNumber()
        { 
            int a = 255;
            int r = 100;
            int g = 150;
            int b = 200;

            //set the pixel value (ARGB)     
            //Alpha   | RED | GREEN | BLUE|
            //31--24  |23--16|15--08|07--0|
            //<-8bits->
            long p = (a << 24) | (r << 16) | (g << 8) | b;

            int gb = (g << 8) | b;
            int rgb = (r << 16) | (g << 8) | b;

            long a2 = (p >> 24);
            a2 = a2 & 0xff;

            // get red 
            long r2 = (p >> 16);
            r2 = r2 & 0xff;

            // get green 
            long g2 = (p >> 8);
            g2 = g2 & 0xff;

            // get blue 
            long b2 = p & 0xff;

            Assert.AreEqual(a, a2);
            Assert.AreEqual(r, r2);
            Assert.AreEqual(g, g2);
            Assert.AreEqual(b, b2);
        }

        [Test]
        public void GetAverageOfRGB_ARGB_ReturnsAverageRGB()
        {
            CustomImage cImage = new CustomImage();
            int a = 255;
            int r = 100;
            int g = 150;
            int b = 200;
            int pixel = (a << 24) | (r << 16) | (g << 8) | b;

            int avgRGB = cImage.GetAverageOfRGB(pixel);
            Assert.AreEqual(150, avgRGB);
        }

        [Test]
        public void ConvertColorToGreyscalImage_ColorImage_ReturnsGreyScaleImage()
        {
            CustomImage cImage = new CustomImage();
            int a = 255;
            int r = 100;
            int g = 150;
            int b = 200;
            int pixel = (a << 24) | (r << 16) | (g << 8) | b;

            int avgRGB = cImage.GetAverageOfRGB(pixel);
            int greyScalePixel = cImage.ConvertColorToGreyScalePixel(pixel);

            int avgRGB2 = (greyScalePixel) & 0xff;
            Assert.AreEqual(avgRGB2, avgRGB);
            Assert.AreEqual(-6908266, greyScalePixel);
        }
    }
}
   