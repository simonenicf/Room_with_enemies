using System;
using System.Collections.Generic;

namespace Enemy_Room
{
    class Program
    {
        static void Main()
        {
            Room Kamer = new Room();
            Kamer.callAllEnemyLogic();
        }    
    }

    class Room
    {
        public List<Enemy> enemies = new List<Enemy>()
        {
            new Enemy(),
            new Enemy(),
            new Enemy()
        };
        
        public void callAllEnemyLogic()
        {
            foreach (Enemy aEnemy in enemies)
            {
                aEnemy.logic();
            }
        }

    }

    class Enemy
    {
       public void logic()
        {
            // checks if this funcion gets called
            Console.WriteLine("works");
        }

    }
}
