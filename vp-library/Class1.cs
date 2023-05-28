using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_library
{
    public class Class1
    {
        int i;
        public int sum(int a,int b)
        {
            i = a + b;
            return i;
        }
        public void display()
        {
            MessageBox.Show("Hello Welcome");
        }
    }
}
