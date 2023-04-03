using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities.Entities;

namespace DataEntities
{
    public interface IPatientCheckUpRepo
    {
        public DataEntities.Entities.PatientIntialCheckup GetCheckUpDetails(Guid appointment_id);
        public DataEntities.Entities.PatientIntialCheckup AddCheckUpDetails(PatientIntialCheckup intialCheckUp);
    }
}
