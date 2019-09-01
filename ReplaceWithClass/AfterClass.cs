namespace RefactorTypeCode.ReplaceWithClass.AfterClass
{
    class BloodType
    {
        public static BloodType O = new BloodType(0);
        public static BloodType A = new BloodType(1);
        public static BloodType B = new BloodType(2);
        public static BloodType AB = new BloodType(3);
        private static readonly BloodType[] _bloodTypes = new BloodType[] { O, A, B, AB };

        private BloodType(int code)
        {
            Code = code;
        }

        public int Code { get; }

        public static BloodType Factory(int code)
        {
            return _bloodTypes[code];
        }
    }

    class Person
    {
        public Person(BloodType type)
        {
            BloodType = type;
        }

        public BloodType BloodType { get; private set; }

        public void SetBloodTypeWithCode(int code)
        {
            BloodType = BloodType.Factory(code);
        }
    }
}
