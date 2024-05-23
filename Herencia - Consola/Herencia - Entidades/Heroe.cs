using System.Text;

namespace Herencia___Entidades
{
    public abstract class Heroe
    {
        protected decimal mana;
        private decimal vida;
        private int stamina;
        private string nombre;
        private Skills skill;
        private List<Skills> skills;

        public Skills this[int i]
        {
            get { return skills[i]; }
        }

        public Skills this[Skills skill]
        {
            get
            {
                if (skills.Contains(skill))
                {
                    return skill;
                }

                return Skills.Golpe;
            }
        }

        public Heroe(decimal vida, decimal mana, int stamina, string nombre)
        {
            this.vida = vida;
            this.mana = mana;
            this.stamina = stamina;
            Nombre = nombre;
            skills = new List<Skills>();
            skills.Add(Skills.LanzarArma);
            skills.Add(Skills.Agacharse);
            this.skill = Skills.LanzarArma;
        }

        #region Propiedades
        public string Nombre
        {
            get { return nombre; }
            private set
            {
                if (value.Length > 3)
                {
                    nombre = value;
                }
                else
                {
                    nombre = "Heroe";
                }
            }
        }

        public decimal Vida { get => vida; set => vida = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public Skills Skill { get => skill; set => skill = value; }
        #endregion


        public override bool Equals(object? obj)
        {
            return obj is Heroe h && h.nombre == this.nombre;
        }

        public abstract string Ataque_02();

        public virtual string Ataque_01()
        {
            return $"Ataque basico: {new Random().Next(1, 100)}";
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Vida: {vida}");
            sb.AppendLine($"Mana: {mana}");
            sb.AppendLine($"Stamina: {stamina}");

            return sb.ToString();
        }
    }
}