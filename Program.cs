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
            PersonAge[] persons = new PersonAge[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter the name for person {i + 1}:");
                string name = Console.ReadLine();

                int age;
                while (true)
                {
                    Console.WriteLine($"Enter the age for person {i + 1}:");
                    if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                        break;
                    Console.WriteLine("Invalid age. Please enter a valid number.");
                }

                persons[i] = new PersonAge(age, name);
            }

            // Find oldest and youngest
            PersonAge oldest = persons[0];
            PersonAge youngest = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                    oldest = persons[i];

                if (persons[i].Age < youngest.Age)
                    youngest = persons[i];
            }

            Console.WriteLine($"The youngest person is {youngest.Name} ({youngest.Age} years old), " +
                              $"and the oldest is {oldest.Name} ({oldest.Age} years old).");
            #endregion


        }
    }
}
