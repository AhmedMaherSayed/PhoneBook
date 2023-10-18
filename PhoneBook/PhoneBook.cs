using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        #region Attributes
        private int size;
        string[] names;
        long[] phoneNumbers;
        #endregion

        #region Properties
        public int Size { get { return size; } }
        public long this[string Name] // searching and updating indexer(read and write)
        {
            get
            {
                if (names is not null & phoneNumbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == Name)
                            return phoneNumbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if(names is not null & phoneNumbers is not null)
                {
                    for(int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == Name)
                            phoneNumbers[i] = value;
                    }
                }
            }
        }

        public string this[int Index]
        {
            get
            {
                if(names is not null & phoneNumbers is not null)
                {
                    if(Index >= 0 & Index < names.Length)
                    {
                        return $"Index: {Index}, Name: {names[Index]}, PhoneNumber: {phoneNumbers[Index]}";
                    }
                }
                return "Invalid Index";
            }
        }
        #endregion

        #region Constructors
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            phoneNumbers = new long[size];
        }
        #endregion

        #region Methods
        /// <summary>
        /// AddNumber is a method to insert a new cell in the PhoneBook
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="Name"></param>
        /// <param name="PhoneNumber"></param>
        public void AddNumber(int Index, string Name, long PhoneNumber)
        {
            if (names is not null & phoneNumbers is not null)
            {
                if (Index >= 0 & Index < size)
                {

                    names[Index] = Name;
                    phoneNumbers[Index] = PhoneNumber;
                }

            }
        }
        #endregion
    }
}
