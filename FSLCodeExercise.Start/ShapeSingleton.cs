using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSLCodeExercise.Start
{
    public class ShapeSingleton
    {

        

        private static ShapeSingleton _instance;

        public static ShapeSingleton Instance {
            get
            {
                if (_instance == null)
                    _instance = new ShapeSingleton();
                return _instance;
            }
        }

        ShapeSingleton() { }

        public double CalculateArea(int type, double width)
        {
            switch (type)
            {
                case ShapeTypes.SQUARE:
                    return width * width;
                case ShapeTypes.CIRCLE:
                    return Math.PI * (width / 2) * (width / 2);
                case ShapeTypes.EQUILATERAL_TRIANGLE:
                    return (Math.Sqrt(4) / 3) * width * width;
                default:
                    throw new InvalidProgramException("Unknown shape type encountered: " + type);
            }

        }
    }
}
