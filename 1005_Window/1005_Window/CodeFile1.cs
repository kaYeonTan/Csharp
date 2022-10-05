using System.Windows.Forms;

class Sample2
{
    public static void Main()
    {
        Form fm; //윈도(폼)에 붙이는 이름을 준비한다.  
        fm = new Form();

        fm.Text = "어서오세요 C#으로!";

        Application.Run(fm);
    }
}