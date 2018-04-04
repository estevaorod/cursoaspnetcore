namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }        

        public Category(string name)
        {
            ValidateValues(name);
            SetProperties(name);
        }

        public void Update(string name)
        {
            ValidateValues(name);
            SetProperties(name);
        }

        private void SetProperties(string name)
        {
            Name = name;
        }

        private static void ValidateValues(string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
        }
    }
}