using CommandLine;

public class Options
{
    [Option('h', "hours", Required = false, HelpText = "Hours to wait")]
    public int Hours { get; set; }
    
    [Option('m', "minutes", Required = false, HelpText = "Minutes to wait")]
    public int Minutes { get; set; }
    
    [Option('s', "seconds", Required = false, HelpText = "Seconds to wait")]
    public int Seconds { get; set; }
}