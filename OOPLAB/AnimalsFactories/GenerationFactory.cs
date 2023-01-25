using System.Drawing;
namespace OOPLAB
{
    class GenerationFactory : IGeneration
    {
       private IGeneration? _animalFactory;
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
            _animalFactory.Generation(map, Coordinate);
        }

        public void SetFactory(IGeneration animalFactory)
        {
            _animalFactory = animalFactory;
        }
    }
}

