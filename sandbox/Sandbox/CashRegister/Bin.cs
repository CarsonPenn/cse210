class Bin
{   
    // attributes
    private string _demomination;

    private float _value;

    private int _quantity;

    // methods

    public Bin(string denomination, float value, int quantity)
    {
        _demomination = denomination;
        _value = value;
        _quantity = quantity;
    
    }
    public void ModifyQuantity(int exchange)
    {
        _quantity += exchange;
    }

    public float CountValue()
    {
        return _quantity * _value;
    }
    
}