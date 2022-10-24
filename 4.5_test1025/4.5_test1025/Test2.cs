using System.Windows.Forms;
using System.Drawing;

public class Test2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 600; fm.Height = 300;

        PictureBox[,] dog = new PictureBox[5,5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                dog[i,j] = new PictureBox();
                dog[i, j].Image = Image.FromFile("C:\\Users\\수완\\dog.bmp");
                dog[i, j].Left = dog[i, j].Width * i;
                dog[i, j].Top = j * dog[i, j].Height;
                dog[i, j].Parent = fm;
            }
        }

        Application.Run(fm);
    }
}
