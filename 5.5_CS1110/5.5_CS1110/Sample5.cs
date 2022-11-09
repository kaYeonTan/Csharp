using System.Windows.Forms;
using System.Drawing;

class Sample5 : Form //Form을 확장한 클래스로 한다.
{
    public static void Main()
    {
        //클래스로부터 오브젝트를 작성해서 윈도 프로그램을 실행한다.
        Application.Run(new Sample5());
    }
    public Sample5() //컨스트럭터(생성자)
    {
        this.Text = "샘플"; //상속죈 프로퍼티를 사용해 설정을 시행한다.
        this.Width = 400; this.Height = 200;
        this.BackgroundImage = Image.FromFile("C:\\Users\\수완\\car.bmp");
    }
}