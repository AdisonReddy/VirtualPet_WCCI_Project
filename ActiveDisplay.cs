using System;
namespace template_csharp_virtual_pet
{
    public static class ActiveDisplay
    {
        public static object DisplayStart()
        {
            System.Timers.Timer activeDisplay = new(500);
            activeDisplay.Start();
            activeDisplay.Elapsed += ActiveDisplay_Elapsed;
            void ActiveDisplay_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Console.SetCursorPosition(0, 0);
                Shelter.DisplayShelter();
                Console.SetCursorPosition(0, Shelter.cursorPos);
            }
            return activeDisplay;
        }
        public static void DisplayStop(System.Timers.Timer activeDisplay)
        {
            activeDisplay.Stop();
        }
        public static void DisplayStart(System.Timers.Timer activeDisplay)
        {
            activeDisplay.Start();
        }
        public static void StopTick(System.Timers.Timer tick)
        {
            tick.Stop();
        }
        public static void StartTick(System.Timers.Timer tick)
        {
            tick.Start();
        }
    }
}

