﻿using System.Windows.Forms;
using System.Drawing;

class Car
{
    public static int count = 0;    //정적 필드의 정의
    private Image img;
    private int top;
    private int left;

    public Car()
    {
        count++;
        img = Image.FromFile("C:\\Users\\수완\\car.bmp");
        top = 0;
        left = 0;
    }
    public static string CountCar()
    {
        return "자동차는" + count + "대 있습니다.";
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

class Sample3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "샘플";
        fm.Width = 250; fm.Height = 100;

        Label lb = new Label();

        Car c1 = new Car();
        Car c2 = new Car();

        lb.Width = 170;
        lb.Text = Car.CountCar();   //정적 메서드 호출

        lb.Parent = fm;

        Application.Run(fm);
    }
}