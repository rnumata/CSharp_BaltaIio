using System;

struct Product
{
  public int Id { get; set; }
  public string Name { get; set; }
  public double Price { get; set; }
  public EEmbalagem Embalagem { get; set; }

  public Product(int id, string name, double price, EEmbalagem embalagem)
  {
    Id = id;
    Name = name;
    Price = price;
    Embalagem = embalagem;
  }

  public double PriceInDolar(double dolar)
  {
    return Price * dolar;
  }
}