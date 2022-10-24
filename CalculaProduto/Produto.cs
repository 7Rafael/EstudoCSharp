using System.Globalization;

namespace CalculaProduto
{
    internal class Produto
    {
        public string Name;
        public double Price;
        public int Unit;

        public double TotalValue()
        {
            return Price * Unit ;
        }
        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Unit
                + " unit, Total: $"
                + TotalValue().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
