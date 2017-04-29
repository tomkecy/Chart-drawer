using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDrawer.Abstract;

namespace ChartDrawer.Concrete
{
    class ImageSaveHandler : IImageSaveHandler
    {
        public bool SaveToFile(Image image)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp",
                Title = "Zapisz obraz jako:"
            };
            saveFileDialog.ShowDialog();

            if (String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                return false;
            }
            using (System.IO.FileStream fileStream = (System.IO.FileStream) saveFileDialog.OpenFile())
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                         image.Save(fileStream, ImageFormat.Jpeg);
                         break;
                    case 2:
                         image.Save(fileStream, ImageFormat.Bmp);
                         break;
                }
            }
            return true;
        }
    }
}
