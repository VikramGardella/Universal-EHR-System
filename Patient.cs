using System;
using System.Collections.Generic;

namespace iHeal
{
    public class Patient
    {
        string firstName, lastName, address, gender;
        int ageYears, heightInches, weightPounds, systolicBP, diastolicBP;
        int dayDOB, monthDOB, yearDOB, heartRateResting, patientID;

        List<visitData> visitsLog = new List<visitData>();

        //add image for patient profile pic as member variable too

        dataCardiology cardioData = new dataCardiology();
        dataNeurology neuroData = new dataNeurology();
        dataPsychiatry pyschData = new dataPsychiatry();
        dataOphthalmology ophthaData = new dataOphthalmology();
        dataOrthopediatry orthoData = new dataOrthopediatry();
        dataPathology pathoData = new dataPathology();
        dataRadiology radioData = new dataRadiology();
        dataAnesthesiology anesthData = new dataAnesthesiology();
        dataOtolaryngology otolaData = new dataOtolaryngology();
        dataUrology uroData = new dataUrology();
        dataDermatology dermaData = new dataDermatology();

        public Patient(string firstN, string lastN, int dDOB, int mDOB, int yDOB, string gen, int patID)
        {
            firstName = firstN;
            lastName = lastN;
            dayDOB = dDOB;
            monthDOB = mDOB;
            yearDOB = yDOB;
            gender = gen;
            patientID = patID;
        }


        //Accessors
        public string getFirstName() { return firstName; }

        public string getLastName() { return lastName; }

        public int getID() { return patientID; }

        public int getHeight() { return heightInches; }

        public int getWeight() { return weightPounds; }

        public int getSystolic() { return systolicBP; }

        public int getDiastolic() { return diastolicBP; }

        public string getAsStringBP() {
            return ("" + systolicBP + "/" + diastolicBP);
        }

        public int getRestingHR() { return heartRateResting; }


        //Mutators
        public void setFirstName(string newFN) { firstName = newFN; }

        public void setLastName(string newLN) { lastName = newLN; }

        public void setHeight(int newH) { heightInches = newH; }

        public void setWeight(int newW) { weightPounds = newW; }

        public void setSystolic(int newSys) { systolicBP = newSys; }

        public void setDiastolic(int newDia) { diastolicBP = newDia; }

        public void setHeartRate(int newHR) { heartRateResting = newHR; }


        //Functions
        public double calcBMI() { return -1.0; }

        public int calcAge() { return -1; } //use system call to get current date, then find Math.floor(difference)

        public Boolean detectIssuesBP() {
            if (1==1)
            {
                return false;
            }
            else {
                Console.WriteLine("Warning, " + firstName + "'s blood pressure indicates a risk of...");
                return true;
            }

        }

        public void addVisitData(visitData vis) {
            visitsLog.Add(vis);
        }

        public void printAllPatientData() {
            Console.WriteLine("\n\n------------------------------\n");

            Console.WriteLine("[" + lastName + ", " + firstName + "] - #" + patientID + "\n");
            Console.WriteLine("-Generic Data:");
            Console.WriteLine("\tDOB: [" + dayDOB + " / " + monthDOB + " / " + yearDOB + "]");
            Console.WriteLine("\tGender: " + gender);
            Console.WriteLine("\tHeight: " + heightInches + " Inches");
            Console.WriteLine("\tWeight: " + weightPounds + " LBS");
            Console.WriteLine("-Systemic Data:");
            Console.WriteLine("\tBlood Pressure: " + systolicBP + "/" + diastolicBP);
            Console.WriteLine("\tHeart Rate: " + heartRateResting + " BPM");

            Console.WriteLine("\n-Cardiologic Data:");
            //cardioData.printSummary();
            Console.WriteLine("\n-Neurologic Data:");
            //neuroData.printSummary();
            Console.WriteLine("\n-Psychiatric Data:");
            //psychData.printSummary();
            Console.WriteLine("\n-Ophthalmic Data:");
            //ophthaData.printSummary();
            Console.WriteLine("\n-Orthopedic Data:");
            //orthoData.printSummary();
            Console.WriteLine("\n-Pathologic Data:");
            //pathoData.printSummary();
            Console.WriteLine("\n-Radiologic Data:");
            //radioData.printSummary();
            Console.WriteLine("\n-Anesthesiologic Data:");
            //anesthData.printSummary();
            Console.WriteLine("\n-Otolaryngologic Data:");
            //otolaData.printSummary();
            Console.WriteLine("\n-Urologic Data:");
            //uroData.printSummary();
            Console.WriteLine("\n-Dermatologic Data:");
            //dermaData.printSummary();

            Console.WriteLine("\n------------------------------\n\n");
        }

        public int convertInToCm() {
            return (int)(2.54 * heightInches);

        }

        public int convertLbsToKg() {
            return (int)(weightPounds / 2.2);
        }

        public int calculateAge() {
            int age = 0;
            //get system date here

            //use patient member variables for DOB

            //see if system data has surpassed month/day of current year
            //if so: return (yearCurrent - yearDOB)
            //else: return (yearCurrent - yearDOB - 1)

            return (age);

        }

    }
}
