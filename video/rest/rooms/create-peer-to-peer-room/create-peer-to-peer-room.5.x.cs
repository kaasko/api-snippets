// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Video.V1;

class Example
{
    static void Main (string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // To set up environmental variables, see http://twil.io/secure
        const string apiKeySid = Environment.GetEnvironmentVariable("TWILIO_API_KEY_SID");
        const string apiKeySecret = Environment.GetEnvironmentVariable("TWILIO_API_KEY_SECRET");

        TwilioClient.Init(apiKeySid, apiKeySecret);

        var room = RoomResource.Create(
            uniqueName: "DailyStandup",
            type: RoomResource.RoomTypeEnum.PeerToPeer,
            enableTurn: true,
            statusCallback: new Uri("http://example.org"));

        Console.WriteLine(room.Sid);
    }
}
