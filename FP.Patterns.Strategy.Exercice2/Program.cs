using FP.Patterns.Strategy.Exercice2;

Client client = new Client();

client.SetPaymentMethod(new CryptoPayment());
client.Pay(120);

client.SetPaymentMethod(new PayPalPayment());
client.Pay(120);

client.SetPaymentMethod(new CreditCardPayment());
client.Pay(120);