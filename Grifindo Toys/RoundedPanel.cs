using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    private int cornerRadius = 10;

    public int CornerRadius
    {
        get { return cornerRadius; }
        set { cornerRadius = value; Invalidate(); } // Redraw the panel if the radius changes
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Create a GraphicsPath object for rounded corners
        GraphicsPath path = new GraphicsPath();
        Rectangle rect = new Rectangle(0, 0, Width, Height);
        path.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90);
        path.AddArc(rect.X + Width - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90);
        path.AddArc(rect.X + Width - CornerRadius, rect.Y + Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
        path.AddArc(rect.X, rect.Y + Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
        path.CloseFigure();

        // Set the region to the path to clip the panel to rounded corners
        this.Region = new Region(path);

        // Set up the Graphics object
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Use the new fill color (37, 42, 64)
        Color fillColor = Color.FromArgb(37, 42, 64);
        e.Graphics.FillPath(new SolidBrush(fillColor), path);

        //// Optionally, draw a border around the panel
        //e.Graphics.DrawPath(Pens.Black, path);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate(); // Redraw the panel when it's resized
    }
}