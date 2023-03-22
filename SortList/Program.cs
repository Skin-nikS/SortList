//Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так, чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var phoneBook = new List<Contact>();

            
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            Console.WriteLine("Sort list by firstname\n");
            var sortedStudsbyName = from s in phoneBook orderby s.Name select s;

                foreach (Contact contact in sortedStudsbyName)
                {

                    Console.WriteLine(contact.Name + " " + contact.LastName + ": " + contact.PhoneNumber);
                }
            Console.WriteLine();
            Console.WriteLine("Sort list by secondname\n");
            var sortedStudsbysecondname = from s in phoneBook orderby s.LastName select s;

            foreach (Contact contact in sortedStudsbysecondname)
            {

                Console.WriteLine(contact.LastName +" " + contact.Name + " " + ": " + contact.PhoneNumber);
            }


        }

    }
    public class Contact 
    {
        public Contact(string name, string lastName, long phoneNumber, String email) 
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }


}