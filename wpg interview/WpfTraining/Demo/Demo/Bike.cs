using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public class Bike : IVehicle
    {
        public void getData()
        {
            MessageBox.Show("Bike");
        }
    }
}
