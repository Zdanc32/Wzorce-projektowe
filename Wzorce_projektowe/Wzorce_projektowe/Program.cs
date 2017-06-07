using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce_projektowe.Singleton;
using Wzorce_projektowe.Builder;
using Wzorce_projektowe.Dekorator;
using Wzorce_projektowe.Strategy;
using Wzorce_projektowe.FactoryMethod;

namespace Wzorce_projektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string chose;
            bool loop = true;
            do
            {
                
                Console.WriteLine("Wybierz wrzocec do przetestowania. \n [ 1 ] Singleton \n [ 2 ] Builder \n [ 3 ] Dekorator \n [ 4 ] Factory Method \n [ 5 ] Strategy \n wybierz: ");
                chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        Console.WriteLine("Test dla Singletona");
                        for (int nCounter = 0; nCounter < 10; ++nCounter)
                        {
                            Console.WriteLine("Sertwer {0}", nCounter + 1);
                            SerwerSingletonLocks.Instance.DoSomething();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Test dla Buildera");
                        ArcaneMage arcaneSourcer = new ArcaneMage();
                        Directory director = new Directory(arcaneSourcer);
                        director.createMage();
                        Sourcer sourcerOne = director.getMage();
                        sourcerOne.showMage();

                        FrostMage frostSourcer = new FrostMage();
                        Directory director2 = new Directory(frostSourcer);
                        director2.createMage();
                        Sourcer sourcerTwo = director.getMage();
                        sourcerOne.showMage();
                        break;
                    case "3":
                        Console.WriteLine("Test dla Dekoratora");
                        Person p1 = new EliteWarrior();
                        Person p2 = new Dekorator.Warrior();

                        Console.WriteLine("\nBez wyposazenia");
                        Console.WriteLine(p1.about() + " \nsiła: " + p1.attackPower());
                        Console.WriteLine(p2.about() + " \nsiła: " + p2.attackPower());

                        //dodajemy po mieczu

                        p1 = new Sword(p1);
                        p2 = new Sword(p2);
                        Console.WriteLine("\nZ Mieczem");
                        Console.WriteLine(p1.about() + " \nsiła: " + p1.attackPower());
                        Console.WriteLine(p2.about() + " \nsiła: " + p2.attackPower());

                        // i tarczy

                        p1 = new Shield(p1);
                        p2 = new Shield(p2);
                        Console.WriteLine("\nZ tarczą");
                        Console.WriteLine(p1.about() + " \nsiła: " + p1.attackPower());
                        Console.WriteLine(p2.about() + " \nsiła: " + p2.attackPower());

                        //odrazu tworzymy wojownika elitarnego ze wszystkim.
                        Console.WriteLine("\nPelne wyposazenie");
                        Person p3 = new Shield(new Sword(new EliteWarrior()));
                        Console.WriteLine(p3.about() + " \nsiła: " + p3.attackPower());

                        break;
                    case "4":
                        Console.WriteLine("Test dla Factory Method");
                        Creator[] players = new Creator[2];

                        players[0] = new MageCreator();
                        players[1] = new WarriorCreator();

                        // Display document pages
                        foreach (Creator player in players)
                        {
                            Console.WriteLine("\n" + player.GetType().Name + "--");
                            foreach (Skill skill in player.Skills)
                            {
                                Console.WriteLine(" " + skill.GetType().Name);
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Test dla Strategy");
                        Context context1 = new Context(new StrategyMethodA());
                        Context context2 = new Context(new StrategyMethodB());
                        context1.ContextInterface();
                        context2.ContextInterface();
                        break;
                    case "6":
                        loop = false;
                        break;
                    default:
                        loop = false;
                        break;
                } 
            } while (false != loop);
        }
    }
}
