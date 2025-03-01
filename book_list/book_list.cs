using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace book_lst
{

    internal class book_list
    {
        private string[] array;

        public book_list() {
            this.array = new string[0];
        }

        public book_list(string[] books)
        {
            this.array = books;
        }
        public static book_list operator +(book_list obj, string book)
        {
            int size = obj.array.Length + 1;
            string[] new_array = new string[size];
            
            Array.Copy(obj.array, new_array, obj.array.Length);

            new_array[new_array.Length - 1] = book;

            return new book_list(new_array);
        }

        public static book_list operator -(book_list obj, int index)
        {
            if (index < 0 || index >= obj.array.Length) return obj;

            int size = obj.array.Length - 1;
            string [] new_array = new string[size];

            for (int i = 0, j = 0; i < obj.array.Length; i++)
            {
                if (i != index)
                {
                    new_array [j] = obj.array [i];
                    j++;
                }
            }

            return new book_list(new_array);
        }

        public static bool operator ==(book_list obj, string book)
        {
            for (int i = 0; i < obj.array.Length; i++)
            {
                if (obj.array[i] == book)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(book_list obj, string book)
        {
            return !(obj == book);
        }

        public void print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
