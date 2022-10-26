﻿using System.Windows.Forms;
using System.Drawing;

class Car
{
    private Image img;
    private int top;
    private int left;

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
    public void SetImage(Image i)
    {
        img = i;
    }
    public Image GetImage()
    {
        return img;
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

class Sample2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();

        Car c = new Car();
        c.Move();
        c.Move();
        pb.Image = c.GetImage(); //public한 메서드를 통해서 필드에 접근한다.
        pb.Top = c.Top;
        pb.Left = c.Left;

        pb.Parent = fm;

        Application.Run(fm);
    }
}

