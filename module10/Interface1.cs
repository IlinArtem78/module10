using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace module10
{
    public interface IManager
    {
        void Create(); 
        void Delete();
        void Read();
        void Update(); 

    }
}
