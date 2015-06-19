namespace TeamworkProjectOOP.GameCore
{
    using System;
    using Characters;
    using UsableObjects;
    using Enumerations;

    public static class SimpleTestExample
    {
        public static void Test()
        {
            //4 actions for character demo

            Warrior testWarrior = new Warrior("war");
            Console.WriteLine(testWarrior);

            //add spell to book
            testWarrior.AddSpell(new Fireball());

            //use spell on itself, health -100
            testWarrior.UseSpell(SpellType.Fireball, testWarrior);

            Console.WriteLine(testWarrior);

            //tries to heal, but spell is not added in book, no change
            testWarrior.UseSpell(SpellType.Healing, testWarrior);

            Console.WriteLine(testWarrior);

            //equips 2 items and improves attack and defence by 50
            testWarrior.AddItem(new Shield());
            testWarrior.AddItem(new Sword());

            Console.WriteLine(testWarrior);

            //enemy spawns and warrior attacks it, reducing health by attack/2 because goblin has too much defence, enemy2 is dead

            Goblin testEnemy = new Goblin();
            Kikimora testEnemy2 = new Kikimora();

            Console.WriteLine(testEnemy);

            testWarrior.Attack(testEnemy);

            testWarrior.Attack(testEnemy2);

            Console.WriteLine(testEnemy);
            Console.WriteLine(testEnemy2);

            //character gained 60xp
            Console.WriteLine(testWarrior);
        }
    }
}
