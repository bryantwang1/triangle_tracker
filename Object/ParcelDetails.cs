namespace Parcel.Objects
{
    public class ParcelObject
    {
        private string _name;
        private int _weight;
        private int _height;
        private int _width;
        private int _length;
        private int _volume;

        public ParcelObject(string parcelName, int parcelWeight, int parcelHeight, int parcelWidth, int parcelLength)
        {
            _name = parcelName;
            _weight = parcelWeight;
            _height = parcelHeight;
            _width = parcelWidth;
            _length = parcelLength;
            _volume = _height * _width * _length;
        }

        public string GetName() {
            return _name;
        }

        public void SetName(string parcelName) {
            _name = parcelName;
        }

        public int GetWeight() {
            return _weight;
        }

        public void SetWeight(int parcelWeight) {
            _weight = parcelWeight;
        }

        public int GetHeight() {
            return _height;
        }

        public void SetHeight(int parcelHeight) {
            _height = parcelHeight;
        }

        public int GetWidth() {
            return _width;
        }

        public void SetWidth(int parcelWidth) {
            _width = parcelWidth;
        }

        public int GetLength() {
            return _length;
        }

        public void SetLength(int parcelLength) {
            _length = parcelLength;
        }

        public int GetVolume() {
            return _volume;
        }

        public double GetCostToShip() {
            return _volume * _weight * .4;
        }
    }
}
