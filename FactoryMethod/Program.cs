using System.Reflection;
using FactoryMethod.FactoryMethod.Factories;

var factory = new PayFactory();

var cardMethod = factory.CreatePayMethod("card");
var cryptoMethod = factory.CreatePayMethod("crypto");
var payPalMethod = factory.CreatePayMethod("paypal");

cardMethod.Pay(10);
cryptoMethod.Pay(23);
payPalMethod.Pay(64);