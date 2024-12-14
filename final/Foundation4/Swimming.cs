using System;
// known variable is laps, 50 laps is a km

public class Swimming : Exercise {
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes) {
        _name = "Swimming";
        _laps = laps;
    }
// got the math for this from the assighment details
    public override double CalculateDistance() {
        double distance = _laps * 50 / 1000;
        return distance;
    }
    // chat gpt helped with figure out this one
// same formula as others, s = d/t * 60
    public override double CalculateSpeed() {
        double speed = CalculateDistance() / _minutes * 60;
        return speed;
    }

    public override double CalculatePace() {
        double pace = _minutes / CalculateDistance();
        return pace;
    }
}