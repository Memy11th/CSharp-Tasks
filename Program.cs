namespace Assignment_Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region People
            //Console.WriteLine("Hello, World!");
            //Weekdays Obj = new Weekdays();
            //Obj.GetWeekDays();
            //Person[] people = new Person[3];
            //people[0] = new Person(24, "Shatha");
            //people[1] = new Person(27, "Memy");
            //people[2] = new Person(29, "Marwa");

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person);
            //} 
            #endregion

            #region Seasons task
            //Console.WriteLine("Enter the desired season");
            //string EnteredSeason = Console.ReadLine();

            //if (Enum.TryParse(EnteredSeason, true, out Seasons SelectedSeason))
            //{
            //    string Month = GetMonthRange(SelectedSeason);
            //    Console.WriteLine(Month);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name");
            //}

            //string GetMonthRange(Seasons season)
            //{
            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            return "From March to May";
            //        case Seasons.Summer:
            //            return "From June to August";
            //        case Seasons.Winter:
            //            return "From December to February";
            //        case Seasons.Autumn:
            //            return "From Septemper to November";
            //        default:
            //            return "Unknown";

            //    }
            //}

            #endregion

            #region Permissions
            //// Initial permissions
            //Permissions UserPermission = Permissions.None;
            //Console.WriteLine(UserPermission);
            //// Add Execute 
            //UserPermission = Permissions.Execute;
            //Console.WriteLine(UserPermission);
            //// Add Delete
            //UserPermission |= Permissions.Delete;
            //Console.WriteLine(UserPermission);
            //// Remove Execute
            //UserPermission ^= Permissions.Execute;
            //Console.WriteLine(UserPermission);
            //// Add Read
            //UserPermission |= Permissions.Read;
            //Console.WriteLine(UserPermission);
            //// Add Execute
            //UserPermission |= Permissions.Execute;
            //Console.WriteLine(UserPermission);
            //// Add Write
            //UserPermission |= Permissions.Write;
            //Console.WriteLine(UserPermission);
            //// Remove all and leave Read
            //UserPermission &= Permissions.Read;
            //Console.WriteLine(UserPermission);
            //// Toggle for read
            //UserPermission ^= Permissions.Read;
            //Console.WriteLine(UserPermission);



            #endregion

            #region PrimaryColors

            //bool IsValid = false;
            //do
            //{
            //    Console.WriteLine("Enter the desired color");
            //    string EnteredColor = Console.ReadLine();
            //    if (Enum.TryParse(EnteredColor, true, out PrimaryColors ParsedColor))
            //    {
            //        foreach (PrimaryColors color in Enum.GetValues(typeof(PrimaryColors)))
            //        {
            //            if (ParsedColor == color)
            //            {
            //                Console.WriteLine($"Matched Color , The entered color is primary color {ParsedColor}");
            //                IsValid = true;
            //                break;
            //            }
            //        }
            //    }
            //}while (!IsValid);



            #endregion

            #region Point
            //Console.WriteLine("Write the X for the first point");
            //double X1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Write the Y for the first point");
            //double Y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Write the X for the second point");
            //double X2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Write the Y for the second point");
            //double Y2 = Convert.ToDouble(Console.ReadLine());

            //Point Point1 = new Point(X1, Y1);
            //Point Point2 = new Point(X2, Y2);
            //double Distance = GetDistance(Point1, Point2);
            //Console.WriteLine($"The distance between the point {Point1} and the point {Point2} is {Distance}");

            //static double GetDistance(Point Point1, Point Point2)
            //{
            //    double dx = Point2.X - Point1.X;
            //    double dy = Point2.Y - Point1.Y;

            //    return dx * dx + dy * dy;
            //}
            #endregion

            #region Person Age Comparing
            PersonAge[] Persons = new PersonAge[3];
            // Person 1
            Console.WriteLine("Enter the name for the first person");
            string PName1 = Console.ReadLine();
            Console.WriteLine("Enter the age for the first person");
            bool IsValid1 = int.TryParse(Console.ReadLine(),out int PAge1) ;
            // Person 2
            Console.WriteLine("Enter the name for the second person");
            string PName2 = Console.ReadLine();
            Console.WriteLine("Enter the age for the second person");
            bool IsValid2 = int.TryParse(Console.ReadLine(), out int PAge2);
            // Person 3
            Console.WriteLine("Enter the name for the third person");
            string PName3 = Console.ReadLine();
            Console.WriteLine("Enter the age for the third person");
            bool IsValid3 = int.TryParse(Console.ReadLine(), out int PAge3);

            // Protective code
            if(IsValid1 && IsValid2 && IsValid3 && PName1 is not null && PName2 is not null && PName3 is not null)
            {
                Persons[0]=  new PersonAge(PAge1, PName1);
                Persons[1] = new PersonAge(PAge2, PName2);
                Persons[2] = new PersonAge(PAge3, PName3);

                int Oldest = PAge1;
                int Youngest = PAge1;
                for(int i = 0; i < Persons.Length; i++)
                {
                    Oldest = Persons[i].Age >= Oldest ? Persons[i].Age : Oldest;
                    Youngest = Persons[i].Age <= Youngest ? Persons[i].Age : Youngest;
                    
                }
                string Statement = $"The youngest dude is {Youngest} years old while the oldest is {Oldest}";
                Console.Write(Statement);
            }
            #endregion


        }
    }
}
