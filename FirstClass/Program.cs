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

student1.GetInformation();
student2.GetInformation();
teacher.GetInformation();