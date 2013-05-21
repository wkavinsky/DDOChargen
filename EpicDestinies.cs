using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDO_Character_Generator
{
    public partial class EpicDestinies : Form
    {
        public EpicDestinies()
        {
            InitializeComponent();
        }

        private void tabDestinies_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void tabcontrolDestinies_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _TextBrush;

            // Get the item from the collection.
            TabPage _TabPage = tabcontrolDestinies.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _TabBounds = tabcontrolDestinies.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _TextBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Black, e.Bounds);
            }
            else
            {
                _TextBrush = new System.Drawing.SolidBrush(Color.Black);
                e.DrawBackground();
            }

            // Use Application Font
            Font _TabFont = e.Font;

            // Draw string. Center the text.
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_TabPage.Text, _TabFont, _TextBrush,
                        _TabBounds, new StringFormat(_StringFlags));
        }
    }
}
