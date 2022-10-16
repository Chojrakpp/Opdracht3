using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening2
{

    public class Stapel<T>
    {
        private List<T> lijst;

        public Stapel()
        {
            this.lijst = new List<T>();
        }

        public void Toevoegen(T toeTeVoegen)
        {
            lijst.Add(toeTeVoegen);
        }

        public T Verwijderen()
        {
            if (lijst.Count <= 0)
            {
                MessageBox.Show("leeg stapel");
                throw new StackOverflowException();
            } else {
                T even = lijst[lijst.Count - 1];
                lijst.RemoveAt(lijst.Count - 1);

                MessageBox.Show("item van stapel verwijderd");
                return even;
            }
        }
        public void Leegmaken()
        {
            lijst.Clear();
        }
        public override string ToString()
        {
            string content = string.Join("; ", lijst);
            return content;
        }

        public bool IsAanwezig(T aanwezigeIets)
        {
            if (lijst.Contains(aanwezigeIets))
            {
                return true;
            } else {
                return false;
            }
        }

        // TO DO Weet nog niet hoe het werkt
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }
    }
}