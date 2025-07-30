namespace CarStatLib.Structs;

public class Vehicle {

    public string Name  { get; set; }
    
    public string Year  { get; set; }
    public VehicleMake Make  { get; set; }
    public VehicleModel Model { get; set; }
    
    public double Miles { get; set; }
    public string Color { get; set; }
    public string Style { get; set; }

    public List<Metric>    Metrics    { get; set; } = [];
    public List<Component> Components { get; set; } = [];

}

public class Metric {

    public string Name  { get; set; }
    public string Unit  { get; set; }
    public double Value { get; set; }

}



public class VehicleMake {

    public string Name          { get; set; }
    public string ParentCompany { get; set; }

}

public class VehicleModel {

    public string      Name { get; set; }
    public VehicleTrim Trim { get; set; }

}

public class VehicleTrim {

    public string Name { get; set; }

}