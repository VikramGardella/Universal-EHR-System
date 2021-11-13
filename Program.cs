using System;
using System.Collections.Generic;

namespace iHeal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your iHeal Electronic Health Records System.\n");

            int patientCount = 0;

            List<Patient> patList = new List<Patient>();

            //eventually implement hash map/set here with patientID (given by patientCount) as key
            Patient patA = new Patient("John", "Doe", 4, 22, 1996, "Male", ++patientCount);
            patList.Add(patA);

            Patient patB = new Patient("William", "Harris", 4, 22, 1996, "Male", ++patientCount);
            patList.Add(patB);

            Patient patC = new Patient("Deborah", "Harris", 4, 22, 1996, "Female", ++patientCount);
            patList.Add(patC);


            for (int i = 0; i < patList.Count; i++) {
                patList[i].printAllPatientData();

            }

        }
    }
}
