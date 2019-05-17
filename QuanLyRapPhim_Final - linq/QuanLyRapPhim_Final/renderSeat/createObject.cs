using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.User_Controls;
using System.Windows.Forms;
using System.Drawing;
using QuanLyRapPhim_Final.renderSeat;

namespace QuanLyRapPhim_Final.renderSeat
{
    class ButtonObject
    {
        render.CellTable cell = new render.CellTable();
        public Button CreateButton (ref Button btn,string name,Point p)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatVeUC));
            //btn = new Button();
            btn.Location = new Point(p.X, p.Y);
            btn.Name = "button1";
            btn.Size = new Size(cell.CellWidth, cell.CellHeight);
            btn.TabIndex = 0;
            btn.Text = name;
            btn.UseVisualStyleBackColor = true;
            return btn;
        }


    }
}
