

namespace DelegateRealSceneriao
{
     class UserProfile
    {
        public string Name;
        public int Age;
        public double Salary;
        public double Experience;

        public UserProfile()
        {
          
        }

        public UserProfile(string name, int age, double salary, double experience)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Experience = experience;
        }

        public static int CompareByName(object objA , object objB)
        {
            if(objA is UserProfile && objB is UserProfile)
            {
                UserProfile lu = (UserProfile)objA;
                UserProfile ru = (UserProfile)objB;

                return lu.Name.CompareTo(ru.Name);
            }
            return 0;
        }
    }
}
