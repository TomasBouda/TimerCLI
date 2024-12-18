using CommandLine;

public class Options
{
    [Option('h', "hours", Required = false, HelpText = "Hours to wait")]
    public int Hours { get; set; }
    
    [Option('m', "minutes", Required = false, HelpText = "Minutes to wait")]
    public int Minutes { get; set; }
    
    [Option('s', "seconds", Required = false, HelpText = "Seconds to wait")]
    public int Seconds { get; set; }
    
    [Option("exit", Required = false, HelpText = "Application will exit after timer ends")]
    public bool Exit { get; set; }
    
    [Option("tea", Required = false, HelpText = "Tea mode. Sets timer to 3 minutes")]
    public bool Tea { get; set; }
}