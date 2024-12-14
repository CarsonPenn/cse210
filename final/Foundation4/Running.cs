using System;
// polymorphism known variable is distance

public class Running : Exercise {
    private double _distance;


    public Running(string date, int minutes, double distance) : base(date, minutes) {
        _name = "Runnning";
        _distance = distance;
    }

    public override double CalculateDistance() {
        return _distance;
    }


    // s = d/t * 60
    public override double CalculateSpeed()  {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }
// p = minutes / d
    public override double CalculatePace() {
        double pace = _minutes / _distance;
        return pace;
    }



}