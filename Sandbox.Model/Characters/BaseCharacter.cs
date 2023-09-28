namespace Sandbox.Model.Characters
{
    public class BaseCharacter
    {
        private const int MinimumHealthPoints = 0;
        private int _healthPoints;

        public int HealthPoints 
        { 
            get => _healthPoints;
            set 
            {
                if (value > MinimumHealthPoints)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(null, $"A character's health points must be higher than the minimum health points ({MinimumHealthPoints}).");
                }
            }
        }

        protected BaseCharacter(int healthPoints)
        {
            _healthPoints = healthPoints;
        }
    }
}
