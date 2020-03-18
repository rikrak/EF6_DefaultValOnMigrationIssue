namespace Ef6._4.Model
{
    public class MyEntity
    {
        public int Id { get; set; }

        public decimal MyDecimal { get; set; }

        // Added after the initial migration
        public decimal MySecondDecimal { get; set; }
    }
}
