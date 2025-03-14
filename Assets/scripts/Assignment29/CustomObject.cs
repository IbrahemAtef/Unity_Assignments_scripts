using UnityEngine;

namespace Assignment29
{
    public class CustomObject
    {
        int id;
        string name;

        public CustomObject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {id}, Name: {name}]";
        }

        public override bool Equals(object obj)
        {
            CustomObject customObject = (CustomObject)obj;
            if (customObject is null) return false;
            return this.id == customObject.id && this.name == customObject.name;
        }

        public static bool operator ==(CustomObject o1, CustomObject o2)
        {
            if (o1 is null || o2 is null) return false;
            return (o1.id == o2.id && o1.name == o2.name);
        }

        public static bool operator !=(CustomObject o1, CustomObject o2)
        {
            return !(o1 == o2);
        }
    }
}