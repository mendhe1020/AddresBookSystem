namespace AddresBookSystem
{
    public class Program
    {
           //creating list of contact
        public static List<Contact> contactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem.");

            //ability to creating contacts
            Contact contact1 = new Contact();
            contact1.firstName = "Anurag";
            contact1.lastName = "Mendhe";
            contact1.address = "Akola Maharashtra";
            contact1.phone = 1234567890;
            contact1.city = "Akola";
            contact1.state = "Maharashtra";
            contact1.zipcode = 444005;
            contactList.Add(contact1);
        }
    }
}