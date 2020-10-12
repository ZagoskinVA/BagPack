using System;
using System.Collections.Generic;
using System.Linq;
namespace BagPack
{
    public class GreedBag
    {
        // Реализуем задачу о рюкзаке , где можно распиливать предметы(непрерывный рюкзак) , с помощью жадного алгоритма.
    	public int MaxWeight {get;private set;}
    	public GreedBag (int maxWeight) 
    	{
    	  MaxWeight = maxWeight;
    	}

    	public double GetPrice(List<Item> items)
    	{

    		double sum = 0;
            // Сортируем по удельной стоимости т.е Price/Weight в порядке убывания
    		items.Sort();
    		items.Reverse();
    		foreach(var item in items)
    		{
    			if(MaxWeight > item.Weight)
    			{
    				sum += item.Price;
    				MaxWeight -= (int)item.Weight;
    			}
    			else
    			{
    				sum += (MaxWeight/item.Weight*item.Price);
    				break;
    			}
    		}
    		return sum;

    	}
	
    }
}