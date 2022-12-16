You can try overriding the OnPaint method of your form:


[![draw rectangle][1]][1]

This code should do the trick:

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

It's also recommended to wrap it with a `using` block to ensure that the `Pen` resource will be properly disposed of when you are finished drawing.

  [1]: https://i.stack.imgur.com/4zEGX.png