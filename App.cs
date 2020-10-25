using System;
using System.Collections.Generic;

namespace Character {
    class App {

        Player player = new Player ("Hero", 100, 20, 0, 0, 0);
        Monster monster = new Monster ("John", 100, 10, 0, "Penguin");

         public void DeadChar(){
            if (player.Health == 0){
                Console.WriteLine("Player died");
                
            }else{
                Console.WriteLine("Monster died");
            }
        }

        public void Run () {
          
           

           do{
               Console.WriteLine("--------------");
               player.Damage();
               player.DisplayStats();
               
               monster.Damage();
               monster.DisplayStats();

               
           }
           while(player.Health > 0 && monster.Health > 0 );
           
               Console.WriteLine("bye bye");
               DeadChar();

        }

        

    }

}