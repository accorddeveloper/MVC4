using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace HaveYouSeenMeApp.Models.BusinessModel
{
    public class PetManagement
    {

        public static void CreateThumbnail(string fPath, string fName, int th, int tw, bool isCheckSize)
        {
            var originalFile = Path.Combine(fPath, fName);
            var imageSource = Image.FromFile(originalFile);

            int h = th, w = tw;

            if (isCheckSize)
            {
                if(imageSource.Width > imageSource.Height)
                {
                    w = imageSource.Width;
                    h = imageSource.Height * (w / imageSource.Width);
                }
                else
                {
                    h = imageSource.Height;
                    w = imageSource.Width * (h / imageSource.Height);
                }
            }

            Bitmap thumbnail = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(thumbnail))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.Transparent, 0, 0, w, h);
                g.DrawImage(imageSource, 0, 0, w, h);
            }

            var thumbFile = Path.Combine(fPath, "Thumbnail-" + fName);
            thumbnail.Save(thumbFile);

        }

    }
}