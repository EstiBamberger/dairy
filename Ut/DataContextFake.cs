using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api;
using firstApi;

namespace Ut
{
    internal class DataContextFake:IDataContext
    {
        public List<Event> EventList { get; set; }
        public DataContextFake() { 
            EventList = new List<Event> { new Event { Id=1,Title="e1",Start= new DateTime(2023, 11, 7, 12, 30, 0),End= new DateTime(2023, 11,8, 12, 30, 0)},
                                                            new Event { Id = 2, Title = "e2",Start= new DateTime(2023, 11, 10, 12, 30, 0),End=new DateTime(2023, 11, 1,12, 30, 0) },
                                                            new Event { Id=3,Title="e3",Start= new DateTime(2023, 11, 2, 12, 30, 0),End=new DateTime(2023, 11, 4, 12, 30, 0)}};
       
        }
    }
}
