using System;
public class Job
{ public string _jobTitle;
  public string _company;
  public int _staryear;
  public int _endyear;
  public void display()
    {
       Console.WriteLine($"{_jobTitle} {_company} { _staryear} - { _endyear}");
    }

}
