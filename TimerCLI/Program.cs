using CommandLine;

var resetEvent = new ManualResetEvent(false);

Parser.Default.ParseArguments<Options>(args)
    .WithParsed(o =>
    {
        int cursorLeft = Console.CursorLeft;
        int cursorTop = Console.CursorTop;
        
        var time = o.Tea 
                ? new TimeSpan(0,3, 0)
                : new TimeSpan(o.Hours, o.Minutes, o.Seconds);
        
        Console.Write(time);
        
        var refreshInterval = TimeSpan.FromSeconds(1);
        var timer = new System.Timers.Timer(refreshInterval);
        timer.Start();
        timer.Elapsed += (_, _) =>
        {
            time = time.Subtract(refreshInterval);
            
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.Write(time);
            
            if (time <= TimeSpan.Zero)
            {
                timer.Stop();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                
                resetEvent.Set();
            }
        };
        
        resetEvent.WaitOne();
        Environment.Exit(0);
    });