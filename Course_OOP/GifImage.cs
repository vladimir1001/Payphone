using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Course_OOP
{
    //Клас для покадрового відтворення gif-анімації
    public class GifImage
    {
        private Image gifImage;
        private FrameDimension dimension;
        private int frameCount;
        private int currentFrame = -1;
        public GifImage(string path)
        {
            gifImage = Image.FromFile(path);
            dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            frameCount = gifImage.GetFrameCount(dimension);//Кількість кадрів
        }

        public Image GetNextFrame()
        {
            currentFrame++;
            if (currentFrame == frameCount)
            {
                currentFrame = 0;
                throw new ArgumentOutOfRangeException();
            }
            return GetFrame(currentFrame);
        }

        public Image GetFrame(int index)
        {
            gifImage.SelectActiveFrame(dimension, index);
            //find the frame
            return (Image)gifImage.Clone();
        }
    }
}
