namespace RefactorTypeCode.ReplaceWithSubClasses
{
    class Person
    {
        public static int O = 0;
        public static int A = 1;
        public static int B = 2;
        public static int AB = 3;

        public Person(int typeCode)
        {
            TypeCode = typeCode;
        }

        public int TypeCode { get; }
    }

    static class PersonFactory
    {
        static Person[] Generate()
        {
            var persons = new Person[]
            {
                new Person(Person.A),
                new Person(Person.B)
            };
            return persons;
        }
    }
}
