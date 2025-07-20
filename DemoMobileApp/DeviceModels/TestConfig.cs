public class TestConfig
{
    public string Platform { get; set; }
    public PlatformConfig Android { get; set; }
    public PlatformConfigIos Ios { get; set; }
}

public class PlatformConfig
{
    public string DeviceName { get; set; }
    public string AppPath { get; set; }
    public string AutomationName { get; set; }
}

public class PlatformConfigIos : PlatformConfig
{
    public string PlatformVersion { get; set; }
}