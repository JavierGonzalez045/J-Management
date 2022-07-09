﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Presentation.Forms.Assets.CustomDropdownMenu;
using System.Drawing.Drawing2D;

namespace Presentation.Forms.Assets.CustomMenuColorTable
{
    public class JMMenuRenderer : ToolStripProfessionalRenderer
    {
        //Fields
        private Color primaryColor;
        private Color textColor;
        private int arrowThickness;

        // Constructor
        public JMMenuRenderer(bool isMainMenu, Color primaryColor, Color textColor)
            : base(new JMCustomMenuColorTable(isMainMenu, primaryColor))
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            if (isMainMenu) arrowThickness = 3;
            else arrowThickness = 2;
        }

        //Overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : textColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //Fields
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height-arrowSize.Height)/2,
                arrowSize.Width,arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                //Drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}