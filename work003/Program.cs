Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dyaNumber = Convert.ToInt32(Console.ReadLine());

void DayTheWeek (int dayNumber) {
  if (dyaNumber == 6 || dyaNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dyaNumber < 1 || dyaNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

DayTheWeek(dyaNumber);