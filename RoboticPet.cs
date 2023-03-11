using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class RoboticPet : Pet
    {
        public RoboticPet()
        {
            SetType("Robotic");
            SetHealth(100);
            SetHunger(100);
            SetStatus("Charging");
        }
        public override void Tick()
        {
            int time = 0;
            System.Timers.Timer tick = new(500);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function

            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {

                time++;
                Shelter.AddToWallet(Income);
                Random rnd = new Random();
                if (Status == "Charging" && Hunger <= 100 )
                { Hunger += 20; }
                else
                {
                    if (time % 2 == 0)  //only increase every other tick.
                    {
                        Hunger -= 1;
                    }
                }
                if (Hunger < 0) { Hunger = 0; }
                if (Hunger > 100) { Hunger = 100; }
                if (Hunger == 100) { SetStatus("Beeping"); }
                if (Hunger < 20) { SetStatus("Charging"); }
                if (Health <= 0)
                {
                    tick.Stop();
                    tick.Dispose();
                    SetStatus("BROKEN");
                    Console.Clear();
                    //Shelter.DisplayShelter();
                    Console.SetCursorPosition(0, Shelter.cursorPos);
                    Console.WriteLine("OOH NOOOO...." + Name + " The " + Species + " Died!!\nYou have to pay attention and move quicker next time.\nGAME OVER");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (GetCondition() != "Starv")
                {
                    if (GetConditionPoints() >= 0 && GetConditionPoints() <= 5) { SetCondition("Bad"); }
                    if (GetConditionPoints() >= 6 && GetConditionPoints() <= 10) { SetCondition("Good"); }
                    if (GetConditionPoints() >= 11 && GetConditionPoints() <= 15) { SetCondition("Great"); }
                    if (GetConditionPoints() >= 16 && GetConditionPoints() <= 20) { SetCondition("Excel"); }
                }

                //Set Income based on Condition of pet
                if (GetCondition() == "Starv") { SetIncome(-10); }
                if (GetCondition() == "Bad") { SetIncome(-5); }
                if (GetCondition() == "Good") { SetIncome(5); }
                if (GetCondition() == "Great") { SetIncome(10); }
                if (GetCondition() == "Excellent") { SetIncome(20); }

                if (time % rnd.Next(5, 15) == 0)
                {
                    switch (rnd.Next(1, 30))
                    {
                        case 1:
                            SetStatus("Beeping"); break; //
                        case 2:
                            SetStatus("Breaking"); break;
                        case 3:
                            SetStatus("Updating"); break;
                        case 4:
                            SetStatus("Cleaning"); break;
                        case 5:
                            SetStatus("Hacking"); break; //bad
                        case 6:
                            SetStatus("Programming"); break;
                        case 7:
                            SetStatus("Computing"); break; //exercise
                        case 8:
                            SetStatus("Rusting"); break;
                        case 9:
                            SetStatus("Staring"); break; //bad
                        case 10:
                            SetStatus("Loading"); break;
                        case 11:
                            SetStatus("Working"); break;
                        case 12:
                            SetStatus("Planning"); break;
                        case 13:
                            SetStatus("Googling"); break;
                        case 14:
                            SetStatus("Protecting"); break;
                        case 15:
                            SetStatus("Broadcasting"); break; //casting podcasting
                        case 16:
                            SetStatus("Erroring"); break;
                        case 17:
                            SetStatus("Merging"); break;
                        case 18:
                            SetStatus("Git Add..."); break;
                        case 19:
                            SetStatus("Git Commit..."); break;
                        case 20:
                            SetStatus("Git Push..."); break;
                        case 21:
                            SetStatus("Scheming"); break; //bad
                        case 22:
                            SetStatus("Laughing"); break; //bad
                        case 23:
                            SetStatus("Plotting"); break; //bad
                        case 24:
                            SetStatus("Stealing"); break; //bad
                        case 25:
                            SetStatus("Threatening"); break; //bad
                        case 26:
                            SetStatus("Defrauding"); break; //bad
                        case 27:
                            SetStatus("Meditating"); break; //bad
                        case 28:
                            SetStatus("Escaping"); break; //bad
                        case 29:
                            SetStatus("Terrorism"); break; //bad
                        case 30:
                            SetStatus("Espionage"); break; //bad
                    }
                }
            }
        }
    }
}
