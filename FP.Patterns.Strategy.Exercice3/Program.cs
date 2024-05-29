using FP.Patterns.Strategy.Exercice3;

Console.WriteLine("-Select your payment method-\n1 - Credit Card.\n2 - Crypto.\n3 - PayPal.");
Console.WriteLine("---------------------------");

int selection = int.Parse(Console.ReadLine());
IPaymentStrategy strategy = default;

switch (selection)
{
    case 1:
        strategy = new CreditCardPayment();
        break;
    case 2:
        strategy = new CryptoPayment();
        break;
    case 3:
        strategy = new PayPalPayment();
        break;
}


Order order = new Order(strategy);

order.Pay();