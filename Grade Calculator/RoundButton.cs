using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class RoundButton : Button
{

    public RoundButton()
    {

    }
    /// <summary>
    /// Contructor with parametre
    /// </summary>
    /// <param name="image">Button's background image</param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public RoundButton(Bitmap image, int width, int height)
    {
        this.BackgroundImageLayout = ImageLayout.Stretch;
        this.BackgroundImage = image;
        this.Size = new Size(width, height);
    }
    protected override void OnResize(EventArgs e)
    {
        using (var path = new GraphicsPath())
        {
            path.AddEllipse(new Rectangle(2, 2, this.Width - 5, this.Height - 5));
            this.Region = new Region(path);
        }
        base.OnResize(e);
    }

    public void setImage(Bitmap image)
    {
        this.BackgroundImageLayout = ImageLayout.Stretch;
        this.BackgroundImage = image;
    }

    public void setSize(int width, int height)
    {
        this.Size = new Size(width, height);
    }
}
