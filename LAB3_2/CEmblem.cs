using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3_add
{
    class CEmblem
    {
        Color color { get; set; }
        public Color currentColor { get; set; }
        int size { get; set; }
        int x { get; set; }
        int y { get; set; }
        string name { get; set; }
        Pen pen = new Pen(Color.Red, 2);
        public CEmblem(int x, int y, int size, string name, Color color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.name = name;
            this.color = color;
            currentColor = color;
        }
        public override string ToString()
        {
            return name;
        }

        public void Draw(PictureBox pictureBox)
        {
            pen.Color = currentColor;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {

                Point[] points_for_square1 = new Point[4];
                points_for_square1[0].X = x + size - (size / 7); points_for_square1[0].Y = y + size /7 ;
                points_for_square1[1].X = x + size / 7; points_for_square1[1].Y = y + size / 7;
                points_for_square1[2].X = x + size / 7; points_for_square1[2].Y = y + size - (size / 7);
                points_for_square1[3].X = x + size - (size / 7); points_for_square1[3].Y = y + size - (size / 7);
                g.DrawPolygon(pen, points_for_square1);

                Point[] points_for_square2 = new Point[4];
                points_for_square2[0].X = x + size - (size / 2); points_for_square2[0].Y = y + size;
                points_for_square2[1].X = x + size; points_for_square2[1].Y = y + size / 2;
                points_for_square2[2].X = x + size / 2; points_for_square2[2].Y = y;
                points_for_square2[3].X = x + size / size; points_for_square2[3].Y = y + size / 2;
                g.DrawPolygon(pen, points_for_square2);

                pictureBox.Refresh();
            }

        }
        public void Right() { x++; }
        public void Left() { x--; }
        public void Up() { y--; }
        public void Down() { y++; }
        public void Full_Up() { y = 0; }
        public void Full_Down() { y = 450 - size; }
        public void Full_Left() { x = 0; }
        public void Full_Right() { x = 500 - size; }
        public void Plus() { size++; }
        public void Minus() { size--; }
        public void Hide() { currentColor = Color.White; }
        public void Show() { currentColor = color; }
    }
}
