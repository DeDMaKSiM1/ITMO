
namespace CustomClass
{
    public class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
            return $"Номер товара: {Id}\nНазвание товара: {Name}\nЦена товара: {Price}";
        }
    }
}


