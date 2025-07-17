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




        }
    }
}
