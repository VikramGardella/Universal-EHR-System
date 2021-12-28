using System;
namespace iHeal
{
    public class visitData
    {
        string dateOf, reason, outcome;
        int patientID, heartRate, systolicBP, diastolicBP, height, weight;

        public visitData(string dat, int patID, int HR, int sysBP, int diaBP, int h, int w, string rea, string outc) {
            dateOf = dat;
            patientID = patID;
            heartRate = HR;
            systolicBP = sysBP;
            diastolicBP = diaBP;
            height = h;
            weight = w;
            reason = rea;
            outcome = outc;
        }


        //accessors
        public string getDate() { return dateOf; }

        public string getReason() { return reason; }

        public string getOutcome() { return outcome; }

        public int getID() { return patientID; }

        public int getHR() { return heartRate; }

        public int getSysBP() { return systolicBP; }

        public int getDiaBP() { return diastolicBP; }

        public int getHeight() { return height; }

        public int getWeight() { return weight; }


        //functions
        public string printSummary(){
            string answer = "";
            return answer;


        }


    }
}
