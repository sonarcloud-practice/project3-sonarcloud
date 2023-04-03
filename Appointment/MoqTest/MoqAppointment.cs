using AutoFixture;
using BussinessLogic;
using Moq;
using Xunit;
using ServiceLayer.Controllers;
using DataEntities.Entities;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace MoqTest
{

    public class MoqAppointment
    {
        private readonly IFixture fixture;
        private readonly Mock<IAppointment> _appointment;
        private readonly AppointmentController controller;
        private readonly Guid patient_id;

        public MoqAppointment()
        {
            fixture = new Fixture();
            _appointment = fixture.Freeze<Mock<IAppointment>>();
            controller = new AppointmentController(_appointment.Object);
        }

        

      /*  [Fact]
        public void TestDetails()
        {
            List<Models.Appointment> appointments = null;
            _appointment.Setup(x=>x.GetAppointmentsByPatient(patient_id)).Returns(appointments);

            var result = controller.GetAppointmentByPatientId(patient_id);
           result.Should().BeAssignableTo<BadRequestObjectResult>();

            _appointment.Verify(x=>x.GetAppointmentsByPatient(patient_id), Times.AtLeastOnce());
        }*/


        /* [Fact]
         public void GetAppointmentsByDate_Test()
         {
             var appointment=fixture.Create<Models.Appointment>();
             _appointment.Setup(x => x.GetAppointmentsByDate(DateTime.Now)).Returns((IEnumerable<Models.Appointment>)appointment);

             var result = controller.GetAppointmentByDate(DateTime.Now);

         }*/
    }
}
