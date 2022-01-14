﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace _18장_SerializngCollection_637page
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }

        public string Name;
        public string Phone;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            using(Stream ws=new FileStream("a.dat", FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();

                List<NameCard> list = new List<NameCard>();
                list.Add(new NameCard("박상현", "010-123-4567", 33));
                list.Add(new NameCard("김연아", "010-323-1111", 22));
                list.Add(new NameCard("장미란", "010-555-5555", 26));

                serializer.Serialize(ws, list);
            }

            using Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = (List<NameCard>)deserializer.Deserialize(rs);

            foreach(NameCard nc in list2)
            {
                Console.WriteLine($"Name: {nc.Name}, Phone: {nc.Phone}, Age: {nc.Age}");
            }
        }
    }
}
