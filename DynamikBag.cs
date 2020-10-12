using System;
using System.Collections.Generic;
namespace BagPack
{
    public class DynamikBag
    {
        // Реешим классическую задачу о рюкзаке методом динамического программирования.
        //Возвращает максимальную стоимость , которую можно поместить в рюкзак.
    	private int[,] arr;
    	public int MaxWeight {get;private set;}
    	public DynamikBag (int maxWeight) 
    	{
    	  MaxWeight = maxWeight;
    	}

    	public int GetPrice(List<Item> items)
    	{
    		arr = new int [items.Count+1,MaxWeight+1];
            for(int i = 1; i <= items.Count; i++)
            {
                for(int j = 1; j <= MaxWeight; j++)
                {
                    if(j >= items[i-1].Weight)
                        arr[i,j] = Math.Max(arr[i-1,j],arr[i-1,j-(int)items[i-1].Weight] + (int)items[i-1].Price);
                    else
                        arr[i,j] = arr[i-1,j];
                }
            }





            return arr[items.Count,MaxWeight];


    	}
	
    }
}