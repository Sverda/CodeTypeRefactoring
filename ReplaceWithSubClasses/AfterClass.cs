namespace RefactorTypeCode.ReplaceWithSubClasses.Class
{
    abstract partial class BloodType
    {
    }

    partial class BloodTypeO : BloodType
    {
    }

    partial class BloodTypeA : BloodType
    {
    }

    partial class BloodTypeB : BloodType
    {
    }

    partial class BloodTypeAB : BloodType
    {
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
                new Person(new BloodTypeA()),
                new Person(new BloodTypeB())
            };
            return persons;
        }
    }
}
