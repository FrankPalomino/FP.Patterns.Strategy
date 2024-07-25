using FP.Patterns.Strategy.Exercice4;

Console.WriteLine("Please Select your payment method:\n1. Bank Transfer.\n2. Credit Card.\n3. PayPal.");
string paymentMethod = Console.ReadLine();

PaymentContext context = default;
switch (paymentMethod)
{
    case "1":
        context = new(new BankTranferPayment());
        break;
    case "2":
        context = new(new CreditCardPayment());
        break;
    case "3":
        context = new(new PayPalPayment());
        break;
}

context.Pay();