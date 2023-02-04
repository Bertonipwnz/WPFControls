namespace ControlsLibrary.Models
{
    /// <summary>
    /// Представляет модель текста.
    /// </summary>
    public class TextModel
    {
        /// <summary>
        /// Угол поворота текста.
        /// </summary>
        public double Angle { get; set; }

        /// <summary>
        /// Ширина текста.
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Высота текста.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Отступ сверху.
        /// </summary>
        public double Top { get; set; }
        
        /// <summary>
        /// Отступ слева.
        /// </summary>
        public double Left { get; set; }

        /// <summary>
        /// Содержимое текста.
        /// </summary>
        public string Text { get; set; }
    }
}
