using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSharp_BaseDados
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 30;

        
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            AplicarBordaArredondada();
        }

        private void AplicarBordaArredondada()
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
