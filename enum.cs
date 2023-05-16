using System;

namespace EnumApplication {
   class EnumProgram {
      enum Days {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,Sunday };

      static void Main(string[] args) {
         int WeekdayStart = (int)Days.Monday;
         int WeekdayEnd = (int)Days.Sunday;
         
         Console.WriteLine("Monday: {0}", WeekdayStart);
         Console.WriteLine("Friday: {0}", WeekdayEnd);
         Console.ReadKey();
      }
   }
}