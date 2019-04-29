using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace Solutions.Geeks
{
    /*https://www.geeksforgeeks.org/image-processing-in-java-set-3-colored-image-to-greyscale-image-conversion/
     */
    public class CustomImage
    {
        /*
          Note(Think intuitively): In a greyscale image the Alpha component of the image will be same as the original image, but the RGB wil be changed i.e, all three RGB components will be having a same value for each pixels.

              Algorithm:

          Get the RGB value of the pixel.
          Find the average of RGB i.e., Avg = (R + G + B) / 3
          Replace the R, G and B value of the pixel with average(Avg) calculated in step 2.
          Repeat Step 1 to Step 3 for each pixels of the image.
        */
        public int ConvertColorToGreyScalePixel(int pixel)
        {
            int avgRgb = GetAverageOfRGB(pixel);
            //we need to keep the alpha same
            int a = (pixel >> 24) & 0xff;

            int greyPixel = (a << 24) | (avgRgb << 16) | (avgRgb << 8) | avgRgb;
            return greyPixel;
        }

        /*
         * Note: In a negative image the Alpha component of the image will be same as the original image,
         * but the RGB will be changed i.e, all three RGB components will be having a value of
         * 255-original component value.
         *
         * Get the RGB value of the pixel.
            Calculate new RGB values as follows:
            R = 255 – R
            G = 255 – G
            B = 255 – B
            Replace the R, G and B value of the pixel with the values calculated in step 2.
            Repeat Step 1 to Step 3 for each pixels of the image.

         */


        public int GetAverageOfRGB(int pixel)
        {
            int a = (pixel >> 24) & 0xff;
            int r = (pixel >> 16) & 0xff;
            int g = (pixel >> 8) & 0xff;
            int b = pixel & 0xff;

            return (r + g + b) / 3;
        }
    }
}
