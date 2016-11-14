namespace TriangleTracker.Objects
{
    public class Triangle
    {
        private int _side1;
        private int _side2;
        private int _side3;

        public void Triangle(userSide1, userSide2, userSide3)
        {
            _side1 = userSide1;
            _side2 = userSide2;
            _side3 = userSide3;
        }

        public string GetTriangleType() {
            if ((_side1 + _side2 > _side3) || (_side1 + _side3 > _side2) || (_side2 + side3 > _side1)) {
                if (_side1 == _side2)
                {
                    if (_side2 == _side3)
                    {
                        return "Equilateral";
                    }
                    else
                    {
                        return "Isoceles";
                    }
                }
                else if (_side2 == _side3 || _side1 == _side3)
                {
                    return "Isoceles";
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
