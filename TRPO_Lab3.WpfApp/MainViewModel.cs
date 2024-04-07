using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.WpfApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private CircleSegmentModel _circleSegment;
        private double _radiu5;
        private double _angle;

        public CircleSegmentModel CircleSegment
        {
            get { return _circleSegment; }
            set
            {
                _circleSegment = value;
                OnPropertyChanged(nameof(CircleSegment));
            }
        }
        public MainViewModel()
        {
            CircleSegment = new CircleSegmentModel();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public double radiu5
        {
            get { return _radiu5; }
            set
            {
                _radiu5 = value;
                OnPropertyChanged(nameof(radiu5));
                OnPropertyChanged(nameof(Area));
            }
        }
        public double angle
        {
            get { return _angle; }
            set
            {
                _angle = value;
                OnPropertyChanged(nameof(angle));
                OnPropertyChanged(nameof(Area));
            }
        }

        public double Area
        {
            get
            {
                try
                {
                    return TRPO_Lab3.Lib.Class1.CircleSegment(radiu5, angle);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}
