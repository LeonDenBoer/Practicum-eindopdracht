using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuPracticum5.model
{
    class Task
    {
        int _id;
        User _user;
        int _time;


        public int Id { get => _id; set => _id = value; }
        public User User { get => _user; set => _user = value; }
        public int Time { get => _time; set => _time = value; }
    }
}
