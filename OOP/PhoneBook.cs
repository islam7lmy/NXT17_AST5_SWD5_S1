using System.Drawing;
using System.Xml.Linq;

namespace OOP
{
    class PhoneBook
    {
        public string[] Names;
        public string[] Numbers;

        ///Capacity of PhoneBook [max number of elements ca be saved in PhoneBook]
        int _size;
        public int Size
        {
            get { return _size; }
            private set { _size = value < 4 ? 4 : value; }
        }

        ///Number Of Current Elements in PhoneBook
        public int Count
        {
            get
            {
                int counter = 0;
                foreach (string name in Names)
                {
                    if (name is not null)
                        counter++;
                }
                return counter;
            }
        }

        public PhoneBook() : this(4)
        {
            //Names = null;
            //Numbers = null;
            //Names = new string[4];
            //Numbers = new string[4];
        }

        public PhoneBook(int size)
        {
            Size = size < 4 ? 4 : size;
            Names = new string[Size];
            Numbers = new string[Size];
        }

        public void AddContact(string _Name, string _Number)
        {
            int index = Array.IndexOf(Names, null);

            if (index == -1)
            {
                //Console.WriteLine("phone book is full");
                //return;

                //resize arrays => dublicate size of arrays
                //Resize(ref this);
                Resize();
                index = Count;

            }

            Names[index] = _Name;
            Numbers[index] = _Number;
        }

        public void RemoveContact(string _Name)
        {
            //search in names array and find firrst index match value
            //Name[i] = null;
            //Number[i] = null;

            int index = Array.IndexOf(Names, _Name);
            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            Names[index] = null;
            Numbers[index] = null;

        }

        public void SetContact(string _Name, string _Number)
        {
            //search in names array and find firrst index match value
            //Number[i] = _Number;

            int index = Array.IndexOf(Names, _Name);
            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }
            Numbers[index] = _Number;
        }

        public string GetContact(string _Name)
        {
            //search in names array and find firrst index match value
            //return Number[i];
            //return string.Empty;

            int index = Array.IndexOf(Names, _Name);
            if (index == -1)
            {
                return "Contact not found";
            }
            return Numbers[index];
        }


        public string this[string _Name]
        {
            get
            {
                int index = Array.IndexOf(Names, _Name);
                if (index == -1)
                {
                    return "Contact not found";
                }
                return Numbers[index];
            }
            set
            {
                int index = Array.IndexOf(Names, _Name);
                if (index == -1)
                {
                    Console.WriteLine("Contact not found");
                    return;
                }
                Numbers[index] = value;
            }
        }


        //indexer is a special type of property
        /// that allows you to access elements in a collection 
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                {
                    return $"index out of range";
                }
                return $"Name : {Names[index]} => Number : {Numbers[index]}";
            }
        }

        //private static void Resize(ref PhoneBook Methodbook)
        //{

        //    Methodbook.Size *= 2;
        //    string[] newNames = new string[Methodbook.Size];
        //    string[] newNumbers = new string[Methodbook.Size];

        //    Methodbook.Names.CopyTo(newNames, 0);
        //    Methodbook.Numbers.CopyTo(newNumbers, 0);

        //    Methodbook.Names = newNames;
        //    Methodbook.Numbers = newNumbers;
        //}


        private void Resize()
        {
            Size *= 2;
            string[] newNames = new string[Size];
            string[] newNumbers = new string[Size];

            Names.CopyTo(newNames, 0);
            Numbers.CopyTo(newNumbers, 0);

            Names = newNames;
            Numbers = newNumbers;
        }
    }
}
