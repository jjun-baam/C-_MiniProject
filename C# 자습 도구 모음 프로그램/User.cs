using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제_201730206_김준범
{
    class User
    {
        private string userName;
        private DateTime inTime;
        private DateTime outTime;

        public string UserName { get => userName; set => userName = value; }

        public void SetInTime()
        {
            inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            outTime = DateTime.Now;
        }
        public DateTime GetInTime()
        {
            return inTime;
        }
        public DateTime GetOutTime()
        {
            return outTime;
        }
    }
}
