using System;
namespace BagPack
{
    public class Item : IComparable,IComparable<Item>
    {
    	public double Weight{get;}
    	public double Price{get;}
    	public Item ( double weight, double price) 
    	{

    		Weight = weight;
    		Price = price;
    	}
    	public int CompareTo(Item item)
    	{
    		double a = Price/Weight;
    		double b = item.Price/item.Weight;
    		return a.CompareTo(b);
    	}
    	public int CompareTo(object obj)
    	{
    		if(obj is Item)
    			return CompareTo((Item)obj);
    		throw new ArgumentException("Несоответствие типов");

    	}

	
    }
}