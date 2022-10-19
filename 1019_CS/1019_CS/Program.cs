using System.Windows.Forms;
using System.Drawing;

class Sample5
{
    public static void Main()
    {
        Form fm;
        fm = new Form();

        fm.Text = "샘플";
        fm.Width = 300; fm.Height = 150;

        Label lb = new Label();
        lb.Width = fm.Width; lb.Height = fm.Height;

        for (int i = 0; i < 5; i++)
        {
            lb.Text += i + "번의 강아지를 표시합니다.\n";
        };

        lb.Parent = fm;

        Application.Run(fm);
    }
}