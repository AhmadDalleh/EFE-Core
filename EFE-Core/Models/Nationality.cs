namespace EFE_Core.Models
{
    public class Nationality
    {
        public int NationalityId { get; set; }
        public string? Name { get; set; }

        public virtual List<Author>? Authors { get; set; }

    }
}