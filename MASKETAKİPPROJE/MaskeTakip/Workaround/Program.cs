using Business.Concrete;
using Entities.Concrete;
Person person1 = new Person();
person1.FirstName = "Emine";
person1.LastName = "TEKİN";
person1.DateOfBirthYear = 1999;
person1.NationalIdentity = 211;
PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(person1);



