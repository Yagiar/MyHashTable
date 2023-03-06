using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_Abonent
{
    internal class MyHashTable
    {
        Form1.HashFunctionMethod hashFunction;
        KeysType keysType;
        int rowCount;
        List<Abonent>[] table;
        public MyHashTable(int rowCount, KeysType keysType, Form1.HashFunctionMethod hashFunction)
        {
            this.rowCount = rowCount;
            this.keysType = keysType;
            this.hashFunction = hashFunction;
        }

        SolidBrush brush = new SolidBrush(Color.Blue);
        public void Draw(int width, int height, Graphics e)
        {
            float heightElement = height / rowCount;
            int maxElements = 0;
            for (int i = 0; i < rowCount; i++)
            {
                int elements = 0;
                if (table[i] != null)
                {
                    foreach (Abonent abonent in table[i])
                    {
                        elements++;
                    }
                    if (elements > maxElements)
                    {
                        maxElements = elements;
                    }
                }
            }
            float widthElement = (float)width / maxElements;

            for (int i = 0; i < rowCount; i++)
            {
                if (table[i] != null)
                {
                    int countWidth = 0;
                    foreach (Abonent abonent in table[i])
                    {
                        countWidth++;
                    }
                    e.FillRectangle(brush, 0, i * heightElement, countWidth * widthElement, heightElement);
                }
            }
        }

        public List<Abonent> Find(string key, out int StepCount)
        {
            int indexTable = hashFunction(key);
            List<Abonent> resultAbonents = new List<Abonent>();
            StepCount = 0;
            foreach (Abonent abonent in table[indexTable])
            {
                StepCount++;
                if (abonent.Name == key || abonent.Birthday == key || abonent.Phone == key)
                {
                    resultAbonents.Add(abonent);
                }
            }
            return resultAbonents;
        }

        public void Load()
        {
            table = new List<Abonent>[rowCount];
            string line;
            StreamReader SR = new StreamReader("People.txt");
            SR.ReadLine();
            int indexTable;
            while ((line = SR.ReadLine()) != null)
            {
                string[] info = line.Split(';');
                indexTable = hashFunction(info[Convert.ToInt32(keysType) + 1]);
                if (table[indexTable] == null)
                {
                    table[indexTable] = new List<Abonent>();
                }
                table[indexTable].Add(new Abonent(info[1], info[2], info[3])); //фио - номер - дата
            }
            SR.Close();
        }
    }
}
