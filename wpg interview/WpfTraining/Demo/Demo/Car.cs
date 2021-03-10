using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
   public class Car: IVehicle
    {
        public Car()
        {

        }

        public void getData()
        {
            MessageBox.Show("Car");
        }
        public void getData2()
        {
            MessageBox.Show("Car");
        }
    }
}
