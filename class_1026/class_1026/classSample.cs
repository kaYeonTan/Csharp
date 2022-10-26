using System.Windows.Forms;
using System.Drawing;

class Car
{
    public Image img;
    public int top;
    public int left;
    public Car()
    {
        img = Image.FromFile("C:\\Users\\수완\\car.bmp");
        top = 0;
        left = 0;
    }
    public void Move()
    {
        top = top + 10;
        left = left + 10;
    }
}

class Sample1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();

        Car c = new Car();
        //메서드를 호출한다.
        c.Move();
        c.Move();
        //필드를 이용해 픽처박스를 설정한다.
        pb.Image = c.img;
        pb.Top = c.top;
        pb.Left = c.left;

        pb.Parent = fm;

        Application.Run(fm);
    }
}

