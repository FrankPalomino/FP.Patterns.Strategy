using FP.Patterns.Strategy.Exercice1;

TaxCalculator taxCalculator = new TaxCalculator(new CapitalGainsTax());

Console.WriteLine($"Tax: {taxCalculator.CalculateTax(100)}");

taxCalculator = new TaxCalculator(new VatTax());

Console.WriteLine($"Tax: {taxCalculator.CalculateTax(100)}");

taxCalculator = new TaxCalculator(new IncomeTax());

Console.WriteLine($"Tax: {taxCalculator.CalculateTax(100)}");