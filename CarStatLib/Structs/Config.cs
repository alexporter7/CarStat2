using CarStatLib.Wrappers;

namespace CarStatLib.Structs;

public class Config {

    public BackupSettings BackupSettings { get; set; }

}

public class BackupSettings {

    public CSPath BackupDirectory { get; set; }

}