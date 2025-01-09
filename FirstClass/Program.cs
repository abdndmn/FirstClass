using FirstClass;

Person student1= new Person();

student1.Name = "John";
student1.Surname = "Dere";
student1.BirthDate = 1975;

Person student2 = new Person()
{
    Name = "Elvan",
    Surname = "Dalton",
    BirthDate = 1980,
};

Person teacher = new Person()
{
    Name = "Mahmut",
    Surname = "Hoca",
    BirthDate = 1930,
};
Console.WriteLine("1. Ögrencinin Adı: "+student1.Name+"\nSoyadı: "+student1.Surname+"\nDogum Tarihi: "+student1.BirthDate);
Console.WriteLine("\n2. Ögrencinin Adı: " + student2.Name + "\nSoyadı: " + student2.Surname + "\nDogum Tarihi: " + student2.BirthDate);
Console.WriteLine("\nÖgretmenin Adı: " + teacher.Name + "\nSoyadı: " + teacher.Surname + "\nDogum Tarihi: " + teacher.BirthDate);