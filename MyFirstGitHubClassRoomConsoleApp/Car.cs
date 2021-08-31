using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    public class Car
    {
        private int _wheels;
        private int _drivers;
        private string _number;

        public Car(int wheels,int drivers, string number)
        {
            _wheels = wheels;
            _drivers = drivers;
            _number = number;
        }


        public int Wheels
        {
            get;set;
        }
        public int Drivers
        {
            get; set;
        }
        public int Numbers
        {
            get; set;
        }
    }
}
