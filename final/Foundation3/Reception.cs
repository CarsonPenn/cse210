using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
// Reception adding in rsvp information

public class Reception : Event {
    private string _email;
    private int _phoneNumber;
    
    public Reception(string title, string description, string date, string time, Address address, string email, int phoneNumber) : base(title, description, date, time, address) {
        _email = email;
        _phoneNumber = phoneNumber;
    }

    public string GetEmail() {
        return _email;
    }
    public int GetPhoneNumber() {
        return _phoneNumber;
    }

    public string EventStyle() {
        return "Reception";
    }
    
    public string GenerateDetailedReception() {
        string details = GenerateTemplate() + "\n";
        details += "RSVP: " + _email + " or " + _phoneNumber;
        return details;
    }

    public string GenerateShortReception() {
        string shortReception = "";
        string eventStyle = EventStyle();
        shortReception += "Event Type: " + eventStyle + "\n";
        shortReception += GenerateShort();
        return shortReception;
    }
}
