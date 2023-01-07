namespace Core.Entities
{
    /// <summary>
    /// Unit of goods that we sell in the online store
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }
    }
}