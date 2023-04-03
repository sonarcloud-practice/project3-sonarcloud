using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities.Entities;

namespace DataEntities
{
    public  interface IAppointmentRepo
    {
        public  List<DataEntities.Entities.Appointment> GetAppointmentsByPatient(Guid patient_id);


        public List<DataEntities.Entities.Appointment> GetAppointmentsByDate(DateTime date);



        public List<DataEntities.Entities.Appointment> GetAppointmentsByDoctor(Guid doctor_id,string status);


        public DataEntities.Entities.Appointment UpdateStatus(DataEntities.Entities.Appointment appointment);

        public DataEntities.Entities.Appointment AddAppointment(DataEntities.Entities.Appointment appointment);

        public void EmailToPatient(string email, string date, string status);

    }
}
