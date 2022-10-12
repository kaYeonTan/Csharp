using System.Windows.Forms;
using System.Drawing;

class Sample2
{
    public static void Main()
    {
        Form fm; //윈도(폼)에 붙이는 이름을 준비한다.  
        fm = new Form();

        fm.Text = "어서오세요 C#으로!";

        //Label lb = new Label(); //라벨을 작성한다.
        //lb.Width = 300;         //라벨의 가로 크기를 설정한다.

        //lb.Text = "C#을 시작합시다 (❁´◡`❁)"; //라벨을 폼에 올린다.
        //lb.Parent = fm;               //라벨의 타이틀을 실행한다.

        int w;  //변수를 선언한다.
        w = 100;//변수에 값을 대입한다.

        PictureBox pb = new PictureBox(); //이미지를 읽어 들이는 픽쳐박스를 작성한다. 
        pb.Image = Image.FromFile("C:\\Users\\수완\\dog.bmp"); //이미지를 읽어들인다.
        pb.Top = (fm.ClientSize.Height - pb.Height) / 2;
        pb.Left = (fm.ClientSize.Width - pb.Width) / 2;

        pb.Parent = fm;

        Application.Run(fm);
    }
}