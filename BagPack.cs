using System;
using System.Collections.Generic;
namespace BagPack
{
    public class BagPack
    {
    	//Классическая задача о рюкзаке с помощью полного перебора.
    	private List<Item> Items;
    	public double MaxWeight {get;}
    	public BagPack(double maxWeight,List<Item> items) 
    	{
    	  MaxWeight = maxWeight;
    	  Items = new List<Item>(items);
    	}


    	public int GetBestPrice()
		{
			return GetBestPrice(Items.Count - 1, 0);

		}
		private int GetBestPrice(int i, int curentWeight)
		{
			if(i < 0)
				return 0;
			int currentPrice = 0;
			if((int)Items[i].Weight + curentWeight <= MaxWeight)
			{
				currentPrice = GetBestPrice(i-1, (int)Items[i].Weight + curentWeight) + (int)Items[i].Price;
			}
			return Math.Max(currentPrice, GetBestPrice(i-1,  curentWeight));

		}
    }
}