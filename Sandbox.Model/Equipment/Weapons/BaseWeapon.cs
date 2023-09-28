using Sandbox.Model.Equipment.Enums;

namespace Sandbox.Model.Equipment.Weapons
{
    public class BaseWeapon
    {
        private Material _material;

        public Material Material 
        { 
            get => _material;
        }

        public BaseWeapon(Material material)
        {
            _material = material;
        }
    }
}
