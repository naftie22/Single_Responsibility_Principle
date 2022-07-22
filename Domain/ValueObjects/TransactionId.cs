using System.Text.RegularExpressions;

namespace ValueObjects
{
    public class TransactionId
    {
        private string Id;

        private TransactionId(string Id)
        {
            this.Id = Id;
        }

        public static TransactionId CreateId(string Id)
        {
            if(ValidateId(Id))
                return new TransactionId(Id);
            else
                throw new System.Exception("Invalid Id");
        }

        private static bool ValidateId(string Id)
        {
            Regex regex = new Regex("^[A-Z]{3}/[0-9]{3}$");
            if(Id.Length == 6)
                return regex.IsMatch(Id);
            else
                return false;
        }

        public override string ToString()
            => $"{Id}";
    }
}