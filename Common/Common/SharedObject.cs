namespace Common
{
    public class SharedObject
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
