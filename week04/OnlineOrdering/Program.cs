using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("Av.los Incas St 125", "Independencia", "Lima", "Peru");
        Customer customer1 = new Customer("Lorenzo Alcalá Prince", address1);
        List<Product> productslist1 = new List<Product>();

        Product p1 = new Product("Graphing Calculator", "GC200", 65.99, 1);
        Product p2 = new Product("Notebook", "NB50", 3.50, 5);
        Product p3 = new Product("Mechanical Pencil", "MP05", 1.99, 10);

        productslist1.Add(p1);
        productslist1.Add(p2);
        productslist1.Add(p3);

        Order order1 = new Order(productslist1, customer1);

        Console.WriteLine("Order Number 1:");
        order1.DisplayResults();
        Console.WriteLine("\n");


        Address address2 = new Address("352 St", "Good Year", "AZ 85001", "USA");
        Customer customer2 = new Customer("Blake A. Larsen", address2);
        List<Product> productslist2 = new List<Product>();

        Product p001 = new Product("Highlighter Set", "HLSET", 4.99, 3);
        Product p002 = new Product("Index Cards", "IC100", 1.75, 2);
        Product p003 = new Product("Scientific Calculator", "SCC1000", 12.50, 1);

        productslist2.Add(p001);
        productslist2.Add(p002);
        productslist2.Add(p003);

        Order order2 = new Order(productslist2, customer2);

        Console.WriteLine("Order Number 2:");
        order2.DisplayResults();
        Console.WriteLine("\n");


        Address address3 = new Address("2010 W 500 S", "Salt Lake", "UT 84104", "USA");
        Customer customer3 = new Customer("Dario G. Mostacero", address3);
        List<Product> productslist3 = new List<Product>();

        Product p1001 = new Product("Pencil Case", "PC100", 8.99, 2);
        Product p1002 = new Product("Highlighter Set", "HLSET", 4.99, 4);

        productslist3.Add(p1001);
        productslist3.Add(p1002);

        Order order3 = new Order(productslist3, customer3);

        Console.WriteLine(" Order Number 3:");
        order3.DisplayResults();
        Console.WriteLine("\n");
    }
}