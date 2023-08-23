using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StrikethroughIssue
{
    internal class SampleViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        internal void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region Properties
        public ICommand MyCommand { get; private set; }

        private int _count = 0;
        private bool _isChecked = false;
        private string _text = string.Empty;

        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged(nameof(TextDecoration));
            }
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                NotifyPropertyChanged();
            }
        }

        public TextDecorations TextDecoration => IsChecked ? TextDecorations.Strikethrough : TextDecorations.None;
        #endregion

        public SampleViewModel()
        {
            Text = "Ready...";
            MyCommand = new Command(() => { CountOne(); });
        }

        private void CountOne()
        {
            Count++;
            if (Count == 1)
                Text = $"Clicked {Count} time";
            else
                Text = $"Clicked {Count} times";
        }
    }
}
