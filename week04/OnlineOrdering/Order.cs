using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products; 
    private Customer _customer; 

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateShipping()
    {
       double shippingCost;

        if (_customer.IsFromUSA()) 
        {
        shippingCost = 5.0; 
        }
        else 
        {
        shippingCost = 35.0; 
        }
         return shippingCost;
      }


    public double CalculateTotalPrice()
    {
        double totalProductPrice = 0;
        foreach (Product p in _products)
        {
            totalProductPrice += p.CalculatePrice();
        }
        totalProductPrice += CalculateShipping();

        return totalProductPrice;
    }

    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product p in _products)
        {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }
        return packingLabel;
    }

    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetName() + "\n";
        shippingLabel += _customer.GenerateAddress();
        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string costDetails = "Order Cost Summary:\n";
        double productsTotal = 0;

        foreach (Product p in _products)
        {
            double productCost = p.CalculatePrice();
            productsTotal += productCost;
            
            costDetails += $"{p.GetName()} ({p.GetProductID()}): ${p.GetPrice():F2} x {p.GetQuantity()} = ${productCost:F2}\n";
        }
        
        costDetails += "---------------------------------------\n";
        costDetails += $"Subtotal (Products): ${productsTotal:F2}\n";

        double shippingCost = CalculateShipping();
        costDetails += $"Shipping Cost:       ${shippingCost:F2}\n";

        double finalTotal = productsTotal + shippingCost;
        costDetails += $"Total (Final Price): ${finalTotal:F2}\n";
        
        return costDetails;
    }

    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel();
        string shippingLabel = GenerateShippingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}
