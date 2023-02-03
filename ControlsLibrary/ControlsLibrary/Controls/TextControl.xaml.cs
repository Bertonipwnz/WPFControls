using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ControlsLibrary.Controls
{
    /// <summary>
    /// Представляет пользовательский элемент текста.
    /// </summary>
    public partial class TextControl : UserControl
    {
        public struct MN
        {
            public ContentControl sContent;
            public Rectangle sRect;
            public Point sStart;
            public Point sEnd;
        }

        private ContentControl _content;

        private Point startPoint;

        private Point tempStart;
        private Point tempEnd;
        private ContentControl _tempcontent;
        MN[] arrayMN = new MN[1];

        #region Public Constructor

        /// <summary>
        /// Инициализирует <see cref="TextControl"/>
        /// </summary>
        public TextControl()
        {
            InitializeComponent();
        }

        #endregion Public Constructor


        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //khoi tao gia tri
            startPoint = e.GetPosition(canvas);

            tempStart = startPoint;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point EndPoint = e.GetPosition(canvas);

            if (e.LeftButton == MouseButtonState.Released || CurrentTextElement == null)
                return;
            var x = Math.Min(EndPoint.X, startPoint.X);
            var y = Math.Min(EndPoint.Y, startPoint.Y);

            var w = Math.Max(EndPoint.X, startPoint.X) - x;
            var h = Math.Max(EndPoint.Y, startPoint.Y) - y;

            CurrentTextElement.Width = w;
            CurrentTextElement.Height = h;
            Canvas.SetLeft(CurrentTextElement, x);
            Canvas.SetTop(CurrentTextElement, y);
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //luu hinh anh sau khi ve
            //ImageSource imagesource = ConvertToBitmapSource(canvas);
            //arrayImage.Push(imagesource);

            tempEnd = e.GetPosition(canvas);

            _tempcontent = new ContentControl();

            //xoa previous shape
            canvas.Children.RemoveRange(canvas.Children.Count - 1, canvas.Children.Count);

            //newrect.StrokeThickness = int.Parse("0");
            //newrect.Stroke = (Brush)bc.ConvertFrom(color);
            if (true)
            {
                //newrect.Fill = (Brush)bc.ConvertFrom(color);
            }
            CurrentTextElement.IsHitTestVisible = false;

            _content = new ContentControl();
            arrayMN[0].sContent = _content;
            _content.Content = CurrentTextElement;

            arrayMN[0].sStart = tempStart;
            arrayMN[0].sEnd = tempEnd;

            var x = Math.Min(tempEnd.X, tempStart.X);
            var y = Math.Min(tempEnd.Y, tempStart.Y);

            var w = Math.Max(tempEnd.X, tempStart.X) - x;
            var h = Math.Max(tempEnd.Y, tempStart.Y) - y;

            _content.Width = w;
            _content.Height = h;

            _content.MinWidth = 0;
            _content.MinHeight = 0;

            Canvas.SetLeft(_content, x);
            Canvas.SetTop(_content, y);
            _content.SetValue(Selector.IsSelectedProperty, true);
            _content.Style = (Style)FindResource("DesignerItemStyle");

            _tempcontent = _content;

            canvas.Children.Add(_content);

        }
    }

}
