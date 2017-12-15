using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.CustomControl
{
    class PButton : Button
    {
        public int TableID { get; set; }
        public Order Order  { get; set; }

        public PButton()
        {
            this.Size = new Size(100, 100);
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.BackgroundImage = QLCF.Properties.Resources.TableOrdering;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.Font = new Font(this.Font.FontFamily, 14);
        }
    }
}
