using System.Windows.Forms;
using System.Drawing;

class Sample9
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250; fm.Height = 100;

        string[][] str = new string[4][] //가변 배열을 작성한다.
        {
            //각 배열의 요소 길이는 정해져 있지 않다.
            new string[] {"바나나","사과","체리"},
            new string[] {"원숭이","코끼리","강아지"},
            new string[] {"당근","감자","양파"},
            new string[] {"봄","여름","가을"}
        };

        string tmp = "";

        Label lb = new Label();
        lb.Width = fm.Width; lb.Height = fm.Height;

        for (int i = 0; i < str.Length; i++) //i개의 배열에 접근한다.
        {
            tmp += "(";
            for (int j = 0; j < str[j].Length; j++) //j개의 배열 요소에 접근한다.
            {
                tmp += str[i][j];
                tmp += ",";
            }
            tmp += ")\n";
        };

        lb.Text = tmp;
        lb.Parent = fm;

        Application.Run(fm);
    }
}