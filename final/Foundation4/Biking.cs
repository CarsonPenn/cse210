using System;
// -known variable is speed- taking speed and dividing it by how long the run was 
//  same thing w pace, using the knowns of speed and the set minute to get the pace

public class Biking : Exercise {
    private double _speed;

public Biking(string date, int minutes, double speed) : base(date, minutes) {
    _name = "Biking  ";
    _speed = speed;
}

// d = s * t or d = s *(t/60)
    public override double CalculateDistance() {
        double distance = _speed * _minutes / 60;
        return distance;
    }
    // i am speed
    public override double CalculateSpeed() {
        return _speed;
    }
    // p = 60 / s
// pace is calculated by taking 60 and dividing it by the speed to get however minutes per kilometer.
    public override double CalculatePace() {
        double pace = 60 / _speed;
        return pace;
    }
}