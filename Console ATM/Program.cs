using System;

public class CardHolder
{
    string carNum;
    int pin;
    string firstName;
    string lastName;
    double balance; 

    public CardHolder(string carNum, int pin, string firstName, string lastName, double balance)
    {
        this.carNum = carNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    // Get Functions
    public string getNum()
    {
        return carNum;
    }
    
    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    // Set Functions
    public void setNum(string newCardNum)
    {
        newCardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
}