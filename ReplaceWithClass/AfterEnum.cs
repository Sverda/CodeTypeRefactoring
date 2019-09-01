namespace RefactorTypeCode.ReplaceWithClass.AfterEnum
{
    enum BloodType
    {
        O,
        A,
        B,
        AB
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
            BloodType = (BloodType)code;
        }
    }
}
