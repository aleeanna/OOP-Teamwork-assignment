namespace TeamworkProjectOOP.Characters
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Interfaces;
    using UsableObjects;
    using Enumerations;
    using System.Linq;

    public abstract class PlayableCharacter : Character, IPlayableCharacter
    {
        private string name;

        protected PlayableCharacter(string name, int hitPoints, int attackPoints, int defencePoints)
            : base(hitPoints, attackPoints, defencePoints)
        {
            this.Name = name;
            this.Inventory = new List<Item>();
            this.SpellBook = new List<ISpell>();
        }

        public List<Item> Inventory { get; set; }
        public List<ISpell> SpellBook { get; set; }
        public int ExperiencePoints { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Character name cannot be empty");
                }

                this.name = value;
            }

        }

        public override string ToString()
        {
            StringBuilder characterSheet = new StringBuilder();

            characterSheet.AppendLine(string.Format("Character name: {0}", this.Name));
            characterSheet.AppendLine(string.Format("Health: {0}", this.HitPoints));
            characterSheet.AppendLine(string.Format("Attack: {0}", this.AttackPoints));
            characterSheet.AppendLine(string.Format("Defence: {0}", this.DefensePoints));
            characterSheet.AppendLine(string.Format("Experience: {0}", this.ExperiencePoints));

            return characterSheet.ToString();
        }

        public void Attack(IEnemy enemy)
        {
            if (this.AttackPoints > enemy.DefensePoints)
            {
                enemy.HitPoints -= this.AttackPoints;
            }
            else
            {
                enemy.HitPoints -= this.AttackPoints / 2;
            }

            if (enemy.HitPoints <= 0)
            {
                this.ExperiencePoints += enemy.Experience;
                enemy.HitPoints = 0;
            }


        }

        public void UseSpell(SpellType spell, ICharacter character)
        {
            ISpell spellToCast = SpellBook.FirstOrDefault(sp => sp.SpellType == spell);

            if (spellToCast != null)
            {
                spellToCast.Cast(character);
            }
        }

        public void AddItem(Item item)
        {
            this.Inventory.Add(item);
            this.AttackPoints += item.AttackPoints;
            this.DefensePoints += item.DefensePoints;
        }

        public void AddSpell(ISpell spell)
        {
            this.SpellBook.Add(spell);
        }
    }
}
