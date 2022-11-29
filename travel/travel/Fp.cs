using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel
{
    internal class Fp
    {
        public string name { get; set; }
        public int Miles { get; set; }
        private int _points;

        public int Points
        {
            get
            { return _points; }
            set
            {
                _points = value;
                if (Miles >= 10000 && Miles < 20000)
                {
                    _points = 10;
                }

                else if (Miles >= 20000 && Miles < 50000)
                {
                    _points = 20;
                }

                else if (Miles >= 50000 && Miles < 100000)
                {
                    _points = 30;
                }

                else
                {
                    _points = 50;
                }

            }
        }
    }
}
