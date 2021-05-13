using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,K>
    {
        T[] type;
        K[] values;
        public  MyDictionary()
        {
            type = new T[0];     // array referans tip olduğundan new'ledik
            values = new K[0];

        }

        //public int Count
        //{
        //    get { return type.Length; }
        //}

        //public int Count1
        //{
        //    get { return value.Length; }
        //}


        T[] tempType;
        K[] tempValue;

        public void Add(T key, K value)
        {
            tempType = type;
            tempValue = values;

            type = new T[type.Length + 1];
            values = new K[values.Length + 1];

            for (int i = 0; i < tempType.Length; i++)
            {
                type[i] = tempType[i];
            }


            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            type[type.Length - 1] = key;
            values[values.Length - 1] = value;
        }


    }
}
