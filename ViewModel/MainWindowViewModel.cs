using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp19.Model;

namespace WpfApp19.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double number1;
        public double Number1
        {
            get => number1;
            set
            {
                number1 = value;
                OnPropertyChanged();
            }
        }

        private double result1;
        public double Result1
        {
            get => result1;
            set
            {
                result1 = value;
                OnPropertyChanged();
            }
        }

        private double result2;
        public double Result2
        {
            get => result2;
            set
            {
                result2 = value;
                OnPropertyChanged();
            }
        }

        private double result3;
        public double Result3
        {
            get => result3;
            set
            {
                result3 = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand1 { get; }
        private void OnAddCommandExecute1(object p)
        {
            Result1 = Radius.Circumference(Number1);
            Result2 = Radius.Area(Number1);
            Result3 = Radius.SphereVolume(Number1);
        }
        
        public ICommand AddCommand2 { get; }
        private void OnAddCommandExecute2(object p)
        {
            Number1 = 0;
            Result1 = Radius.Circumference(Number1);
            Result2 = Radius.Area(Number1);
            Result3 = Radius.SphereVolume(Number1);
        }

        private bool CanAddCommandExecute(object p)
        {
            //if (Number1 != 0)
                return true;
            //else
            //    return false;
        }

        public MainWindowViewModel()
        {
            AddCommand1 = new RelayCommand(OnAddCommandExecute1, CanAddCommandExecute);
            AddCommand2 = new RelayCommand(OnAddCommandExecute2, CanAddCommandExecute);
        }
    }
}
