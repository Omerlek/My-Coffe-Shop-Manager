using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace PRODUCTS
{
    [Serializable]
    public abstract class PRODUCTS
    {
        public string name;
        public double price;
        public int calories;
        public PRODUCTS(string nm, double pr, int cal)
        {
            name = nm;
            price = pr;
            calories = cal;
        }

        ~PRODUCTS() { }
    }
    [Serializable]
    public abstract class EATEN : PRODUCTS
    {
        public bool isVegan;
        public EATEN(string nm, double pr, int cal, bool vegan) : base(nm, pr, cal)
        {
            isVegan = vegan;
        }

    }
    [Serializable]
    public class SANDWICH : EATEN
    {
        public bool brownBread;
        public SANDWICH(string nm, double pr, int cal, bool bread, bool vegan) : base(nm, pr, cal, vegan)
        {
            brownBread = bread;
        }

        ~SANDWICH() { }
    }
    [Serializable]
    public class SALAD : EATEN
    {
        public bool cheese;
        public SALAD(string nm, double pr, int cal, bool vegan, bool ischeese) : base(nm, pr, cal, vegan)
        {
            cheese = ischeese;
        }

        ~SALAD() { }
    }
    [Serializable]
    public class ToDRINK : PRODUCTS
    {

        public bool alcohol;
        public ToDRINK(string nm, double pr, int cal, bool alc) : base(nm, pr, cal)
        {
            alcohol = alc;
        }
        ~ToDRINK() { }

    }

    [Serializable]
    public class productList
    {
        public SortedList pList;
        public productList()
        {
            pList = new SortedList();
        }

        public void Remove(int index)
        {
            pList.RemoveAt(index);
        }
        public PRODUCTS getElement(int index)
        {

            if (index < pList.Count)
                return (PRODUCTS)pList.GetByIndex(index);
            else
                return null;

        }
        public ToDRINK getElementToDRINK(int index)
        {
            if (index < pList.Count)
                return (ToDRINK)pList.GetByIndex(index);
            else
                return null;
        }
        public SALAD getElementSALAD(int index)
        {
            if (index < pList.Count)
                return (SALAD)pList.GetByIndex(index);
            else
                return null;
        }
        public SANDWICH getElementSANDWICH(int index)
        {
            if (index < pList.Count)
                return (SANDWICH)pList.GetByIndex(index);
            else
                return null;
        }

    }
}
