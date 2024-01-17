namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        private Rectangle rectangle = Rectangle.Empty;
        private int borderSize = new Random().Next(10, 200);
        public FormMain()
        {
            InitializeComponent();

            this.Size = new Size(800, 600);

            rectangle = new Rectangle(borderSize, borderSize, this.ClientSize.Width - 2 * borderSize, this.ClientSize.Height - 2 * borderSize);
        }

        private void onLoadPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.LightBlue, rectangle);
            e.Graphics.FillRectangle(Brushes.LightBlue, rectangle);
        }
        private void onMouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $" X: {Cursor.Position.X}; Y: {Cursor.Position.Y} ";
        }


        private void onMouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            var currentPosition = this.PointToClient(Cursor.Position);

            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys.HasFlag(Keys.Control))
                    this.Close();
                else
                {
                    if (rectangle.Contains(currentPosition))
                        MessageBox.Show("Mouse is inside the rectangle");
                    else if (IsOnRectangleBorder(currentPosition))
                        MessageBox.Show("Mouse is on the border");
                    else
                        MessageBox.Show("Mouse is outside of rect");
                }
            } else if(e.Button == MouseButtons.Right) 
            {
                MessageBox.Show($"Control Size:\nWidth {ClientSize.Width}; Height {ClientSize.Height}");
            } else
            {
                this.Close();
            }
        }

        private bool IsOnRectangleBorder(Point point)
        {
            int borderSize = 10;
            return point.X >= rectangle.Left - borderSize && point.X <= rectangle.Right + borderSize &&
                   point.Y >= rectangle.Top - borderSize && point.Y <= rectangle.Bottom + borderSize &&
                   (point.X < rectangle.Left || point.X > rectangle.Right || point.Y < rectangle.Top || point.Y > rectangle.Bottom);
        }
    }
}
