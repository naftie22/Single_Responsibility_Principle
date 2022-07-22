using System.Text.RegularExpressions;

namespace ValueObjects
{
    public class ItemName
    {
        public readonly string Name;

        private ItemName(string name)
        {
            this.Name = name;
        }

        public static ItemName CreateItemName(string name)
        {
            if(ValidateId(name))
                return new ItemName(name);
            else
                throw new System.Exception("Invalid name");
        }

        private static bool ValidateId(string name)
        {
            Regex regex = new Regex("[A-Za-z]+");
            if(name.Length <= 10)
                return regex.IsMatch(name);
            else
                return false;
        }

        public override string ToString()
            => $"{Name}";
    }
}