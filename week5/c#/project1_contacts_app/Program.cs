using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_contacts_app
{

    class Program 
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact("Berke","Senturk",333333));
            contacts.Add(new Contact("Melisa","Senturk",121));
            contacts.Add(new Contact("Abc","def",122));
            contacts.Add(new Contact("sdf","fef",123));
            contacts.Add(new Contact("sdfds","vef",124));


            Console.WriteLine("new contact, press 1: ");
            Console.WriteLine("delete contact, press 2: ");
            Console.WriteLine("update contact, press 3: ");
            Console.WriteLine("show contacts, press 4: ");
            Console.WriteLine("search contact, press 5:");

            int requestedProcess = Int32.Parse( Console.ReadLine());
            
            // new contact
            if (requestedProcess == 1)
            {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();

                Console.WriteLine("surname: ");
                string surname = Console.ReadLine();

                Console.WriteLine("phone number: ");
                int phoneNumber = Int32.Parse(Console.ReadLine());

                Contact newContact = new Contact(name, surname, phoneNumber);
                
                contacts.Add(newContact);
                Console.WriteLine("--------ALL CONTACTS--------");
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine("----------");
                    Console.WriteLine("name: {0}", contacts[i].Name);
                    Console.WriteLine("surname: {0}", contacts[i].Surname);
                    Console.WriteLine("phone number: {0}", contacts[i].PhoneNumber);
                    
                }
                Console.WriteLine("---------END OF THE LIST---------");
            }
            
            // delete contact
            else if (requestedProcess == 2) 
            {
                Console.WriteLine("Provide name or surname of the contact");
                Console.WriteLine("----");
                string argToFindAndDelete = Console.ReadLine();
                Console.WriteLine("----");
                bool isExist = false;
                for (int i = 0; i < contacts.Count; i++)
                {   
                    // find the contact via its name or surname
                    if (contacts[i].Name == argToFindAndDelete || contacts[i].Surname == argToFindAndDelete)
                    {
                        Console.WriteLine("deleted contact:");
                        Console.WriteLine("name: {0}", contacts[i].Name);
                        Console.WriteLine("surname: {0}", contacts[i].Surname);
                        Console.WriteLine("phone number: {0}", contacts[i].PhoneNumber);
                        Console.WriteLine("----------");
                        contacts.RemoveAt(i);
                        
                        isExist = true;

                        // show all contacts list
                        Console.WriteLine("--------MANIPULATED LIST--------");
                        for (int a = 0; a < contacts.Count; a++)
                        {
                            Console.WriteLine("----------");
                            Console.WriteLine("name: {0}", contacts[a].Name);
                            Console.WriteLine("surname: {0}", contacts[a].Surname);
                            Console.WriteLine("phone number: {0}", contacts[a].PhoneNumber);
                            
                        }
                        Console.WriteLine("---------END OF THE LIST---------");
                        
                    }
                }

                if (!isExist)
                {
                    Console.WriteLine("contact not exist!");
                }
            }
            // update contact
            else if (requestedProcess ==3)
            {
                // find
                Console.WriteLine("Provide name or surname of the contact");
                Console.WriteLine("----");
                string argToFindAndUpdate = Console.ReadLine();
                Console.WriteLine("----");

                // update args

                Console.WriteLine("----");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("----");


                Console.WriteLine("----");
                Console.WriteLine("Surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("----");

                Console.WriteLine("----");
                Console.WriteLine("Phone Number: ");
                int phoneNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("----");
                for (int i = 0; i < contacts.Count; i++)
                { 
                    // find the contact via its name or surname
                    if (contacts[i].Name == argToFindAndUpdate || contacts[i].Surname == argToFindAndUpdate)
                    {
                        Console.WriteLine("deleted contact:");
                        Console.WriteLine("name: {0}", contacts[i].Name);
                        Console.WriteLine("surname: {0}", contacts[i].Surname);
                        Console.WriteLine("phone number: {0}", contacts[i].PhoneNumber);
                        Console.WriteLine("----------");
                        
                        contacts[i].Name = name;
                        contacts[i].Surname = surname;
                        contacts[i].PhoneNumber = phoneNumber;

                
                        // show all contacts list
                        Console.WriteLine("--------UPDATED LIST--------");
                        for (int a = 0; a < contacts.Count; a++)
                        {
                            Console.WriteLine("----------");
                            Console.WriteLine("name: {0}", contacts[a].Name);
                            Console.WriteLine("surname: {0}", contacts[a].Surname);
                            Console.WriteLine("phone number: {0}", contacts[a].PhoneNumber);
                            
                        }
                        Console.WriteLine("---------END OF THE LIST---------");
                    }
                }
                
            }

            else if (requestedProcess == 4)
            {
                Console.WriteLine("--------ALL CONTACTS--------");
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine("----------");
                    Console.WriteLine("name: {0}", contacts[i].Name);
                    Console.WriteLine("surname: {0}", contacts[i].Surname);
                    Console.WriteLine("phone number: {0}", contacts[i].PhoneNumber);
                    
                }
                Console.WriteLine("---------END OF THE LIST---------");
            }

            else if (requestedProcess == 5)
            {
                // find
                Console.WriteLine("Provide name or surname of the contact");
                Console.WriteLine("----");
                string argToFind = Console.ReadLine();
                Console.WriteLine("----");

                for (int i = 0; i < contacts.Count; i++)
                { 
                    // find the contact via its name or surname
                    if (contacts[i].Name == argToFind || contacts[i].Surname == argToFind)
                    {
                        Console.WriteLine("The contact who you are looking for:");
                        Console.WriteLine("--------------------------------------");
                        
                        Console.WriteLine("Name: {0}", contacts[i].Name);
                        Console.WriteLine("Surname: {0}", contacts[i].Surname);
                        Console.WriteLine("Phone Number: {0}", contacts[i].PhoneNumber);

                    }

                }
            }
            
            else 
            {
                Console.WriteLine("Invalid command!");
            }
        }

    }
    class Contact 
    {

        public string Name;
        public string Surname;
        public int PhoneNumber;

        public Contact(string name, string surname, int phoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
        }


    }




}

