namespace RefactorTypeCode.ReplaceWithSubClasses.Class
{
    abstract partial class BloodType
    {
        public abstract double Electrolytes { get; }
    }

    partial class BloodTypeO : BloodType
    {
        public override double Electrolytes { get; } = 15.5;
    }

    partial class BloodTypeA : BloodType
    {
        public override double Electrolytes { get; } = 20.1;
    }

    partial class BloodTypeB : BloodType
    {
        public override double Electrolytes { get; } = 17.3;
    }

    partial class BloodTypeAB : BloodType
    {
        public override double Electrolytes { get; } = 15.9;
    }
}
