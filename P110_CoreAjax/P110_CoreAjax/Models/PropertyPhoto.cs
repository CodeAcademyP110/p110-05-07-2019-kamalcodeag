namespace P110_CoreAjax.Models
{
    public class PropertyPhoto
    {
        public int Id { get; set; }
        public string Image { get; set; }

        public int PropertyId { get; set; }

        //navigation property
        public virtual Property Property { get; set; }
    }
}
