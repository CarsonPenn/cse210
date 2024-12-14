using System;
// outdoor gatherings :) adding weather to the template
// might add if there is like a pavillion or a partial covering to use incase of bad weather

public class OutdoorGathering : Event {
    private string _weather;
    private string _date;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address) {
        _weather = weather;
        _date = date;
    }
    public string GetWeather() {
        return _weather;
    }

    public string GenerateWeatherReport() {
        return "The weather on" + _date + "is expected to be" + _weather + ".";
    }
    public string EventStyle() {
        return "Outdoor Gathering";
    }
    
    public string GenerateDetailedOutdoorGathering() {
        string details = "";
        string weatherReport = GenerateWeatherReport();

        details += GenerateTemplate() + "\n";
        details += "Weather Report: " + weatherReport;
        return details;
    }

    public string GenerateShortOutdoorGathering() {
        string shortOutdoor = "";
        string eventStyle = EventStyle();

        shortOutdoor += "Event Type: " + eventStyle + "\n";
        shortOutdoor += GenerateShort();
        return shortOutdoor;

    }

}