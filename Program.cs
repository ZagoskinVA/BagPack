using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
namespace BagPack
{
    class Program
    {

        static void Main(string[] args)
        {
        	int n;
        	var list = LoadBagPack(out n);
        	var bag1 = new BagPack(n,list);
        	var price1 = bag1.GetBestPrice();
        	var bag2 = new DynamikBag(n);
        	var price2 = bag2.GetPrice(list);
        	var bag3 = new GreedBag(n);
        	var price3 = bag3.GetPrice(list);
        	Console.WriteLine($"Полный перебор: {price1}");
        	Console.WriteLine($"Динамическое программирование: {price2}");
        	Console.WriteLine($"Жадный алгоритм: {price3}");



        }
        //Загрузка данных о рюкзаке из файла, типа 
        //5(колличество предметов) 100(вместимость рюкзака)
        //5 10 5 6 7 - веса предметов 
        //3 1  2 9 4 - стоимость предсетов
        

        static List<Item> LoadBagPack(out int maxWeight)
        {
        	string str;
        	using(var sr = new StreamReader("bag.txt"))
        	{
        		str  = sr.ReadToEnd();
        	} 

        	var spl = str.Split('\n');
        	var spl1 = spl[0].Split(' ');
        	var spl2 = spl[1].Split(' ');
        	var spl3 = spl[2].Split(' ');





        	int weight = int.Parse(spl1[1]);
        	int n = int.Parse(spl1[0]);
        	maxWeight = weight;
        	var list = new List<Item>();
        	for(int i = 0; i < spl2.Length; i++)
        	{

        		list.Add(new Item(double.Parse(spl2[i]),double.Parse(spl3[i])));
        	}

        	return list;
        }



    }
}
