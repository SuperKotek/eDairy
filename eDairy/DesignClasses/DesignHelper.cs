using eDairy.FunctionalClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDairy.DesignClasses
{
    public class DesignHelper
    {
        // Изначально: Grid - 852; 426 , Форма - 894; 516
        public static void DataGridPanelCloseFix(int width, int height, DataGridView grid, bool searchpnl)
        {
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            grid.Width = width - 42;
            if (searchpnl) { grid.Height = height - 130; }
            else { grid.Height = height - 80; }
            grid.Columns[1].Width = grid.Width;
        }

        public static void DataGridPanelOpenFix(int width, int height, DataGridView grid, Panel panel, bool searchpnl)
        {
            grid.Anchor = AnchorStyles.Top;
            grid.Width = width / 2 - 21;
            if (searchpnl) { grid.Height = height - 130; }
            else { grid.Height = height - 80; }
            grid.Columns[1].Width = grid.Width;
            panel.Width = width / 2 - 27;
            if (searchpnl) { panel.Height = height - 130; }
            else { panel.Height = height - 80; }
        }

        public static void SearchPanelCloseFix(int width, int height, DataGridView grid, Panel panel, Panel searchpanel)
        {
            searchpanel.Visible = false;
            panel.Height = height - 80;
            grid.Height = height - 80;
        }

        public static void SearchPanelOpenFix(int width, int height, DataGridView grid, Panel panel, Panel searchpanel)
        {
            panel.Height = height - 130;
            grid.Height = height - 130;
            searchpanel.Visible = true;
        }

        public static void TextBoxFix(int width, int height, TextBox textbox)
        {
            textbox.Anchor = AnchorStyles.Top;
            textbox.Width = width / 2 - 21;
            textbox.Height = height - 80;
        }
    }
}
