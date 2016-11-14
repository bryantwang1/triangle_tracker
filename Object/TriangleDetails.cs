namespace TriangleTracker.Objects
{
    public class Triangle
    {
        private int _side1;
        private int _side2;
        private int _side3;

        public Triangle(int userSide1, int userSide2, int userSide3)
        {
            _side1 = userSide1;
            _side2 = userSide2;
            _side3 = userSide3;
        }

        public string GetTriangleType() {
            if ((_side1 + _side2 > _side3) && (_side1 + _side3 > _side2) && (_side2 + _side3 > _side1))
            {
                if (_side1 == _side2)
                {
                    if (_side2 == _side3)
                    {
                        return "Equilateral";
                    }
                    else
                    {
                        return "Isosceles";
                    }
                }
                else if (_side2 == _side3 || _side1 == _side3)
                {
                    return "Isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            else
            {
                return "Not a triangle";
            }
        }
    }
}
