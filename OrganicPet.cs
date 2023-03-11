using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class OrganicPet : Pet
    {
        public OrganicPet()
        {
            SetType("Organic");
            SetIncome(5);
        }
        public override void Tick()
        {
            Random rnd = new Random();
            int time = 0;

            System.Timers.Timer tick = new(500);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function

            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                time++;
                Shelter.AddToWallet(Income);
                if (GetStatus() == "Resting")
                {
                    Boredom += 1;
                    if (time % 4 == 0)  //only increase every other tick.
                    {
                        Hunger += 1;
                        if (Health < 60) { Health += 1; } //resting increases health a little, but not as much as starving decreases it.
                    }
                }
                if (Shelter.StressfulActions.Contains(GetStatus()))
                {
                    if (Hunger < 60) { Hunger += 1; }
                    if (time % 4 == 0 && Boredom < 60)  //only increase every other tick.
                    {
                        Boredom += 1;
                    }

                }

                if ( Hunger < 0)
                {
                    Hunger = 0; 
                }
                if (Hunger >= 60)
                {
                    Hunger = 60;
                    SetCondition("Starving");
                }   
                else if (Hunger < 60)
                {
                    SetCondition("Good");
                }
                if (Boredom >= 60)
                {
                    Boredom = 60;
                }
                if (GetCondition()=="Starving")
                {
                    Health -= 2;
                }

                if (Health <= 0)
                {
                    Health = 0;
                    tick.Stop();
                    tick.Dispose();
                    SetStatus("DEAD");
                    SetCondition("DEAD");
                    Console.Clear();
                    //Shelter.DisplayShelter();
                    Console.SetCursorPosition(0, Shelter.cursorPos + 3);
                    Console.WriteLine("OOH NOOOO...." + Name + " The " + Species + " Died!!\nYou have to pay attention and move quicker next time.");
                    Console.WriteLine("\nPress any key to continue...");

                    Console.ReadKey();
                    Console.Clear();
                }

                //Get ConditionPoints
                if (GetCondition() != "Starving")
                {
                    if (GetConditionPoints() >= 0 && GetConditionPoints() <= 5) { SetCondition("Bad"); }
                    if (GetConditionPoints() >= 6 && GetConditionPoints() <= 10) { SetCondition("Good"); }
                    if (GetConditionPoints() >= 11 && GetConditionPoints() <= 15) { SetCondition("Great"); }
                    if (GetConditionPoints() >= 16 && GetConditionPoints() <= 20) { SetCondition("Excel"); }
                }

                //Set Income based on Condition of pet
                if (GetCondition() == "Starving") { SetIncome(-10); }
                if (GetCondition() == "Bad") { SetIncome(-5); }
                if (GetCondition() == "Good") { SetIncome(5); }
                if (GetCondition() == "Great") { SetIncome(10); }
                if (GetCondition() == "Excellent") { SetIncome(20); }

                //Changes Pet Status
                if (time % rnd.Next(5, 15) == 0)
                {
                    switch (rnd.Next(1, 27))
                    {
                        case 1:
                            SetStatus("Playing"); break; //
                        case 2:
                            SetStatus("Garbage"); break;  //bad money starts ticking negative
                        case 3:
                            SetStatus("Jumping"); break;
                        case 4:
                            SetStatus("Rolling"); break;
                        case 5:
                            SetStatus("Sleeping"); break;
                        case 6:
                            SetStatus("Resting"); break;
                        case 7:
                            SetStatus("Yarn"); break; //exercise
                        case 8:
                            SetStatus("RanAway"); break; //bad
                        case 9:
                            SetStatus("Fighting"); break;//
                        case 10:
                            SetStatus("Scratching"); break;//
                        case 11:
                            SetStatus("Breaking"); break;//
                        case 12:
                            SetStatus("Peeing"); break;//
                        case 13:
                            SetStatus("Pooping"); break;//
                        case 14:
                            SetStatus("Hunting"); break;
                        case 15:
                            SetStatus("Purring"); break; //good
                        case 16:
                            SetStatus("Protecting"); break;
                        case 17:
                            SetStatus("Itching"); break;
                        case 18:
                            SetStatus("Cleaning"); break;
                        case 19:
                            SetStatus("Sprinting"); break;
                        case 20:
                            SetStatus("Mingling"); break;
                        case 21:
                            SetStatus("Bored"); break;
                        case 22:
                            SetStatus("Chasing"); break;
                        case 23:
                            SetStatus("Spelunking"); break;
                        case 24:
                            SetStatus("Acting"); break;
                        case 25:
                            SetStatus("Wooing"); break;
                        case 26:
                            SetStatus("Rolling"); break;
                        case 27:
                            SetStatus("Prancing"); break;
                    }
                }
            }
        }
    }
}
