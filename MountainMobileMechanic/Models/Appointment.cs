using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MountainMobileMechanic.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
