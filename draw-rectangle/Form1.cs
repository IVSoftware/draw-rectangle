namespace draw_rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.Red))
            {
                Rectangle rect = new Rectangle(0, 0, 100, 100);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}