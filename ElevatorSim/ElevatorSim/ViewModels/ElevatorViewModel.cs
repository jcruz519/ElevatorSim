using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using ElevatorSim.Models;
using log4net.Repository.Hierarchy;
using static System.Net.Mime.MediaTypeNames;

namespace ElevatorSim.ViewModels
{
    public class ElevatorViewModel : IElevatorViewModel, INotifyPropertyChanged
    {
        private static readonly object _lock = new object();
        private static ElevatorViewModel? _instanceOfElevator;

        public event PropertyChangedEventHandler? PropertyChanged;

        private int _numberOfFloors { get; set; }
        private int _currentFloor { get; set; }
        private Queue<Passenger> _passengers { get; set; }
        private StreamReader _textInput { get; set; }
        private List<bool> _activeFloor { get; set; }

        private ElevatorViewModel()
        {
            _numberOfFloors = Int32.Parse(ConfigurationManager.AppSettings["FloorNumbers"]);
            _passengers = new Queue<Passenger>();
            _textInput = new StreamReader(ConfigurationManager.AppSettings["TextInputFile"]);
            _activeFloor = new List<bool> { false, false, false, false, false };

            StartSim = new DelegateCommand(Go);
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static ElevatorViewModel InitElevator
        {
            get
            {
                if (_instanceOfElevator == null)
                {
                    lock (_lock)
                    {
                        if (_instanceOfElevator == null) { _instanceOfElevator = new ElevatorViewModel(); }
                    }
                }

                return _instanceOfElevator;
            }
        }

        public int NumberOfFloors
        {
            get { return _numberOfFloors; }
            set 
            {
                if (_numberOfFloors != value)
                {
                    _numberOfFloors = value;
                    OnPropertyChanged();
                }
            }
        }

        public int CurrentFloor
        {
            get { return _currentFloor; }
            set
            {
                if (_currentFloor != value)
                {
                    _currentFloor = value;
                    OnPropertyChanged();
                }
            }
        }

        public List<bool> ActiveFloor
        {
            get { return _activeFloor; }
            set
            {
                if (_activeFloor != value)
                {
                    _activeFloor = value;
                    OnPropertyChanged();
                }
            }
        }

        public DelegateCommand StartSim { get; private set; }
        
        public async void Go()
        {
            TextFileInputReader inputStream = new TextFileInputReader();
            List<int> floorTracker = inputStream.ReadInputFromFile(_textInput);
            int indexOfActiveFloor = floorTracker[0];
            ActiveFloor[indexOfActiveFloor] = true;
            CurrentFloor = floorTracker[0];

            for(int i = 0; i < floorTracker.Count - 1; i++)
            {
                _passengers.Enqueue(new Passenger(floorTracker[i], floorTracker[i + 1]));
            }

            foreach(Passenger passenger in _passengers)
            {
                if(passenger.FloorDestination > CurrentFloor)
                {
                    while (CurrentFloor != passenger.FloorDestination)
                    {
                        await Task.Delay(Int32.Parse(ConfigurationManager.AppSettings["TimeDelay"]));
                        CurrentFloor++;
                        passenger.CurrentFloor++;
                        ActiveFloor[indexOfActiveFloor] = false;
                        ActiveFloor[++indexOfActiveFloor] = true;
                    }
                }
                else
                {
                    while (CurrentFloor != passenger.FloorDestination)
                    {
                        await Task.Delay(Int32.Parse(ConfigurationManager.AppSettings["TimeDelay"]));
                        CurrentFloor--;
                        passenger.CurrentFloor--;
                        ActiveFloor[indexOfActiveFloor] = false;
                        ActiveFloor[--indexOfActiveFloor] = true;
                    }
                }
            }
        }
    }
}
