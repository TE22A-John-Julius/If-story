using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;






Console.WriteLine("What would you like to name your character?");

string name = Console.ReadLine().ToLower();


    Console.WriteLine($"Welcome {name}, would you like to play the game?");
    

    string answer = Console.ReadLine().ToLower();

    if (answer == "yes")
    {
        Console.WriteLine("Server Announcement: A Game Admin has spawned in to the game, EVERYONE be wary of him. He possesed the best gear in the game!");
        Console.WriteLine("Would you like to go to the village or to your castle?");

        string location1 = Console.ReadLine().ToLower();

        if (location1 == "village")
        {
            Console.WriteLine("Server Announcement: The gamemaster has teleported into the village");
            Console.WriteLine("Master would you like to craft gear or uppgrade your already existing gear?");
            string equipment = Console.ReadLine().ToLower();
            if (equipment == "craft")
            {  
                Console.WriteLine("You have sucesfully teleported to the local blacksmith");
                Console.WriteLine("Greetings Master, might I entice you in the newest gear?");
                Console.WriteLine("The blacksmith shows you an assortment of weapons, but your attention diverts to the spear and a bow and arrow. New weapons in the game.");
                Console.WriteLine("Do you want to craft the bow or spear?");
                string buy = Console.ReadLine().ToLower();
                if (buy =="bow")
                {
                    Console.WriteLine("You craft the bow and decide to go hunting grounds");
                    Console.WriteLine($"Server Announcement:{name} has sucessfully teleported to the hunting grounds!");
                    Console.WriteLine("You lurk around the bushes awaiting for some prey, you hear rustling leaves right in front of you but you cant see what it is");
                    Console.WriteLine("Do you want to back away or shoot straight through the rustling leaves?");
                }
                else if(buy =="spear")
                {
                    Console.WriteLine("You decide to craft a spear and decide to do to the training grounds");
                    Console.WriteLine($"Server Announcement:{name} has sucessfully teleported to the training grounds!");
                    Console.WriteLine("You walk up to a dummy, would you like to use your strongest or weakest move?");
                    string test = Console.ReadLine().ToLower();
                    if (test == "strongest")
                    {
                        Console.WriteLine("Unfortunately you blew up the whole arena, a fine has been charged on your account. You have nothing left, your rank has been demoted to noob.");
                    }
                    else if (test =="weakest")
                    {
                        Console.WriteLine("You try it out, the dummy explodes and you've now gained +15 levels on your current weapon");
                        Console.WriteLine("You decide to max out the spear in hopes of it becoming a viable weapon for dungeon runs, It takes you the rest of the day.");
                        Console.WriteLine("Exhausted you go to your castle and enjoy a feast with your party members.");
                    }
                    else
                    {
                        Console.WriteLine("Please rerun the program, you have not put in a viable answer.");
                    }
                }
                else
                {
                    Console.WriteLine("Please rerun the program, you have not put in a viable answer.");
                }
            
            }
            else if (equipment == "uppgrade")
            {   
                Console.WriteLine("You already have your gear uppgraded to the max, please wait for a game update to be implemented or craft new gear before uppgrading further.");
            }
            else
            {
                Console.WriteLine("Please rerun the program, you have not put in a viable answer.");
            }
        }

         else if (location1=="castle")
        {
            Console.WriteLine("Isntead of teleporting you decided to take a walk, along the way you enounter a starving wolf, will you slay it or feed it?");
            string wolf = Console.ReadLine().ToLower();
            if (wolf == "slay")
            {
                Console.WriteLine("As you go in for the attack the other wolves in the pack attack you from behind respawning you back to the start.");
            }
            else if (wolf =="feed")
            {
                Console.WriteLine("You open up your inventory and give the wolf a piece of meat from your fresh hunt, you carry it the rest of the way to the castle.");
                Console.WriteLine($"Server announcement:{name} has unlocked a hidden quest, take care of the wolf");
                Console.WriteLine("The wolf is very dirty so it would be smart to bathe it, however you dont know if its injured, would you like to give it a bath or check for injuries");
                string care = Console.ReadLine().ToLower();
                if (care=="give it a bath")
                {
                    Console.WriteLine("Due to an injury the wolf unfortunately bleeds out in the bathtub. You have failed the mission, please retry.");
                }
                else if (care=="check for injuries");
                {
                    Console.WriteLine("Unfortunately you've made it to the end of the beta testing stage of the game, please wait for the game to update to continue further.");
                }
                
                else
                {
                    Console.WriteLine("Please chose a viable answer.");
                }
            }
            else
            {
                Console.WriteLine("Please rerun the program, you have not put in a viable answer.");
            }
        }
        else
  {
      Console.WriteLine("Please rerun the program, you have not put in a viable answer.");
  }
    }
    else if (answer == "no")
    {
        Console.WriteLine($"Have a good day {name}!");
    }
   else
  {
      Console.WriteLine("Please rerun the program, you have not put in a viable answer.");
  }

Console.ReadLine();