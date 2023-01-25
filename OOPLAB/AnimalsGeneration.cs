using System.Drawing;
namespace OOPLAB
{
    class AnimalsGeneration
    {
        private Random RandomX = new Random();  
        private Random RandomY = new Random();  
        private int DataFromUser;
        public AnimalsGeneration(List<GameObject>[,] map, int _mapLenght)
        {
            GenerateAnimals(map, _mapLenght);                                                       
        }
        public int UserNumber()
        {
            int DataFromUser = int.Parse(Console.ReadLine()) ;
            return DataFromUser;
        }
      
        private void GenerateAnimals(List<GameObject>[,] map, int _mapLenght)
        {
            GenerationFactory factory = new GenerationFactory();
            Point CoordOfAnimal = new Point(0, 0);
            int DataNew;

            factory.SetFactory(new BearFactory());
            Console.WriteLine("Print start number of Bears:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new HyenaFactory());
            Console.WriteLine("Print start number of Hyenas:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new TigerFactory());
            Console.WriteLine("Print start number of Tigers:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new WolfFactory());
            Console.WriteLine("Print start number of Wolfs:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new BullFactory());
            Console.WriteLine("Print start number of Bulls:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new CowFactory());
            Console.WriteLine("Print start number of Cows:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new RabbitFactory());
            Console.WriteLine("Print start number of Rabbits:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);

            factory.SetFactory(new SheepFactory());
            Console.WriteLine("Print start number of Sheeps:");
            DataNew = UserNumber();     
            Setter(factory, DataNew, CoordOfAnimal, _mapLenght, map);
        }
        private void Setter(GenerationFactory factory, int DataNew, Point CoordOfAnimal, int _mapLenght, List<GameObject>[,] map)
        {
                for(int i = 0; i < DataNew; i++)
            {
                CoordOfAnimal.X = RandomX.Next(0, _mapLenght);
                CoordOfAnimal.Y = RandomY.Next(0, _mapLenght);
                factory.Generation(map, CoordOfAnimal);
            }
        }
    }
}