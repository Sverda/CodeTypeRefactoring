using System;

namespace RefactorTypeCode.ReplaceWithSubClasses.Enum
{
    static class AfterEnumExtensions
    {
        static double GetElectrolytes(this BloodType type)
        {
            switch (type)
            {
                case BloodType.O:
                    return 15.5;
                case BloodType.A:
                    return 20.1;
                case BloodType.B:
                    return 17.3;
                case BloodType.AB:
                    return 15.9;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
