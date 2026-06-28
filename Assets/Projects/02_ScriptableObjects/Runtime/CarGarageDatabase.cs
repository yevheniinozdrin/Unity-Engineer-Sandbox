using UnityEngine;

namespace Sandbox.Cars
{
    [CreateAssetMenu(menuName = "Sandbox/Cars/Garage Database", fileName = "GarageDatabase")]
    public class CarGarageDatabase : ScriptableObject
    {
        public CarConfig[] cars;

        public CarConfig GetById(string id)
        {
            foreach (var car in cars)
            {
                if (car != null && car.id == id)
                    return car;
            }

            return null;
        }
    }
}