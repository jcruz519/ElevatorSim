using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSim.Models
{
    public class Floor : INotifyPropertyChanged
    {
        private bool _isCurrentFloor { get; set; }

        public Floor(bool isCurrentFloor)
        {

        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
