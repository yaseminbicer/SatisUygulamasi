using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HizliSatis.UI.Extra
{
    public class SideBar : Panel
    {
        public Color gradientTop { get; set; }
        public Color gradientButtom { get; set; }
        public Color gradientRight {  get; set; }
        

      

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle,this.gradientTop, this.gradientButtom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(linear, e.ClipRectangle);

           
            base.OnPaint(e);

        }
    } 
}
