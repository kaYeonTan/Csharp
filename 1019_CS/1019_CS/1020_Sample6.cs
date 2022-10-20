using System.Windows.Forms;
using System.Drawing;

class Sample6
{
    public static void Sample()
    {
        Form fm;
        fm = new Form();

        fm.Text = "샘플";

        PictureBox[] pb = new PictureBox[5];

        Label lb = new Label();
        lb.Width = fm.Width; lb.Height = fm.Height;

        for (int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Image = Image.FromFile("C:\\Users\\수완\\dog.bmp");
            pb[i].Top = i * pb[i].Height;
            pb[i].Parent = fm;
        }

        Application.Run(fm);
    }
}