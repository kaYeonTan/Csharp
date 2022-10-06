using System.Windows.Forms;
using System.Drawing;

class Practice
{
    public static void Main()
    {
        Form fm; //윈도(폼)에 붙이는 이름을 준비한다.  
        fm = new Form();

        fm.Text = "샘플!";

        Label lb = new Label();
        lb.Width = 300;
        lb.Text = "또 만납시다!";
        lb.Parent = fm;

        Application.Run(fm);
    }
}