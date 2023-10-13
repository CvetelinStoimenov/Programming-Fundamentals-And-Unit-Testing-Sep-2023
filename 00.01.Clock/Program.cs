static void MyClock()
{
    while (true)
    {
        for (int hour = 0; hour <= 23; hour++)
        {
            for (int minute = 0; minute <= 59; minute++)
            {
                for (int second = 0; second <= 59; second++)
                {
                    Console.SetCursorPosition(0, 0); // Set the cursor position to the start of the console
                    Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
                    Thread.Sleep(100); // Sleep for 1 second (1000 milliseconds)
                }
            }
        }
    }
}

static void Clock()

{
    while (true)
    {
        DateTime currentTime = DateTime.Now;
        Console.SetCursorPosition(0, 0); // Set the cursor position to the top-left corner
        Console.WriteLine(currentTime.ToString("HH:mm:ss")); // Display current time in HH:mm:ss format
        System.Threading.Thread.Sleep(1000); // Sleep for 1 second (1000 milliseconds)
    }
}

static void TimeAndDate()
{
    while (true)
    {
        DateTime currentTime = DateTime.Now;
        Console.SetCursorPosition(0, 0); // Set the cursor position to the top-left corner
        Console.WriteLine(currentTime.ToString("HH:mm:ss")); // Display current time in HH:mm:ss format

        // Move to the next line and display the current date
        Console.SetCursorPosition(0, 1);
        Console.WriteLine(currentTime.ToString("dd-MM-yyyy")); // Display current date in dd-MM-yyyy format

        System.Threading.Thread.Sleep(1000); // Sleep for 1 second (1000 milliseconds)
    }
}

TimeAndDate();