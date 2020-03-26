using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfBindingExample
{
    class CarViewModel : INotifyPropertyChanged

    {
        private Car _selectedCar;
        public ObservableCollection<Car> Cars { get; private set; }
        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                OnPropertyChanged("SelectedCar");
            }
        }
        public CarViewModel()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car { Model="ВАЗ-2105", MaxSpeed=150, Price=56000, ImagePath="/Images/lada_2105.jpg" },
                new Car { Model="LADA Priora", MaxSpeed=170, Price=560000, ImagePath="/Images/Lada-Priora.jpg" },
                new Car { Model="КамАЗ", MaxSpeed=100, Price=5600000, ImagePath="/Images/kamaz.jpg" }
            };
        }
        public void AddCar()
        {
            Car car = new Car();
            Cars.Insert(0, car);
            SelectedCar = car;
        }
        public void DeleteCar()
        {
            if (_selectedCar != null)
            {
                Cars.Remove(SelectedCar);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
