using System;
// event 
// get all the info for the event, title, description, date, time, address.
// make the standard format to be inherited by other classes + the shorter version

public class Event {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
// getting all the standard things needed for the
    public Event(string title, string description, string date, string time, Address address) {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    // standard template for the long description
    public string GenerateTemplate() {
        string template = "Title: " + _title + "\n";
        template += "Description: " + _description + "\n";
        template += _date + " | " + _time + "\n";

        string address = _address.GenerateCompleteAddress();
        template += address;
        return template;
    }
    // quick details description
    public string GenerateShort() {
        string templateShort = "Title: "  + _title + "\n";
        templateShort += _date + "\n";
        return templateShort;
    }
}


// using strings for date and time - everything i looked at said i could either use int or string and string looked to be simpler
// github copilot to help me fix format erro