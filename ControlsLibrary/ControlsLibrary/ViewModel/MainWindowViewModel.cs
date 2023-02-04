using CommunityToolkit.Mvvm.ComponentModel;
using ControlsLibrary.Models;

namespace ControlsLibrary.ViewModel
{

    /// <summary>
    /// Представляет viewmodel для главного окна.
    /// </summary>
    public class MainWindowViewModel : ObservableObject
    {
        #region Private Methods

        /// <summary>
        /// Представляет экземпляр модели текста.
        /// </summary>
        private TextModel _textModel;

        #endregion Private Methods

        #region Public Properties

        /// <summary>
        /// <inheritdoc cref="_textModel"/>
        /// </summary>
        public TextModel TextModel
        {
            get { return _textModel; }
            set => SetProperty(ref _textModel, value);
        }

        #endregion Public Properties

        #region Public Constructor

        /// <summary>
        /// Инициалиизирует <see cref="MainWindowViewModel"/>
        /// </summary>
        public MainWindowViewModel()
        {
            TextModel = new TextModel();
            TextModel.Width = 200;
            TextModel.Height = 150;
            TextModel.Angle = 50;
            TextModel.Top = 0;
            TextModel.Left = 0;
            TextModel.Text = "test";
        }

        #endregion Public Constructor
    }
}
