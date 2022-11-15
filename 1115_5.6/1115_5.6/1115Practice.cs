using System.Windows.Forms;
using System.Drawing;

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250; fm.Height = 100;

        Label lb = new Label();

        Ball bl = new Ball();
        bl.Move();

        lb.Text = "공의 위치는 \nTop:" + bl.Top + "Left:" + bl.Left + "입니다.";
        lb.Parent = fm;

        Application.Run(fm);
    }

}
class Ball
{
    int top;
    int left;

    public Ball()
    {
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
    public int Top
    {
        set { top = value; }
        get { return top; }
    }
    public int Left
    {
        set { left = value; }
        get { return left; }
    }
}
