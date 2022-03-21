using System.Drawing;
using System.Windows.Forms;

namespace AreaCard.Settings
{
    public class SettingsPicture
    {
        public static void AddTextToPicture(Button button)
        {
            string firstText = "!";

            PointF firstLocation = new PointF(3f, 0f);

            //previousBitmap = new Bitmap((Bitmap)button1.Image);

            Bitmap bitmap = (Bitmap)button.Image;//load the image file

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Font arialFont = new Font("Century Gothic", 10, FontStyle.Bold))
                {
                    graphics.FillEllipse(new SolidBrush(Color.Red), 0f, 0f, 15, 15);
                    graphics.DrawString(firstText, arialFont, Brushes.White, firstLocation);
                }
            }
            button.Image = null;
            button.Image = bitmap;
        }
    }
}
