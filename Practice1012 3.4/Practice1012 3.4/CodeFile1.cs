using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();

        fm.Text = "샘플";
        fm.Width = 300;
        fm.Height = 200;

        Label lb = new Label();
        lb.Text = "안녕하세요";
        lb.Top = (fm.ClientSize.Height - lb.Height) / 2;
        lb.Left = (fm.ClientSize.Width - lb.Width) / 2;
        lb.Parent = fm;

        Application.Run(fm);
    }
}