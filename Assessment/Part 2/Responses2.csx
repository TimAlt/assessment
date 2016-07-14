using System;
using System.Collections.Generic;
using System.Collections;

//enum Gend { Unknown, Male, Female }

//public class Customer
//{
//  public string Name { get; set; }
//  public Gend Gender { get; set; }
//  public string Purchase { get; set; }

//  public Customer(string name, Gend gender, string purchase)
//  {
//    Name = name;
//    Gender = gender;
//    Purchase = purchase;
//  }

//  public override string ToString()
//  {
//    return $"{Name} {Gender} {Purchase}";
//  }

//  string ThankYou()
//  {
//    return $"Hello {Name}, thanks for your purchase: {Purchase}!";
//  }

//  string SendSaleNotice(DateTime date)
//  {
//    return $"Hello {Name}, We wanted to let you know there is a sale coming up on {date}";
//  }

//  string SendSaleNotice(DateTime date, string saleItem)
//  {
//    return $"Hello {Name}, We wanted to let you know there is a sale on {saleItem} on {date}";
//  }
//}

//sealed class InactiveCustomer
//  : Customer
//{
//  public int MonthsInactive { get; set; }

//  public InactiveCustomer(string name, Gend gender, string purchase, int monthsInactive)
//  {
//    Name = name;
//    Gender = gender;
//    Purchase = purchase;
//    MonthsInactive = monthsInactive;
//  }

//  string InactiveMessage()
//  {
//    if (MonthsInactive >= 4)
//    {
//      return $"Thanks for shopping with us {Name}. We saw that you made the folliwing purchase from us: {product}. You last had business with us {monthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals.";
//    }
//  }
//}

//var Clinton = new Customer("Hillary Clinton", Gend.Female, "Email Server");
//Console.WriteLine(Clinton);



public class Customer
{
  public string Name { get; set; }
  public string Gender { get; set; }
  public string Purchase { get; set; }

  public Customer(string name, string gender, string purchase)
  {
    Name = name;
    Gender = gender;
    Purchase = purchase;
  }


  public override string ToString()
  {
    return $"{Name} {Gender} {Purchase}";
  }

  string ThankYou()
  {
    return $"Hello {Name}, thanks for your purchase: {Purchase}!";
  }

  string SendSaleNotice(DateTime date)
  {
    return $"Hello {Name}, We wanted to let you know there is a sale coming up on {date}";
  }

  string SendSaleNotice(DateTime date, string saleItem)
  {
    return $"Hello {Name}, We wanted to let you know there is a sale on {saleItem} on {date}";
  }
}

sealed class InactiveCustomer
  : Customer
{
  public int MonthsInactive { get; set; }

  private InactiveCustomer(string name, string gender, string purchase, int monthsInactive)
  {
    Name = name;
    Gender = gender;
    Purchase = purchase;
    MonthsInactive = monthsInactive;
  }

  string InactiveMessage()
  {
    if (MonthsInactive >= 4)
    {
      return $"Thanks for shopping with us {Name}. We saw that you made the folliwing purchase from us: {Purchase}. You last had business with us {MonthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals.";
    }
    return $"whatever";
  }
}

var Clinton = new Customer("Hillary Clinton", "Female", "Email Server");
Console.WriteLine(Clinton);
