using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flightfare
{
    internal class flight
    {
        public int Time;

      

        private int _fare;
        public int Fare
        {
            get { return _fare; }
            set
            {
                _fare = value;
                if (Time >= 6 && Time <= 9)
                {
                    _fare = _fare + ((_fare * 10) / 100);
                }
               else if (Time >= 9 && Time <= 17)
                {
                    _fare = _fare + ((_fare * 20) / 100);
                }
                else if (Time >= 17 && Time <= 23)
                {
                    _fare = _fare + ((_fare * 7) / 100);
                }
                else
                {
                    _fare = _fare + ((_fare * 5) / 100);
                }
               
            

            }

        }
    }
}

