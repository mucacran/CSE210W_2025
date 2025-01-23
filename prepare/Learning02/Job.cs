public class Job{
    public string _company = "";
    public string _jobTitle ="";
    public int _startYear = 0;
    public int endYear = 0;

    // Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public void Displays(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{endYear}");
    }
}