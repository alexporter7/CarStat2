namespace CarStatLib.Structs;

public class Component {

    public string        Name     { get; set; }
    public string        Company  { get; set; }
    public string        Model    { get; set; }
    public ComponentLife Lifetime { get; set; }

}

public class ComponentLife {

    public int Months { get; set; }
    public int Miles  { get; set; }

}