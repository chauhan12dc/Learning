using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ViewModel
{
    class current
    {
        public string currentDate { get; set; }
        public current()
        {
            currentDate = DateTime.Now.ToString("hh:mm:ss");
        }
        public bool ct()
        {    
            return true;
        }
    }
}
