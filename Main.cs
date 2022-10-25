namespace GFX_1_Paint;

public enum Mode
{
    Pencil,
    Line,
    Triangle,
    Rect,
    Ellipse
}
public partial class Main : Form
{
    private List<Point> pathTmp_ = new(2);

    private Point MouseDownPoint;
    private Image Img;
    /// <summary> For use when drawing something. </summary>
    private Image ImgTmp;
    private SolidBrush Brush = new SolidBrush(Color.Black);
    private bool IsDrawing = false;
    private Mode CurrMode = Mode.Pencil;
    private float BrushSize = 1;

    public Main()
    {
        InitializeComponent();

        colorPanel.BackColor = Brush.Color;

        InitCanvas();
    }

    private void InitCanvas()
    {
        Img = new Bitmap(canvas.Width, canvas.Height);
        ImgTmp = (Image)Img.Clone();

        Graphics gfx = Graphics.FromImage(Img);
        SolidBrush brush = new(Color.White);
        gfx.FillRectangle(brush, 0, 0, width: Img.Width, height: Img.Height);
        canvas.Image = Img;
    }

    private void canvas_MouseDown(object sender, MouseEventArgs e)
    {
        MouseDownPoint = e.Location;
        using Graphics gfx = Graphics.FromImage(ImgTmp);
        using Pen pen = new Pen(Brush, BrushSize);

        switch (CurrMode)
        {
            case Mode.Pencil: lastFramePoint = MouseDownPoint; break;
            case Mode.Line: gfx.DrawLine(pen, MouseDownPoint, MouseDownPoint); break;
            case Mode.Rect: gfx.DrawLine(pen, MouseDownPoint, MouseDownPoint); break;
            case Mode.Ellipse: gfx.DrawLine(pen, MouseDownPoint, MouseDownPoint); break;
        }

        canvas.Image = ImgTmp;
        IsDrawing = true;
    }

    private Point lastFramePoint;
    private void canvas_MouseMove(object sender, MouseEventArgs e)
    {
        if (IsDrawing is false && CurrMode is not Mode.Triangle)
            return;

        Point point = e.Location;
        canvas.Image = Img;
        ImgTmp = (Image)Img.Clone();

        using Graphics gfx = Graphics.FromImage(ImgTmp);
        using Pen pen = new Pen(Brush, BrushSize);

        switch(CurrMode)
        {
            case Mode.Pencil:
                using (Graphics gfx2 = Graphics.FromImage(Img))
                {
                    gfx2.DrawLine(pen, lastFramePoint, point);
                    // For filling in gaps.
                    float half_ = BrushSize / 2;
                    gfx2.FillEllipse(Brush, point.X - half_, point.Y - half_, BrushSize, BrushSize);
                    lastFramePoint = point;
                }
                break;
            case Mode.Line:
                gfx.DrawLine(pen, MouseDownPoint, point); break;
            case Mode.Triangle:
                if (pathTmp_.Any())
                    gfx.DrawPolygon(pen, pathTmp_.Append(point).ToArray());
                break;
            case Mode.Rect:
                gfx.DrawRectangle(pen,
                        x: Math.Min(MouseDownPoint.X, point.X),
                        y: Math.Min(MouseDownPoint.Y, point.Y),
                        width: Math.Abs(point.X - MouseDownPoint.X),
                        height: Math.Abs(point.Y - MouseDownPoint.Y));
                break;
            case Mode.Ellipse: gfx.DrawEllipse(pen, MouseDownPoint.X, MouseDownPoint.Y, point.X - MouseDownPoint.X, point.Y - MouseDownPoint.Y); break;
        }

        canvas.Image = ImgTmp;
    }

    private void canvas_MouseUp(object sender, MouseEventArgs e)
    {
        IsDrawing = false;
        Point point = e.Location;
        canvas.Image = Img;
        ImgTmp = (Image)Img.Clone();

        using Graphics g = Graphics.FromImage(ImgTmp);
        using Pen pen = new Pen(Brush, BrushSize);

        switch(CurrMode)
        {
            case Mode.Line: g.DrawLine(pen, MouseDownPoint, point); break;
            case Mode.Triangle:
                pathTmp_.Add(point);
                if (pathTmp_.Count >= 3)
                {
                    g.DrawPolygon(pen, pathTmp_.ToArray());
                    pathTmp_.Clear();
                }
                break;
            case Mode.Rect:
                g.DrawRectangle(pen,
                        x: Math.Min(MouseDownPoint.X, point.X),
                        y: Math.Min(MouseDownPoint.Y, point.Y),
                        width: Math.Abs(point.X - MouseDownPoint.X),
                        height: Math.Abs(point.Y - MouseDownPoint.Y));
                break;
            case Mode.Ellipse: g.DrawEllipse(pen, MouseDownPoint.X, MouseDownPoint.Y, point.X - MouseDownPoint.X, point.Y - MouseDownPoint.Y); break;
        }

        canvas.Image = ImgTmp;
        Img = (Image)ImgTmp.Clone();
    }

    private void btnColorPicker_Click(object sender, EventArgs e)
    {
        ColorDialog MyDialog = new();
        MyDialog.AllowFullOpen = false;
        MyDialog.Color = Brush.Color;

        if (MyDialog.ShowDialog() is not DialogResult.OK)
            return;

        Brush = new SolidBrush(MyDialog.Color);
        colorPanel.BackColor = Brush.Color;
    }

    private void btnPencil_Click(object sender, EventArgs e) => CurrMode = Mode.Pencil;
    private void btnLine_Click(object sender, EventArgs e) => CurrMode = Mode.Line;
    private void btnTriangle_Click(object sender, EventArgs e) => CurrMode = Mode.Triangle;
    private void btnEllipse_Click(object sender, EventArgs e) => CurrMode = Mode.Ellipse;
    private void btnRect_Click(object sender, EventArgs e) => CurrMode = Mode.Rect;

    private void btnClear_Click(object sender, EventArgs e) => InitCanvas();

    private void tbSize_TextChanged(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(tbSize.Text))
            return;

        if (float.TryParse(tbSize.Text, out float size) is false)
            MessageBox.Show("Invalid size value!!");
        
        BrushSize = size;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void saveImage_Click(object sender, EventArgs e)
    {
        using SaveFileDialog saveFileDialog1 = new();
        saveFileDialog1.Filter = "Jpeg Image|*.jpg|PNG Image|*.png|GIF Image|*.gif";
        saveFileDialog1.Title = "Save an Image File";
        if (saveFileDialog1.ShowDialog() is not DialogResult.OK)
            return;

        using FileStream fileStream = (FileStream)saveFileDialog1.OpenFile();
        Img.Save(fileStream,
            saveFileDialog1.FilterIndex switch {
                1 => System.Drawing.Imaging.ImageFormat.Jpeg,
                2 => System.Drawing.Imaging.ImageFormat.Png,
                3 => System.Drawing.Imaging.ImageFormat.Gif,
            });
    }
}