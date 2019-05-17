using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final;
using System.Drawing;
using System.Windows.Forms;
using QuanLyRapPhim_Final.User_Controls;
using QuanLyRapPhim_Final.BSLayer;
using System.Data;


namespace QuanLyRapPhim_Final.renderSeat
{
    class render
    {
        public List<Button> btns;
        private char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private int row;
        private int col;
        private Point p;
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }
        public render()
        {

        }
        public render(int r, int c)
        {
            this.row = r;
            this.col = c;
        }

        public void drawTable(Graphics gp)
        {
            Program.myColor = Color.Red;
            Program.myPen = new Pen(Program.myColor, 2);
            CellTable cell = null;
            if (Program.hangGhe != 0 && Program.soGhe != 0)
            {
                cell = new CellTable(Program.hangGhe, Program.soGhe);
            }
            else
            {
                cell = new CellTable();
            }

            for (int i = 0; i <= cell.LineCol + 1; i++)   //bỏ 1 cột ở row-2 nên +1 vào cột
            {
                gp.DrawLine(Program.myPen, i * cell.CellWidth, 0, i * cell.CellWidth, (cell.LineRow) * cell.CellHeight);

            }

            for (int j = 0; j <= cell.LineRow; j++)
            {
                gp.DrawLine(Program.myPen, 0, j * cell.CellHeight, (cell.LineCol - 2) * cell.CellWidth, j * cell.CellHeight);
                gp.DrawLine(Program.myPen, (cell.LineCol - 1) * cell.CellWidth, j * cell.CellHeight, (cell.LineCol + 1) * cell.CellWidth, j * cell.CellHeight);

            }

        }

        public void renderSeat(ref Panel panel, List<string> dayAlpha, List<string> daySo)
        {
            ButtonObject obj = new ButtonObject();
            CellTable cell = new CellTable();
            btns = new List<Button>();
            string alphaChar;
            for (int i = 0; i < Program.hangGhe; i++)
            {
                for (int j = 0; j < Program.soGhe; j++)
                {
                    alphaChar = alpha[i].ToString().Trim();
                    Button btn = new Button();
                    p = cell.findCell(i, j);
                    p.X++;
                    p.Y++;
                    if (j >= Program.soGhe - 2)
                    {
                        p.X = p.X + cell.CellWidth;

                        btn = obj.CreateButton(ref btn, $"{alphaChar}-{j}", p);


                    }
                    else
                    {
                        btn = obj.CreateButton(ref btn, $"{alphaChar}-{j}", p);

                    }
                    //so sánh
                    for (int k = 0; k < dayAlpha.Count(); k++)
                    {
                        if (dayAlpha[k] == alphaChar) //xét chữ đầu
                        {
                            //xét số
                            if (Convert.ToInt64(daySo[k]) == j)
                            {
                                //todo: disable nút
                                btn.Enabled = false;
                                btn.Text = "X";
                                btn.BackColor = Color.Red;

                            }
                        }
                    }

                    btns.Add(btn);

                }
            }
            panel.Controls.AddRange(btns.ToArray());

        }


        public void removeSeat(ref Panel panel)
        {
            //btns.Clear();
            panel.Controls.Clear();
        }

        public class CellTable
        {

            public CellTable()
            {

            }
            public CellTable(int soHang, int soGhe)
            {
                lineRow = soHang;
                lineCol = soGhe;
            }
            private int cellWidth = 40;
            private int cellHeight = 30;
            private int lineCol = 15;   //số ô cột
            private int lineRow = 5;    //số ô hàng
            public int CellWidth { get => cellWidth; set => cellWidth = value; }
            public int CellHeight { get => cellHeight; set => cellHeight = value; }
            public int LineCol { get => lineCol; set => lineCol = value; }
            public int LineRow { get => lineRow; set => lineRow = value; }
            public Point findCell(int Row, int Col)
            {
                Point point = new Point(Col * CellWidth, Row * CellHeight);
                return point;
            }
        }


    }

}