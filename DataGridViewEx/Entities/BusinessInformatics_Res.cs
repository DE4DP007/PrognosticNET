using System;

namespace DataGridViewEx.Entities
{
    public class BusinessInformatics_Res
    {
        public int ProgrammingDevelopement { get; set; }
        public int BusinessManagement { get; set; }
        public int Math_Economy { get; set; }
        public int ElectronicBusiness { get; set; }
        public int Inform_Systems { get; set; }
        public int Diploma { get; set; }
        public int BusinessModeling { get; set; }
        public int ProgrammingLanguages { get; set; }
        public int GosExam { get; set; }

        public BusinessInformatics_Res()
        {
            
        }

        public BusinessInformatics_Res(int a)
        {
            Random rnd = new Random();
            
            ProgrammingDevelopement = 3 + rnd.Next(a);
            BusinessManagement = 3 + rnd.Next(a);
            Math_Economy = 3 + rnd.Next(a);
            ElectronicBusiness = 3 + rnd.Next(a);
            Inform_Systems = 3 + rnd.Next(a);
            Diploma = 3 + rnd.Next(a);
            BusinessModeling = 3 + rnd.Next(a);
            ProgrammingLanguages = 3 + rnd.Next(a);
            GosExam = 3 + rnd.Next(a);

        }

    }
}