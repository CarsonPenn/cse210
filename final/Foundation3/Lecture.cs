using System;
// lecture - create the speaker and capacity behaviors and add that to a new method with the template to make a more detailed lecture

public class Lecture : Event {
    private string _speaker;
    private int _capacity;

public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
    _speaker = speaker;
    _capacity = capacity;
}

public string GetSpeaker() {
    return _speaker;
}
public int GetCapacity() {
    return _capacity;
}
public string EventStyle() {
    return "Lecture";
}

// taking what i made in event and adding the lecture information to it 
public string GenerateDetailedLecture() {
    string details = GenerateShort() + "\n";
    details += "Speaker: " + _speaker + "\n";
    details += "Capacity: " + _capacity + "max";
    return details;
}

public string GenerateShortLecture() {
    string shortLecture = "";
    string eventStyle = EventStyle();

    shortLecture += "Event Type: " + eventStyle + "\n";
    shortLecture += GenerateShort();
    return shortLecture;

}


}