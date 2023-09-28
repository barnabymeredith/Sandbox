using Sandbox.Model.Equipment.Weapons;

namespace Sandbox.Model.Characters
{
    public class Spearman : BaseCharacter
    {
        private Spear? _spear;

        public Spear? Spear { get => _spear; set => _spear = value; }

        public Spearman(int healthPoints) : base(healthPoints)
        {
           
        }
    }
}
