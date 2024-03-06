using BadWordDetectorLibrary.Methods;
using BadWordDetectorLibrary.Models;

List<PersonModel> personList = [];

List<CarModel> carList =
[
    new CarModel("Jeep", "Grand Cherokee"),
    new CarModel("Nissan", "Pathfinder"),
    new CarModel("Dodge", "Hellcat")
];

PersonModel person1 = new("fuck", 26, "keegan.odell@icloud.com");
person1.BadWord += (sender, s) => Console.WriteLine(s);
PersonModel person2 = new("Sam", 24, "Sam.Meow@email.com");
person2.BadWord += (sender, s) => Console.WriteLine(s);
PersonModel person3 = new("Ben", 90, "Ben@gmail.com,");
person3.BadWord += (sender, s) => Console.WriteLine(s);

personList.Add(person1);
personList.Add(person2);
personList.Add(person3);

foreach (PersonModel person in personList)
{
    string nameSanitized = person.BadWordChecker(person.Name);
    person.Name = nameSanitized;
}


personList.CsvGenerator();


