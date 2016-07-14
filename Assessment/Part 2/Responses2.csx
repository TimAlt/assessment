using System;
using System.Collections.Generic;
using System.Collections;


enum InactivityReason { Irate, Moved, Unknown }

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

  public string ThankYou()
  {
    return $"Hello {Name}, thanks for your purchase: {Purchase}!";
  }

  public string SendSaleNotice(DateTime date)
  {
    return $"Hello {Name}, We wanted to let you know there is a sale coming up on {date}";
  }

  public string SendSaleNotice(DateTime date, string saleItem)
  {
    return $"Hello {Name}, We wanted to let you know there is a sale on {saleItem} on {date}";
  }

  public string PrintCustomerInfo()
  {
    return $"{Name} {Gender} {Purchase}";
  }
}

sealed class InactiveCustomer
  : Customer
{
  public int MonthsInactive { get; set; }
  InactivityReason Reason { get; set; }

  public InactiveCustomer(string name, string gender, string purchase, int monthsInactive, InactivityReason reason)
  : base(name, gender, purchase)
  {
    Name = name;
    Gender = gender;
    Purchase = purchase;
    MonthsInactive = monthsInactive;
    reason = reason;
  }

  public override string ToString()
  {
    return $"{Name} {Gender} {Purchase} {MonthsInactive} {Reason}";
  }

  public string InactiveMessage()
  {
    if (MonthsInactive >= 4)
    {
      return $"Thanks for shopping with us {Name}. We saw that you made the folliwing purchase from us: {Purchase}. You last had business with us {MonthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals.";
    }
    return $"{Name} has not reached the inactive threshold.";
  }

  public string PrintCustomerInfo()
  {
    return $"{Name} {Gender} {Purchase} {MonthsInactive} {Reason}";
  }
}

var clinton = new Customer("Hillary Clinton", "Female", "Email Server");
var trump = new InactiveCustomer("Donald Trump", "Male", "Comb", 5, InactivityReason.Irate);
Console.WriteLine(clinton);
Console.WriteLine(trump.PrintCustomerInfo());


//enum InactivityReason { Irate, Moved, Unknown }
//enum Gend { Unknown, Male, Female }


//public class Customer
//{
//  public string Name { get; set; }
//  Gend Gender { get; set; }
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

//  public string ThankYou()
//  {
//    return $"Hello {Name}, thanks for your purchase: {Purchase}!";
//  }

//  public string SendSaleNotice(DateTime date)
//  {
//    return $"Hello {Name}, We wanted to let you know there is a sale coming up on {date}";
//  }

//  public string SendSaleNotice(DateTime date, string saleItem)
//  {
//    return $"Hello {Name}, We wanted to let you know there is a sale on {saleItem} on {date}";
//  }

//  public string PrintCustomerInfo()
//  {
//    return $"{Name} {Gender} {Purchase}";
//  }
//}

//sealed class InactiveCustomer
//  : Customer
//{
//  public int MonthsInactive { get; set; }
//  InactivityReason Reason { get; set; }

//  public InactiveCustomer(string name, Gend gender, string purchase, int monthsInactive, InactivityReason reason)
//  : base(name, gender, purchase)
//  {
//    Name = name;
//    Gender = gender;
//    Purchase = purchase;
//    MonthsInactive = monthsInactive;
//    reason = reason;
//  }

//  public override string ToString()
//  {
//    return $"{Name} {Gender} {Purchase} {MonthsInactive} {Reason}";
//  }

//  public string InactiveMessage()
//  {
//    if (MonthsInactive >= 4)
//    {
//      return $"Thanks for shopping with us {Name}. We saw that you made the folliwing purchase from us: {Purchase}. You last had business with us {MonthsInactive} months ago. We'd like to know if you'd like to take a look at some of our current deals.";
//    }
//    return $"{Name} has not reached the inactive threshold.";
//  }

//  public string PrintCustomerInfo()
//  {
//    return $"{Name} {Gender} {Purchase} {MonthsInactive}";
//  }
//}

//var clinton = new Customer("Hillary Clinton", Gend.Female, "Email Server");
//var trump = new InactiveCustomer("Donald Trump", Gend.Male, "Comb", 5, InactivityReason.Irate);
//Console.WriteLine(clinton);
//Console.WriteLine(trump);