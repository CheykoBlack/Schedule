using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Schedule.EntityFramework
{
    class ScheduleContext : DbContext
    {
        public ScheduleContext() : base("Name=DefaultConnection") { }
    }
}
