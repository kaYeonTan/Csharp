using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm; 
        fm = new Form();

        fm.Text = "샘플";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\Users\\수완\\dog.bmp");
        pb.Left = 0;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "강아지 입니다";

        if (pb.Left >= 150)     lb.Text = "강아지는 동쪽에 있습니다.";
        else if (pb.Left <= 20) lb.Text = "강아지는 서쪽에 있습니다.";
        else                    lb.Text = "강아지는 중앙에 있습니다.";

        lb.Parent = fm;
        pb.Parent = fm;

        Application.Run(fm);
    }
}