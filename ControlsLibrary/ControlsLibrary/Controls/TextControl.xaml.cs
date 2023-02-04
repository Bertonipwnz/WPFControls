using System;
using System.Windows;
using System.Windows.Controls;
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
        #region Private Fields

        /// <summary>
        /// Это смена размера?
        /// </summary>
        private bool _isResize;

        /// <summary>
        /// Это поворот контрола?
        /// </summary>
        private bool _isRotate;

        /// <summary>
        /// Это перемещение?
        /// </summary>
        private bool _isMoving;

        /// <summary>
        /// Точка стартовой позиции.
        /// </summary>
        private Point _startPosition;

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
        private void ResizeRectangleMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isResize = false;
            Image rect = (Image)sender;
            rect.ReleaseMouseCapture();
        }

        /// <summary>
        /// Обрабатывает событие движение мыши при зажатом квадрате смены размера.
        /// </summary>
        private void ResizeRectangleMouseMove(object sender, MouseEventArgs e)
        {
            Image rect = (Image)sender;
            if (_isResize)
            {
                rect.CaptureMouse();
                double newWidth = e.GetPosition(this).X;
                double newHeight = e.GetPosition(this).Y;

                if (newWidth > 0)
                {
                    CurrentTextControl.Width = newWidth;
                    CurrentTextControl.Height = newHeight;
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие отпускания мыши на квадрате смены размера.
        /// </summary>
        private void RotateRectangleMouseLeftButtonDown(object sender, MouseButtonEventArgs e) => _isRotate = true;

        /// <summary>
        /// Обрабатывае событие нажатия мыши на квадрате смены размера.
        /// </summary>
        private void RotateRectangleMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isRotate = false;
            Image rect = (Image)sender;
            rect.ReleaseMouseCapture();
        }

        /// <summary>
        /// Обрабатывает событие движение мыши при зажатом квадрате смены размера.
        /// </summary>
        private void RotateRectangleMouseMove(object sender, MouseEventArgs e)
        {
            Image rect = (Image)sender;
            if (_isRotate)
            {
                rect.CaptureMouse();

                double centerX = CurrentTextControl.ActualWidth / 2;
                double centerY = CurrentTextControl.ActualHeight / 2;

                Point p = e.GetPosition(this);

                double rad = Math.Atan2(p.Y - centerY, p.X - centerX);

                int degress = (int)(rad * 180 * Math.PI);
                CurrentTextControl.SetValue(Canvas.LeftProperty, centerX);
                CurrentTextControl.SetValue(Canvas.TopProperty, centerY);

                RotateTransform newRotateTransform = new RotateTransform(degress, CurrentTextControl.ActualWidth / 2, CurrentTextControl.ActualHeight / 2);

                rotateTransform.Angle = newRotateTransform.Angle;
                rotateTransform.CenterX = CurrentTextControl.ActualWidth / 2;
                rotateTransform.CenterY = CurrentTextControl.ActualHeight / 2;
            }
        }

        /// <summary>
        /// Обрабатывает событие отпускания мыши на квадрате перемещения.
        /// </summary>
        private void TranslateRectangleMouseLeftButtonDown(object sender, MouseButtonEventArgs e) 
        {
            _startPosition = Mouse.GetPosition(this);
            _isMoving = true;
        }

        /// <summary>
        /// Обрабатывае событие нажатия мыши на квадрате перемещения.
        /// </summary>
        private void TranslateRectangleMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isMoving = false;
            Rectangle rect = (Rectangle)sender;
            rect.ReleaseMouseCapture();
        }

        /// <summary>
        /// Обрабатывает событие движение мыши при зажатом квадрате перемещения.
        /// </summary>
        private void TranslateRectangleMouseMove(object sender, MouseEventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            if (_isMoving)
            {
                // get the parent container
                var container = VisualTreeHelper.GetParent(this) as UIElement;

                if (container == null)
                    return;

                // get the position within the container
                var mousePosition = e.GetPosition(container);

                // move the usercontrol.
                this.RenderTransform = new TranslateTransform(mousePosition.X - _startPosition.X, mousePosition.Y - _startPosition.Y);
            }
        }

        #endregion Private Methods
    }
}
