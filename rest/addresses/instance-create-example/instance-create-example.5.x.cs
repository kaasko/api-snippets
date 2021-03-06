// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        // To set up environmental variables, see http://twil.io/secure
        const string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        const string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
        TwilioClient.Init(accountSid, authToken);

        var address = AddressResource.Create(
            customerName: "Customer 500",
            street: "Elm Street",
            city: "Racoon",
            region: "Mordor",
            postalCode: "150",
            isoCountry: "AX"
        );

        Console.WriteLine(address.CustomerName);
    }
}
