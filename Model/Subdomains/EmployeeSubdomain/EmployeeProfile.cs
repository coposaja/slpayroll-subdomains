namespace Model.Subdomains.EmployeeSubdomain{
    public class EmployeeProfile{
        public int ID;
        public int Name;
        public string PhotoURL;
        public string BirthPlace;
        public DateTime Birthdate;
        public char Gender;
        // kewarganegaraan
        public int ReligionID;
        public int MarriageStatusID;
        public string Address;
        public EmployeeWorkInformation EmployeeWorkInformation;
        public PermanentEmployeeInformation PermanentEmployeeInformation;
        public EducationHistory EducationHistory;
        public FamilyInsurance FamilyInsurance;
    }
}