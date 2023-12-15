using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using System.Runtime.CompilerServices;

namespace ElevatorSim.Models
{
    public sealed class Elevator : INotifyPropertyChanged
    {
        private static readonly object _lock = new object ();
        private static Elevator? _instanceOfElevator;

        public event PropertyChangedEventHandler? PropertyChanged;

        private int _numberOfFloors { get; set; }
        private int _currentFloor { get; set; }
        private Queue<Passenger> _passengers { get; set; }
        private StreamReader _textInput { get; set; }

        private Elevator()
        {
            _numberOfFloors = Int32.Parse(ConfigurationManager.AppSettings["FloorNumbers"]);
            _passengers = new Queue<Passenger>();
            _textInput = new StreamReader(ConfigurationManager.AppSettings["TextInputFile"]);
        }

        public static Elevator InitElevator
        {
            get
            {
                if(_instanceOfElevator == null)
                {
                    lock(_lock)
                    {
                        if (_instanceOfElevator == null) { _instanceOfElevator = new Elevator(); }
                    }
                }

                return _instanceOfElevator;
            }
        }

        public int NumberOfFloors
        {
            get { return _numberOfFloors; }
            //set { SetProperty(ref _numberOfFloors); }
        }

        private String test { get; set; }
        private bool isEmpty { get; set; }
        public bool IsEmpty
        {
            get { return isEmpty; }
            set
            {
                if(value != null)
                {
                    value = true;
                    OnPropertyChanged(nameof(IsEmpty));
                }
            }
        }
        public String Test
        {
            get { return test; }
            set 
            {
                if (test != value)
                {
                    test = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
