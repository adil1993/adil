using System;
using System.Collections.Generic;
using System.Web;
/// <summary>
/// TechieTogs shopping cart
/// </summary>
public class Cart
{
    private List<CartItem> _Items = new List<CartItem>();

    public List<CartItem> Items { get { return _Items; } }
    public decimal TotalValue { get {
         decimal sum = 0;
         foreach(var jojo in _Items)
         {
             sum = sum  + jojo.Price;
         } 
         return sum;
         
    } }
    public void AddItem(int productID, string name,string description, decimal price)
    {
          _Items.Add( new CartItem { ProductID = productID, Name = name,Description = description, Price = price } );
    }
    public void Clear()
    {
          _Items.Clear();
    }
    public void RemoveItem(int index)   
    {
          _Items.RemoveAt(index);
    }
}

public class CartItem
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
