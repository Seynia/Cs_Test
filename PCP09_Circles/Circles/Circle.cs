using System;
using System.Drawing;

namespace Circles
{
    class Circle
    {
        private static Random rnd = new Random();
        public double xcen, ycen, radius;
        public int red, green, blue;
        private double xmov, ymov;

        // 생성자 - 주어진 위치에 랜덤 크기, 랜덤 색의 원 생성
        public Circle(double xcen, double ycen)
        {
            this.xcen = xcen;
            this.ycen = ycen;
            this.radius = rnd.Next(10) + 2;
            this.red = rnd.Next(200);
            this.green = rnd.Next(200);
            this.blue = rnd.Next(200);  // 너무밝지않게
            while (true) { this.xmov = rnd.Next(-3, 3); if (xmov != 0) break; }
            while (true) { this.ymov = rnd.Next(-3, 3); if (ymov != 0) break; }
        }

        // 움직임
        public void move(double xmin, double xmax, double ymin, double ymax)
        {
            if (xcen <= xmin + radius) xmov = Math.Abs(xmov);
            if (xcen >= xmax - radius) xmov = -Math.Abs(xmov);

            if (ycen <= ymin + radius) ymov = Math.Abs(ymov);
            if (ycen >= ymax - radius) ymov = -Math.Abs(ymov);

            xcen += xmov;
            ycen += ymov;
        }

        // 그리기
        public void draw(TCanvas canvas)
        {
            canvas.DrawEllipse(Color.FromArgb(this.red, this.green, this.blue),
            this.xcen, this.ycen, this.radius * 2, this.radius * 2);
        }

        // 주어진 점이 내부인지 판단
        public bool isinside(double xp, double yp)
        {
            double dx = xp - this.xcen;
            double dy = yp - this.ycen;
            double dist = Math.Sqrt(dx * dx + dy * dy);
            return (dist <= this.radius) ? true : false;
        }

        // Tcanvs에서 좌표와 사이즈를 바꿔서 그리기 때문에 이를 똑같이 계산해주기 위해서 pixelpos와 pixelsize 함수를 작성
        // 클래스에서 픽쳐박스 컨트롤을 들고올 수 없기 때문에 상수값으로 사용
        float Width = 600, Height = 600, xmax = 100, xmin = 0, ymax = 100, ymin = 0;
        private float xpixelpos(double xpos)
        {
            return Convert.ToSingle(Width / (xmax - xmin) * (xpos - xmin));
        }
        private float ypixelpos(double ypos)
        {
            return Convert.ToSingle(-Height / (ymax - ymin) * (ypos - ymin) + Height);
        }
        private float pixelsize(double xsize)
        {
            return Convert.ToSingle(Width * xsize / (xmax - xmin));
        }
        
        public bool isembedded(Circle cir)
        {
            // 인수로 받은 원의 중심이 this 원의 내부에 있고 인수로 받은 원의 반지름이 this 원의 반지름보다 작으면 검사
            if(isinside(cir.xcen, cir.ycen) && (cir.radius < this.radius))
            {
                double dx = xpixelpos(cir.xcen - 600 / 2) - xpixelpos(this.xcen - 600 / 2);
                double dy = ypixelpos(cir.ycen - 600 / 2) - ypixelpos(this.ycen - 600 / 2);
                // 두 원의 중심 사이의 거리
                double dist = Math.Sqrt(dx * dx + dy * dy);
                // 두 원의 반지름 차이 -> 외부 원의 내부에 정확히 있을 때 두 원의 중심이 떨어져 있을 수 있는 최대 거리
                double interval = (pixelsize(this.radius) - pixelsize(cir.radius)) * 2;
                // 두 원의 중심이 떨어져 있을 수 있는 최대 거리보다 두 원의 중심 사이의 거리가 작으면 내부로 판단
                return (dist < interval) ? true : false;
            }
            return false;
        }
    }
}
