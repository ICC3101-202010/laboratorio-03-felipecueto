using System;
namespace Lab3
{
    public class Employee : Person
    {
        private int salary;
        private string job;
        private string startTime;
        private string endTime;

        public Employee(string name, string lastname, int id, string birthDate, string nationality, int salary, string job, string startTime, string endTime) : base(name, lastname, id, birthDate, nationality)
        {
            this.salary = salary;
            this.job = job;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public string information()
        {
            return $"Nombre: {name}\nApelldio: {lastname}\nID: {id}\nFecha Nacimiento: {birthDate}\nNacionalidad: {nationality}\nSuledo; {salary}\nPuesto Trabajo: {job}\nHorario: {startTime}-{endTime}\n";
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Job
        {
            get { return job; }
            set { job = value; }

        }
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }

}
