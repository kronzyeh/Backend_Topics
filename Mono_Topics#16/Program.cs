using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mono_Topics_16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "John", Age = 30 };

            // Serialize the object to a file
            string filePath = "person.bin";
            person.Serialize(person, filePath);
            Console.WriteLine("Serialization complete.");

            // Deserialize the object from the file
            Person deserializedPerson = new Person();
            deserializedPerson = deserializedPerson.Deserialize(filePath);
            Console.WriteLine("Deserialization complete.");
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Serialize(Person obj, string filePath)
        {
        
        IFormatter formatter = new BinaryFormatter();

        
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                // Serialize the object to the file stream
                formatter.Serialize(stream, obj);
            }
        }
        public Person Deserialize(string filePath)
        {
       
        IFormatter formatter = new BinaryFormatter();

        
        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        {
            // Deserialize the object from the file stream
            return (Person)formatter.Deserialize(stream);
        }
    }
    }
    

    
}
