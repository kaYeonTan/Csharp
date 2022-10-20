using System.Windows.Forms;
using System.Drawing;

class Sample7
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250; fm.Height = 100;

        Label lb = new Label();
        lb.Width = fm.Width; lb.Height = fm.Height;

        string[] str = new string[3] { "연필", "지우기", "자" };

        foreach(var s in str) //foreach문으로 모든 배열 요소를 돌면서 꺼낸다
        {
            lb.Text += s + "\n";
        };

        lb.Parent = fm;

        Application.Run(fm);
    }
}