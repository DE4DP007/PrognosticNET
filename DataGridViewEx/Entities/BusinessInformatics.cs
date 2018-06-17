using System;

namespace DataGridViewEx.Entities
{
    public class BusinessInformatics
    {
        public int CivilSafety { get; set; }
        public int CalcSystems_Nets_Telecom { get; set; }
        public int GraphicalDesign { get; set; }
        public int ForeignLanguage { get; set; }
        public int History { get; set; }
        public int LinearAlgebra { get; set; }
        public int Math_Analisys { get; set; }
        public int Informatics { get; set; }
        public int Programming { get; set; }

        public BusinessInformatics()
        {
            
        }

        public BusinessInformatics(int a)
        {
            Random rnd = new Random();
            
            CivilSafety = 3 + rnd.Next(a);
            CalcSystems_Nets_Telecom = 3 + rnd.Next(a);
            GraphicalDesign = 3 + rnd.Next(a);
            ForeignLanguage = 3 + rnd.Next(a);
            History = 3 + rnd.Next(a);
            LinearAlgebra = 3 + rnd.Next(a);
            Math_Analisys = 3 + rnd.Next(a);
            Informatics = 3 + rnd.Next(a);
            Programming = 3 + rnd.Next(a);
        }

    }
}