using System;
// code to be inherited and polymorphed across the program. 
public class Exercise {
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Exercise(string date, int minutes) {
        _date = date;
        _minutes = minutes;
    }
    // setting up distance, speed and pace
    // d = s * t
    public virtual double CalculateDistance() {
        return 0;
    }
    // s = d/t * 60
    public virtual double CalculateSpeed() {
        return 0;
    }
    // p = t/d
    public virtual double CalculatePace() {
        return 0;
    }

    // prints the output exactly like the assignment details
// public string GetSummary() {
//     string summary = $"{_date} {_name} ({_minutes} mins)- Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
//     return summary;
// }
// modified version to make the information more lined up and quicker to digest.
// chatgpt taught me how to do column alignment and decimal formating
public string GetSummary() {
    string summary = $"{_date,-15} {_name,-20} {_minutes,5} mins - " +
                     $"Distance: {CalculateDistance(),6:F2} km, " +
                     $"Speed: {CalculateSpeed(),6:F2} kph, " +
                     $"Pace: {CalculatePace(),6:F2} min/km";
    return summary;
}



}