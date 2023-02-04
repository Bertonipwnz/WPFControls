using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace ControlsLibrary.Controls
{
    /// <summary>
    /// Представляет пользовательский элемент текста.
    /// </summary>
    public partial class TextControl : UserControl
    {
        #region Private Fields

        /// <summary>
        /// Это смена размера?.
        /// </summary>
        private bool _isResize;

        #endregion Private Fields

        #region Public Constructor

        /// <summary>
        /// Инициализирует <see cref="TextControl"/>
        /// </summary>
        public TextControl()
        {
            InitializeComponent();
        }

        #endregion Public Constructor

        #region Private Methods

        /// <summary>
        /// Обрабатывает событие отпускания мыши на квадрате смены размера.
        /// </summary>
        private void ResizeRectangleMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => _isResize = true;

        /// <summary>
        /// Обрабатывае событие нажатия мыши на квадрате смены размера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResizeRectangleMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isResize = false;
            Rectangle rect = (Rectangle)sender;
            rect.ReleaseMouseCapture();
        }

        /// <summary>
        /// Обрабатывает событие движение мыши при зажатом квадрате смены размера.
        /// </summary>
        private void ResizeRectangleMouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            if (_isResize)
            {
                rect.CaptureMouse();
                double newWidth = e.GetPosition(this).X + 5;
                double newHeight = e.GetPosition(this).Y + 5;

                if (newWidth > 0)
                {
                    CurrentTextControl.Width = newWidth;
                    CurrentTextControl.Height = newHeight;
                }
            }
        }

        #endregion Private Methods
    }
}
