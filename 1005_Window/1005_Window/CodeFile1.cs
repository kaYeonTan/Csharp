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
        pb.Left = 400;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Width = 170;
        lb.Text = "강아지 입니다";

        if (pb.Left >= 0 && pb.Left <= fm.Width)
            lb.Text = "강아지는 화면 안에 있습니다.";
        else
            lb.Text = "강아지는 화면 밖에 있습니다.";

        lb.Parent = fm;
        pb.Parent = fm;

        Application.Run(fm);
    }
}