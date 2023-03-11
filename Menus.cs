using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Media;
using System.Reflection;

namespace template_csharp_virtual_pet
{
    public static class Menus
    {
        public static void IntroMenu()
        {
            /*
            string welcomeMessage = "WELCOME TO MAS CODE'S";
            welcomeMessage.ToCharArray();
            Console.Write(welcomeMessage[0]);

            System.Timers.Timer welcome2 = new(0150);
            welcome2.Start();
            welcome2.Elapsed += welcom2_Elapsed;
            Console.ReadKey();
            void welcom2_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Console.Write(welcomeMessage[1]);
                welcome2.Stop();
                welcome2.Dispose();

                System.Timers.Timer welcome3 = new(0150);
                welcome3.Start();
                welcome3.Elapsed += welcom3_Elapsed;
                void welcom3_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                {
                    Console.Write(welcomeMessage[2]);
                    welcome3.Stop();
                    welcome3.Dispose();

                    System.Timers.Timer welcome4 = new(0150);
                    welcome4.Start();
                    welcome4.Elapsed += welcom4_Elapsed;
                    void welcom4_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                    {
                        Console.Write(welcomeMessage[3]);
                        welcome4.Stop();
                        welcome4.Dispose();

                        System.Timers.Timer welcome5 = new(0150);
                        welcome5.Start();
                        welcome5.Elapsed += welcom5_Elapsed;
                        void welcom5_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                        {
                            Console.Write(welcomeMessage[4]);
                            welcome5.Stop();
                            welcome5.Dispose();

                            System.Timers.Timer welcome6 = new(0150);
                            welcome6.Start();
                            welcome6.Elapsed += welcom6_Elapsed;
                            void welcom6_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                            {
                                Console.Write(welcomeMessage[5]);
                                welcome6.Stop();
                                welcome6.Dispose();

                                System.Timers.Timer welcome7 = new(0150);
                                welcome7.Start();
                                welcome7.Elapsed += welcom7_Elapsed;
                                void welcom7_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                {
                                    Console.Write(welcomeMessage[6]);
                                    welcome7.Stop();
                                    welcome7.Dispose();

                                    System.Timers.Timer welcome8 = new(0150);
                                    welcome8.Start();
                                    welcome8.Elapsed += welcom8_Elapsed;
                                    void welcom8_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                    {
                                        Console.Write(welcomeMessage[7]);
                                        welcome8.Stop();
                                        welcome8.Dispose();

                                        System.Timers.Timer welcome9 = new(0150);
                                        welcome9.Start();
                                        welcome9.Elapsed += welcom9_Elapsed;
                                        void welcom9_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                        {
                                            Console.Write(welcomeMessage[8]);
                                            welcome9.Stop();
                                            welcome9.Dispose();

                                            System.Timers.Timer welcome10 = new(0150);
                                            welcome10.Start();
                                            welcome10.Elapsed += welcom10_Elapsed;
                                            void welcom10_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                            {
                                                Console.Write(welcomeMessage[9]);
                                                welcome10.Stop();
                                                welcome10.Dispose();

                                                System.Timers.Timer welcome11 = new(0150);
                                                welcome11.Start();
                                                welcome11.Elapsed += welcom11_Elapsed;
                                                void welcom11_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                {
                                                    Console.Write(welcomeMessage[10]);
                                                    welcome11.Stop();
                                                    welcome11.Dispose();

                                                    System.Timers.Timer welcome12 = new(0150);
                                                    welcome12.Start();
                                                    welcome12.Elapsed += welcom12_Elapsed;
                                                    void welcom12_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                    {
                                                        Console.Write(welcomeMessage[11]);
                                                        welcome12.Stop();
                                                        welcome12.Dispose();

                                                        System.Timers.Timer welcome13 = new(0150);
                                                        welcome13.Start();
                                                        welcome13.Elapsed += welcom13_Elapsed;
                                                        void welcom13_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                        {
                                                            Console.Write(welcomeMessage[12]);
                                                            welcome13.Stop();
                                                            welcome13.Dispose();

                                                            System.Timers.Timer welcome14 = new(0150);
                                                            welcome14.Start();
                                                            welcome14.Elapsed += welcom13_Elapsed;
                                                            void welcom13_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                            {
                                                                Console.Write(welcomeMessage[13]);
                                                                welcome14.Stop();
                                                                welcome14.Dispose();

                                                                System.Timers.Timer welcome15 = new(0150);
                                                                welcome15.Start();
                                                                welcome15.Elapsed += welcom15_Elapsed;
                                                                void welcom15_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                {
                                                                    Console.Write(welcomeMessage[14]);
                                                                    welcome15.Stop();
                                                                    welcome15.Dispose();

                                                                    System.Timers.Timer welcome16 = new(0150);
                                                                    welcome16.Start();
                                                                    welcome16.Elapsed += welcom16_Elapsed;
                                                                    void welcom16_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                    {
                                                                        Console.Write(welcomeMessage[15]);
                                                                        welcome16.Stop();
                                                                        welcome16.Dispose();

                                                                        System.Timers.Timer welcome17 = new(0150);
                                                                        welcome17.Start();
                                                                        welcome17.Elapsed += welcom17_Elapsed;
                                                                        void welcom17_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                        {
                                                                            Console.Write(welcomeMessage[16]);
                                                                            welcome17.Stop();
                                                                            welcome17.Dispose();

                                                                            System.Timers.Timer welcome18 = new(0150);
                                                                            welcome18.Start();
                                                                            welcome18.Elapsed += welcom18_Elapsed;
                                                                            void welcom18_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                            {
                                                                                Console.Write(welcomeMessage[17]);
                                                                                welcome18.Stop();
                                                                                welcome18.Dispose();

                                                                                System.Timers.Timer welcome19 = new(0150);
                                                                                welcome19.Start();
                                                                                welcome19.Elapsed += welcom19_Elapsed;
                                                                                void welcom19_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                {
                                                                                    Console.Write(welcomeMessage[18]);
                                                                                    welcome19.Stop();
                                                                                    welcome19.Dispose();

                                                                                    System.Timers.Timer welcome20 = new(0150);
                                                                                    welcome20.Start();
                                                                                    welcome20.Elapsed += welcom20_Elapsed;
                                                                                    void welcom20_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                    {
                                                                                        Console.Write(welcomeMessage[19]);
                                                                                        welcome20.Stop();
                                                                                        welcome20.Dispose();

                                                                                        System.Timers.Timer welcome21 = new(0150);
                                                                                        welcome21.Start();
                                                                                        welcome21.Elapsed += welcom20_Elapsed;
                                                                                        void welcom20_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                        {
                                                                                            Console.Write(welcomeMessage[20] + "\n");
                                                                                            Console.ForegroundColor = ConsoleColor.Red;

                                                                                            welcome21.Stop();
                                                                                            welcome21.Dispose();

                                                                                            //welcome message ends

                                                                                            //start of title
                                                                                            System.Timers.Timer title1 = new(1000);
                                                                                            title1.Start();
                                                                                            title1.Elapsed += Title1_Elapsed;
                                                                                            void Title1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                            {
                                                                                                Console.SetCursorPosition(0, 2);
                                                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                Console.WriteLine(@"_________  ");
                                                                                                Console.WriteLine(@"\__   ___| ");
                                                                                                Console.WriteLine(@"   ) (     ");
                                                                                                Console.WriteLine(@"   | |     ");
                                                                                                Console.WriteLine(@"   | |     ");
                                                                                                Console.WriteLine(@"   | |     ");
                                                                                                Console.WriteLine(@"   | |     ");
                                                                                                Console.WriteLine(@"  |___|    " + "\n");
                                                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                title1.Stop();
                                                                                                title1.Dispose();

                                                                                                System.Timers.Timer title2 = new(0150);
                                                                                                title2.Start();
                                                                                                title2.Elapsed += Title2_Elapsed;
                                                                                                void Title2_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                {
                                                                                                    Console.SetCursorPosition(0, 2);
                                                                                                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                    Console.WriteLine(@" _______ _________  ");
                                                                                                    Console.WriteLine(@"(  ____ \\__   ___| ");
                                                                                                    Console.WriteLine(@"| (    \/   ) (     ");
                                                                                                    Console.WriteLine(@"| (__       | |     ");
                                                                                                    Console.WriteLine(@"|  __)      | |     ");
                                                                                                    Console.WriteLine(@"| (         | |     ");
                                                                                                    Console.WriteLine(@"| (____/\   | |     ");
                                                                                                    Console.WriteLine(@"|_______|  |___|    " + "\n");
                                                                                                    Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                    title2.Stop();
                                                                                                    title2.Dispose();

                                                                                                    System.Timers.Timer title3 = new(0150);
                                                                                                    title3.Start();
                                                                                                    title3.Elapsed += Title3_Elapsed;
                                                                                                    void Title3_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                    {
                                                                                                        Console.SetCursorPosition(0, 2);
                                                                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                        Console.WriteLine(@" _______  _______ _________  ");
                                                                                                        Console.WriteLine(@"(  ____ )(  ____ \\__   ___| ");
                                                                                                        Console.WriteLine(@"| (    )|| (    \/   ) (     ");
                                                                                                        Console.WriteLine(@"| (____)|| (__       | |     ");
                                                                                                        Console.WriteLine(@"|  _____)|  __)      | |     ");
                                                                                                        Console.WriteLine(@"| (      | (         | |     ");
                                                                                                        Console.WriteLine(@"| )      | (____/\   | |     ");
                                                                                                        Console.WriteLine(@"|__|     |_______|  |___|    " + "\n");
                                                                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                        title3.Stop();
                                                                                                        title3.Dispose();

                                                                                                        System.Timers.Timer title4 = new(0150);
                                                                                                        title4.Start();
                                                                                                        title4.Elapsed += Title4_Elapsed;
                                                                                                        void Title4_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                        {
                                                                                                            Console.SetCursorPosition(0, 2);
                                                                                                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                            Console.WriteLine(@" _             _______  _______ _________  ");
                                                                                                            Console.WriteLine(@"( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                            Console.WriteLine(@"| (           | (    )|| (    \/   ) (     ");
                                                                                                            Console.WriteLine(@"| |           | (____)|| (__       | |     ");
                                                                                                            Console.WriteLine(@"| |           |  _____)|  __)      | |     ");
                                                                                                            Console.WriteLine(@"| |           | (      | (         | |     ");
                                                                                                            Console.WriteLine(@"| (____/\     | )      | (____/\   | |     ");
                                                                                                            Console.WriteLine(@"(_______/     |__|     |_______|  |___|    " + "\n");
                                                                                                            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                            title4.Stop();
                                                                                                            title4.Dispose();

                                                                                                            System.Timers.Timer title5 = new(0150);
                                                                                                            title5.Start();
                                                                                                            title5.Elapsed += Title5_Elapsed;
                                                                                                            void Title5_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                            {
                                                                                                                Console.SetCursorPosition(0, 2);
                                                                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                                Console.WriteLine(@" _______  _             _______  _______ _________  ");
                                                                                                                Console.WriteLine(@"(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                                Console.WriteLine(@"| (   ) || (           | (    )|| (    \/   ) (     ");
                                                                                                                Console.WriteLine(@"| (___) || |           | (____)|| (__       | |     ");
                                                                                                                Console.WriteLine(@"|  ___  || |           |  _____)|  __)      | |     ");
                                                                                                                Console.WriteLine(@"| (   ) || |           | (      | (         | |     ");
                                                                                                                Console.WriteLine(@"| )   ( || (____/\     | )      | (____/\   | |     ");
                                                                                                                Console.WriteLine(@"|/     \|(_______/     |__|     |_______|  |___|    " + "\n");
                                                                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                                title5.Stop();
                                                                                                                title5.Dispose();

                                                                                                                System.Timers.Timer title6 = new(0150);
                                                                                                                title6.Start();
                                                                                                                title6.Elapsed += Title6_Elapsed;
                                                                                                                void Title6_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                {
                                                                                                                    Console.SetCursorPosition(0, 2);
                                                                                                                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                                    Console.WriteLine(@"          _______  _             _______  _______ _________  ");
                                                                                                                    Console.WriteLine(@"|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                                    Console.WriteLine(@"| )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                                                                                                                    Console.WriteLine(@"| |   | || (___) || |           | (____)|| (__       | |     ");
                                                                                                                    Console.WriteLine(@"| |   | ||  ___  || |           |  _____)|  __)      | |     ");
                                                                                                                    Console.WriteLine(@"| |   | || (   ) || |           | (      | (         | |     ");
                                                                                                                    Console.WriteLine(@"| (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                                                                                                                    Console.WriteLine(@"(_______)|/     \|(_______/     |__|     |_______|  |___|    " + "\n");
                                                                                                                    Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                                    title6.Stop();
                                                                                                                    title6.Dispose();

                                                                                                                    System.Timers.Timer title7 = new(0150);
                                                                                                                    title7.Start();
                                                                                                                    title7.Elapsed += Title7_Elapsed;
                                                                                                                    void Title7_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                    {
                                                                                                                        Console.SetCursorPosition(0, 2);
                                                                                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                                        Console.WriteLine(@"_________          _______  _             _______  _______ _________  ");
                                                                                                                        Console.WriteLine(@"\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                                        Console.WriteLine(@"   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                                                                                                                        Console.WriteLine(@"   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
                                                                                                                        Console.WriteLine(@"   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
                                                                                                                        Console.WriteLine(@"   | |   | |   | || (   ) || |           | (      | (         | |     ");
                                                                                                                        Console.WriteLine(@"   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                                                                                                                        Console.WriteLine(@"   )_(   (_______)|/     \|(_______/     |__|     |_______|  |___|    " + "\n");
                                                                                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------\n");

                                                                                                                        title7.Stop();
                                                                                                                        title7.Dispose();

                                                                                                                        System.Timers.Timer title8 = new(0150);
                                                                                                                        title8.Start();
                                                                                                                        title8.Elapsed += Title8_Elapsed;
                                                                                                                        void Title8_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                        {
                                                                                                                            Console.SetCursorPosition(0, 2);
                                                                                                                            Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                                            Console.WriteLine(@" _______ _________          _______  _             _______  _______ _________  ");
                                                                                                                            Console.WriteLine(@"(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                                            Console.WriteLine(@"| (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                                                                                                                            Console.WriteLine(@"| (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
                                                                                                                            Console.WriteLine(@"|     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
                                                                                                                            Console.WriteLine(@"| (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
                                                                                                                            Console.WriteLine(@"| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                                                                                                                            Console.WriteLine(@"|/   \__/   )_(   (_______)|/     \|(_______/     |__|     |_______|  |___|    " + "\n");
                                                                                                                            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
                                                                                                                            title8.Stop();
                                                                                                                            title8.Dispose();

                                                                                                                            System.Timers.Timer title9 = new(0150);
                                                                                                                            title9.Start();
                                                                                                                            title9.Elapsed += Title9_Elapsed;
                                                                                                                            void Title9_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                            {
                                                                                                                                Console.SetCursorPosition(0, 2);
                                                                                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                                                Console.WriteLine(@"_________ _______ _________          _______  _             _______  _______ _________  ");
                                                                                                                                Console.WriteLine(@"\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                                                Console.WriteLine(@"   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                                                                                                                                Console.WriteLine(@"   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
                                                                                                                                Console.WriteLine(@"   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
                                                                                                                                Console.WriteLine(@"   | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
                                                                                                                                Console.WriteLine(@"___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                                                                                                                                Console.WriteLine(@"\_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
                                                                                                                                Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
                                                                                                                                title9.Stop();
                                                                                                                                title9.Dispose();

                                                                                                                                System.Timers.Timer title10 = new(0150);
                                                                                                                                title10.Start();
                                                                                                                                title10.Elapsed += Title10_Elapsed;
                                                                                                                                void Title10_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                {
                                                                                                                                    Console.SetCursorPosition(0, 2);
                                                                                                                                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                                                                                                                                    Console.WriteLine(@"          _________ _______ _________          _______  _             _______  _______ _________  ");
                                                                                                                                    Console.WriteLine(@" |\     /|\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                                                                                                                                    Console.WriteLine(@" | )   ( |   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                                                                                                                                    Console.WriteLine(@" | |   | |   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
                                                                                                                                    Console.WriteLine(@" ( (   ) )   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
                                                                                                                                    Console.WriteLine(@" \ \_ / /    | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
                                                                                                                                    Console.WriteLine(@"  \    /  ___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                                                                                                                                    Console.WriteLine(@"   \__/   \_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
                                                                                                                                    Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
                                                                                                                                    Console.ForegroundColor = ConsoleColor.White;
                                                                                                                                    title10.Stop();
                                                                                                                                    title10.Dispose();

                                                                                                                                    System.Timers.Timer title11 = new(1500);
                                                                                                                                    title11.Start();
                                                                                                                                    title11.Elapsed += Title11_Elapsed;
                                                                                                                                    void Title11_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                    {
                                                                                                                                        title11.Stop();
                                                                                                                                        title11.Dispose();
                                                                                                                                        Console.WriteLine("This pocket universe moves fast, " +
                                                                                                                                        "You will have to move fast as well to keep your new" +
                                                                                                                                        " friends alive and happy.\n\n");
                                                                                                                                        Console.WriteLine("\nPress any key to continue...");

                                                                                                                                    }

                                                                                                                                }

                                                                                                                            }

                                                                                                                        }

                                                                                                                    }

                                                                                                                }

                                                                                                            }

                                                                                                        }

                                                                                                    }

                                                                                                }
                                                                                            }


                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Console.ReadKey();
            */
        }
        public static string OrganicOrRoboticMenu()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO MAS CODE'S");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"          _________ _______ _________          _______  _             _______  _______ _________  ");
            Console.WriteLine(@" |\     /|\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
            Console.WriteLine(@" | )   ( |   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
            Console.WriteLine(@" | |   | |   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
            Console.WriteLine(@" ( (   ) )   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
            Console.WriteLine(@" \ \_ / /    | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
            Console.WriteLine(@"  \    /  ___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
            Console.WriteLine(@"   \__/   \_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This pocket universe moves fast, "
    + "You will have to move fast as well to keep your new"
    + " friends alive and happy.\n\n");
            Console.WriteLine("Do you want a robotic or organic pet? You will have to borrow this money, but that's okay since you can always make it back!\n");
            Console.WriteLine("1. Organic ($20,000)");
            Console.WriteLine("2. Robotic ($100,000)");
            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                switch (userChoice.KeyChar)
                {
                    case '1':
                        selection = "Organic";
                        menuUp = false;
                        break;
                    case '2':
                        selection = "Robotic";
                        menuUp = false;
                        break;
                }
            }
            return selection;
        }
        public static string OrganicOrRoboticMenu2()
        {
            Console.Clear();
            Shelter.DisplayShelter();

            Console.SetCursorPosition(0, Shelter.cursorPos+3);
            Console.WriteLine("Do you want a robotic or organic pet?\n");
            Console.WriteLine("1. Organic");
            Console.WriteLine("2. Robotic");

            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);

                switch (userChoice.KeyChar)
                {
                    case '1':
                        selection = "Organic";
                        menuUp = false;
                        break;
                    case '2':
                        selection = "Robotic";
                        menuUp = false;
                        break;
                }
            }
            return selection;
        }
    public static string SpeciesMenu()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO MAS CODE'S");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"          _________ _______ _________          _______  _             _______  _______ _________  ");
            Console.WriteLine(@" |\     /|\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
            Console.WriteLine(@" | )   ( |   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
            Console.WriteLine(@" | |   | |   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
            Console.WriteLine(@" ( (   ) )   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
            Console.WriteLine(@" \ \_ / /    | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
            Console.WriteLine(@"  \    /  ___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
            Console.WriteLine(@"   \__/   \_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This pocket universe moves fast, "
    + "You will have to move fast as well to keep your new"
    + " friends alive and happy.\n\n");
            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");

            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                switch (userChoice.KeyChar)
                {
                    case '1':
                        selection = "Lion";
                        menuUp = false;
                        break;
                    case '2':
                        selection = "Tiger";
                        menuUp = false;
                        break;
                    case '3':
                        selection = "Panther";
                        menuUp = false;
                        break;
                }
            }
            return selection;
        }
        public static string SpeciesMenu2()
        {
            Console.Clear();
            Shelter.DisplayShelter();

            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");
            Console.SetCursorPosition(0, Shelter.cursorPos);

            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                switch (userChoice.KeyChar)
                {
                    case '1':
                        selection = "Lion";
                        menuUp = false;
                        break;
                    case '2':
                        selection = "Tiger";
                        menuUp = false;
                        break;
                    case '3':
                        selection = "Panther";
                        menuUp = false;
                        break;
                }
            }
            return selection;
        }
        public static string RobotTypeMenu()
        {
            Console.Clear();
            Console.WriteLine("What Robot Type do you want?\n");
            Console.WriteLine("1. Robot Type A");
            Console.WriteLine("2. Robot Type B");
            Console.WriteLine("3. Robot Type C");
            string selection = "";

            bool menuUp = true;
            while (menuUp)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                switch (userChoice.KeyChar)
                {
                    case '1':
                        selection = "Type A";
                        menuUp = false;
                        break;
                    case '2':
                        selection = "Type B";
                        menuUp = false;
                        break;
                    case '3':
                        selection = "Type C";
                        menuUp = false;
                        break;
                }
            }
            return selection;
        }
        public static string RobotTypeMenu2()
        {
            Console.Clear();
            Shelter.DisplayShelter();

            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
            Console.WriteLine("What Robot Type do you want?\n");
            Console.WriteLine("1. Robot Type A");
            Console.WriteLine("2. Robot Type B");
            Console.WriteLine("3. Robot Type C");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                switch (userChoice.KeyChar)
                {
                    case '1':
                        selection = "Type A";
                        menuUp = false;
                        break;
                    case '2':
                        selection = "Type B";
                        menuUp = false;
                        break;
                    case '3':
                        selection = "Type C";
                        menuUp = false;
                        break;
                }
            }
            return selection;
        }
        public static string NameMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO MAS CODE'S");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine(@"          _________ _______ _________          _______  _             _______  _______ _________  ");
                Console.WriteLine(@" |\     /|\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                Console.WriteLine(@" | )   ( |   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                Console.WriteLine(@" | |   | |   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
                Console.WriteLine(@" ( (   ) )   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
                Console.WriteLine(@" \ \_ / /    | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
                Console.WriteLine(@"  \    /  ___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                Console.WriteLine(@"   \__/   \_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
                Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("This pocket universe moves fast, " 
                    + "You will have to move fast as well to keep your new" 
                    + " friends alive and happy.\n\n");
                Console.WriteLine("What would you like to name your pet?");
                Console.Write("\n>> ");
                string name = Console.ReadLine();
                if (name.Length < 12) { return name; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static void NameMenu(Pet usersPet)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO MAS CODE'S");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine(@"          _________ _______ _________          _______  _             _______  _______ _________  ");
                Console.WriteLine(@" |\     /|\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
                Console.WriteLine(@" | )   ( |   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
                Console.WriteLine(@" | |   | |   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
                Console.WriteLine(@" ( (   ) )   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
                Console.WriteLine(@" \ \_ / /    | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
                Console.WriteLine(@"  \    /  ___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
                Console.WriteLine(@"   \__/   \_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
                Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("This pocket universe moves fast, "
    + "You will have to move fast as well to keep your new"
    + " friends alive and happy.\n\n");
                Console.WriteLine("What would you like to name your pet?");
                Console.Write("\n>> ");
                usersPet.Name = Console.ReadLine();
                if (usersPet.Name.Length < 12) { break; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static void NameMenu2(Pet usersPet)
        {
            while (true)
            {
                Console.Clear();
                Shelter.DisplayShelter();

                Console.SetCursorPosition(0, Shelter.cursorPos + 3);
                Console.WriteLine("What would you like to name your pet?");
                Console.SetCursorPosition(0, Shelter.cursorPos);
                Console.Write("\n>> ");
                usersPet.Name = Console.ReadLine();
                if (usersPet.Name.Length < 12) { break; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static string NameMenu2()
        {
            while (true)
            {
                Console.Clear();
                Shelter.DisplayShelter();

                Console.SetCursorPosition(0, Shelter.cursorPos + 3);
                Console.WriteLine("What would you like to name your pet?");
                Console.SetCursorPosition(0, Shelter.cursorPos);
                Console.Write("\n>> ");
                string name = Console.ReadLine();
                if (name.Length < 12) { return name; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static void MainMenu(SoundPlayer BgMusic)
        {
            Console.Clear();
            var activeDisplay = ActiveDisplay.DisplayStart(); //pulling the active display from ActiveDisplay class to here
            while (true)
            {
                //Console.Clear();
                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                Shelter.DisplayShelter();
                Console.SetCursorPosition(0, Shelter.cursorPos+3); 
                Console.WriteLine("1. Rename a pet");
                Console.WriteLine("2. Interact with your pets");
                Console.WriteLine("3. Adopt a pet");
                Console.WriteLine("4. Remove a pet");
                Console.WriteLine("5. Earn some money");
                Console.WriteLine("6. Exit");            
                Console.WriteLine("\n\n'a' to play with pet");
                Console.WriteLine("'A' to play with ALL pets");
                Console.WriteLine("'s' to spank pet");
                Console.WriteLine("'S' to spank ALL pets");
                Console.WriteLine("'d' to heal pet with doctor($20)");
                Console.WriteLine("'D' to heal all pets with doctor or mechanic ($1000)");
                Console.WriteLine("'f' to feed a pet ($10)");
                Console.WriteLine("'F' to feed all ($500)");
                Console.WriteLine(" - Use arrow keys to change which pet you are interacting with must have more than one pet");





                ActiveDisplay.DisplayStart((System.Timers.Timer)activeDisplay);//Starts Active Display back up
                var userChoice = Console.ReadKey(true);
                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Display during input


                switch (userChoice.KeyChar)
                {
                    case '1': //Rename a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                            Console.Clear();
                            //Shelter.DisplayShelter();//Static display
                            Console.WriteLine("What pet do you want to rename? ");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            int choice = Shelter.SelectPetMenu();
                            Menus.NameMenu2((Pet)Shelter.GetPet(choice));
                        }
                        else
                        {
                            ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                            Menus.NameMenu2((Pet)Shelter.GetPet(1));
                        }
                        Console.Clear();
                        break;
                    case '2':
                        InteractMenu();
                        break;
                    case '3':  //Adopt a pet
                        if (Shelter.GetShelterSize() <= 4)
                        {
                            ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                            Console.Clear();
                            //Organic or Robotic?
                            string type = Menus.OrganicOrRoboticMenu2();

                            //Go to Job Menu or Species menu depending on if robotic or organic.
                            string subType = "";
                            if (type == "Organic")
                            {
                                subType = Menus.SpeciesMenu2();
                                //Name Pet
                                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                                string name = Menus.NameMenu2();
                                //Add to shelter
                                Shelter.AddOrganicPet(name, subType);
                                Shelter.SpendFromWallet(20000);
                            }
                            else if (type == "Robotic")
                            {
                                subType = Menus.RobotTypeMenu2();
                                //Name Pet
                                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                                string name = Menus.NameMenu2();
                                //Add to shelter
                                Shelter.AddRoboticPet(name, subType);
                                Shelter.SpendFromWallet(100000);
                            }
                            else { subType = ""; }
                            Menus.MainMenu(BgMusic);
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Shelter.DisplayShelter();//Static display
                            Console.SetCursorPosition(0, Shelter.cursorPos+3);
                            Console.WriteLine("Shelter capacity reached. Please remove a pet before adding anymore.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            //Console.SetCursorPosition(0, Shelter.cursorPos);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case '4': //remove a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            Console.Clear();
                            Shelter.DisplayShelter();//Active display

                            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
                            Console.WriteLine("Which Pet do you wish to remove?");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            int selection = Shelter.SelectPetMenu();
                            Shelter.RemovePetFromShelter((Pet)Shelter.GetPet(selection));
                        }
                        else
                        {
                            Console.Clear();
                            Shelter.DisplayShelter();
                            Console.WriteLine("Cannot remove. You must have at least one pet in the shelter.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case '5':
                        Pet pet = (Pet)Shelter.GetPet(1);
                        pet.SetStatus("Working");
                        break;
                    case '6':
                        Environment.Exit(0);
                        break;
                    case '7':
                        Menus.DebugMenu(BgMusic);
                        break;
                    case 'a':
                        pet = (Pet)Shelter.GetPet(Shelter.activePetPos);
                        pet.Play();
                        break;
                    case 'A':
                        for (int i = 0; i < Shelter.GetShelterSize(); i++)
                        {
                            pet =  (Pet)Shelter.GetPet(i + 1);
                            pet.Play();
                        }
                        break;
                    case 's':
                        pet = (Pet)Shelter.GetPet(Shelter.activePetPos);
                        pet.Spank();
                        break;
                    case 'S':
                        for (int i = 0; i < Shelter.GetShelterSize(); i++)
                        {
                            pet = (Pet)Shelter.GetPet(i + 1);
                            pet.Spank();
                        }
                        break;
                    case 'd':
                        pet = (Pet)Shelter.GetPet(Shelter.activePetPos);
                        pet.SeeDoctor();
                        Shelter.SpendFromWallet(20);
                        break;
                    case 'D':
                        for (int i = 0; i < Shelter.GetShelterSize(); i++)
                        {
                            pet = (Pet)Shelter.GetPet(i + 1);
                            pet.SeeDoctor();
                            Shelter.SpendFromWallet(1000);
                        }
                        break;
                    case 'f':
                        pet = (Pet)Shelter.GetPet(Shelter.activePetPos);
                        pet.Feed();
                        Shelter.SpendFromWallet(10);
                        break;
                    case 'F':
                        for (int i = 0; i < Shelter.GetShelterSize(); i++)
                        {
                            pet = (Pet)Shelter.GetPet(i + 1);
                            pet.Feed();
                            Shelter.SpendFromWallet(500);
                        }
                        break;

                    
                }
                //var ch = Console.ReadKey(true).Key;
                switch (userChoice.Key)
                {
                    case ConsoleKey.RightArrow:
                        Shelter.ChangeActivePetRight();
                        break;
                    case ConsoleKey.LeftArrow:
                        Shelter.ChangeActivePetLeft();
                        break;
                }
            ActiveDisplay.DisplayStart((System.Timers.Timer)activeDisplay);
            }
        }
        public static void FeedMenu(Pet usersPet)
        {
            Console.Clear();

            Shelter.DisplayShelter();//Active display

            Console.WriteLine("{0} has eaten!", usersPet.Name);
            Console.WriteLine("Boredom Level has decreased by 10!");
            int prevHungerLevel = usersPet.Hunger;
            usersPet.Feed();
            Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            Console.ReadKey();
        }
        public static void PlayMenu(Pet usersPet)
        {
            Console.Clear();
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("You played with {0}!", usersPet.Name);
            Console.WriteLine("Hunger Level has decreased by 10!");
            int prevBoredomLevel = usersPet.Boredom;
            usersPet.Play();
            Console.WriteLine(prevBoredomLevel + "  >>>  " + usersPet.Boredom);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            Console.ReadKey();
        }
        public static void EarnMoneyMenu()
        {
            Console.Clear();
            Shelter.DisplayShelter();
            Console.WriteLine("This function is still a WIP. \n");
            //Console.WriteLine("{0} has eaten!", usersPet.Name);
            //Console.WriteLine("You earned $0!");
            //int moneyLevel = 0;
            //usersPet.Feed();
            //Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, Shelter.cursorPos); //Active displayy
            Console.ReadKey();
        }
        public static void InteractMenu()
        {
            Console.Clear();
            Shelter.DisplayShelter();//Active display

            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
            Console.WriteLine("1. Interact with all pets");
            Console.WriteLine("2. Choose one pet");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            ConsoleKeyInfo playersChoice = Console.ReadKey(true);
            switch (playersChoice.KeyChar)
            {
                case '1':
                    Shelter.interact();
                    break;
                case '2':
                    Shelter.InteractWithOne();
                    break;
                default:
                    //Clears the input and then goes back to beginning of line.
                    Console.SetCursorPosition(0, Shelter.cursorPos);
                    Console.Write("".PadRight(Console.BufferWidth) + "\r");
                    break;
            }
        }

        public static void DebugMenu(SoundPlayer BgMusic)
        {
            Console.Clear();
            Shelter.DisplayShelter();//Static display
            Console.SetCursorPosition(0, Shelter.cursorPos+3);
            Console.WriteLine("What would you like to debug?");
            Console.WriteLine("1. Kill a pet");
            Console.WriteLine("2. Max out shelter");
            Console.WriteLine("3. Add item for warmth");
            Console.WriteLine("4. Play/Stop Music");
            Console.WriteLine("5. Credit page : Hear from the creators of Virtual Pet: Pocket Universe of madness");
            Console.WriteLine("6. Return to main menu");
            Console.WriteLine("\n");

            Console.SetCursorPosition(0, Shelter.cursorPos);
            ConsoleKeyInfo userChoice = Console.ReadKey(true);

            switch (userChoice.KeyChar)
            {
                case '1':
                    Console.SetCursorPosition(0, Shelter.cursorPos);
                    int choice = Shelter.SelectPetMenu();
                    if (Shelter.GetShelterSize() < 2) { choice = 1; } 
                    Pet pet = (Pet)Shelter.GetPet(choice);
                    pet.SetHealth(0);
                    break;
                case '2':
                   while(Shelter.GetShelterSize() < 5)
                    {
                        Shelter.AddOrganicPet("Tim", "Parrot");
                    }
                    break;
                case '3':
                    Shelter.petClothing();
                    break;
                case '4':
                    if (Shelter.isPlaying == true)
                    { Shelter.StopMusic(BgMusic); Shelter.isPlaying = false; }
                    else { Shelter.PlayMusic(BgMusic); Shelter.isPlaying = true; }
                    break;
                case '5':
                    CreditPage(BgMusic);
                    break;
                default:
                    break;
            }
            Console.Clear();
        }
        public static void CreditPage(SoundPlayer BgMenu)
        {
            Shelter.PlayMusic(BgMenu);
            Console.Clear();
            Console.WriteLine("Thank you for using MAS Code's virtual pet, \n\n"
                + "We hope you had as much fun exploring as we had creating this program.\n\n");
            int line1, line2, line3;
            line1 = line2 = line3 = 5;
            int time = 0;
            bool startMat = false;
            bool startAddison = false;
            System.Timers.Timer tick = new(1000);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function

            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                if (time >= 0)
                {
                    Console.SetCursorPosition(53, (line1 - 1));
                    Console.Write("\r".PadRight(Console.BufferWidth));
                    Console.SetCursorPosition(53, line1);
                    Console.Write("Mathew Cowdery");
                    line1++;
                }

                if (time>=4)
                {
                    Console.SetCursorPosition(53, (line2-1));
                    Console.Write("\r".PadRight(Console.BufferWidth));
                    Console.SetCursorPosition(53, line2);
                    Console.Write(" Addison Reddy");
                    line2++;
                }

                if(time>=8)
                {
                    Console.SetCursorPosition(53, (line3 - 1));
                    Console.Write("\r".PadRight(Console.BufferWidth));
                    Console.SetCursorPosition(53, line3);
                    Console.Write("   Sok Eam");
                    line3++;
                }
                if (time<=16) { time++; }
            }
            Console.ReadKey();
            tick.Stop();
            Console.Clear();
        }
    }
}