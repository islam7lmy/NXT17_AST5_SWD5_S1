using System.Drawing;

namespace OOP
{
    struct PhoneBook
    {
        string[] Names;
        string[] Numbers;

        int _size;
        public int Size
        {
            get { return _size; }
            private set { _size = value < 4 ? 4 : value; }
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
                Console.WriteLine("phone book is full");
                return;
                //resize arrays => dublicate size of arrays
            }

            Names[index] = _Name;
            Numbers[index] = _Number;
        }

        public void RemoveContact(string _Name)
        {
            //search in names array and find firrst index match value
            //Name[i] = null;
            //Number[i] = null;

        }

        public void SetContact(string _Name, string _Number)
        {
            //search in names array and find firrst index match value
            //Number[i] = _Number;
        }

        public string GetContact(string _Name)
        {
            //search in names array and find firrst index match value
            //return Number[i];
            return string.Empty;

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
                return $"{Names[index]} : {Numbers[index]}";
            }
        }
    }
}
