namespace CarStatLib.Wrappers;

public class CSPath(string directory, string fileName = "", CSPathType type = CSPathType.Directory) {

    public string     Directory = directory;
    public CSPathType PathType  = type;
    public string     FileName  = fileName;

}

public enum CSPathType {

    File,
    Directory

}