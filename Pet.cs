using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        private string name = "";
        private string type = "";
        private string species = "";
        private int health = 60;
        private int hunger = 0;
        private int boredom = 0;
        private string condition = "Good";
        private int conditionPoints = 5;
        private string status = "Resting";
        private int income = 0;

        public string Name { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public string Condition { get; set; }
        public int ConditionPoints { get; set; }
        public string Status { get; set; }
        public int Income { get; set; }

        public Pet()
        {
            Name = name;
            Type = type;
            Species = species;
            Health = health;
            Hunger = hunger;
            Boredom = boredom;
            Condition = condition;
            ConditionPoints = conditionPoints;
            Status = status;
            Income = income;
        }
        public void SetType(string type) { Type = type; }
        public void SetHealth(int health) { Health = health; }
        public void SetHunger(int hunger) { Hunger = hunger; }
        public void SetCondition(string condition) { Condition = condition; }
        public void IncreaseConditionPoints() { if (ConditionPoints < 20) { ConditionPoints++; } }
        public void DecreaseConditionPoints() { if (ConditionPoints > 0) { ConditionPoints--; } }
        public void SetStatus(string status) { Status = status; }
        public void SetIncome(int income) { Income = income; }
        public string GetName() { return Name; }
        public string GetSpecies() { return Species; }
        public int GetHealth() { return Health; }
        public int GetHunger() { return Hunger; }
        public int GetBoredom() { return Boredom; }
        public string GetCondition() { return Condition; }
        public int GetConditionPoints() { return ConditionPoints; }
        public string GetStatus() { return Status; }

        public string PaddedName()
        {
            string PaddedName = Name;
            int namePadAmount = Name.Length + (14 - Name.Length);
            PaddedName = PaddedName.PadLeft(namePadAmount);
            return PaddedName;
        }
        public string PaddedSpecies()
        {
            string PaddedSpecies = Species;
            int namePadAmount = Species.Length + (11 - Species.Length);
            PaddedSpecies = PaddedSpecies.PadLeft(namePadAmount);
            return PaddedSpecies;
        }
        public void Feed()
        {
            if ( Hunger >= 10)
            {
                Hunger -= 10;
            }
            if (Hunger < 10 && Hunger > 0)
            {
                Hunger = 0;
            }
        }
        public void Play()
        {
            if (Boredom >= 10)
            {
                Boredom -= 10;
            }
            if (Boredom < 10 && Boredom > 0)
            {
                Boredom = 0;
            }
            if (Hunger <= 58)
            {
                Hunger += 2;
            }
            if (Hunger < 60 && Hunger > 58)
            {
                Hunger = 60;
            }
        }
        public void SeeDoctor()
        {
            if (Health <= 50)
            {
                Health += 10;
            }
            if (Health < 60 && Health > 50)
            {
                Health = 60;
            }
        }
        public void Spank()
        {
            if (Shelter.BadActions.Contains(GetStatus())){ IncreaseConditionPoints(); }
                else { DecreaseConditionPoints(); }
        }
        public void DisplayStatus()
        {
            Console.WriteLine(Name + " The " + Species + ":");
            Console.WriteLine("Health - " + Health + "\n" + "Hunger - " + Hunger + "\n" + "Boredom - " + Boredom + "\n");
        }
        public virtual void Tick()
        {
            //overridden by childs
        }
    }
}



