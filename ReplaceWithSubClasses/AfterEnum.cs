namespace RefactorTypeCode.ReplaceWithSubClasses.Enum
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

        public BloodType BloodType { get; }
    }

    static class PersonFactory
    {
        static Person[] Generate()
        {
            var persons = new Person[]
            {
                new Person(BloodType.A),
                new Person(BloodType.B)
            };
            return persons;
        }
    }
}
