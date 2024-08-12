using FirebaseAdmin.Messaging;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace API;

public class FirebaseNotificationService
{
    private readonly FirebaseApp _firebaseApp;

    public FirebaseNotificationService(IConfiguration configuration)
    {
        var pathToServiceAccountKey = configuration["Firebase:ServiceAccountKey"];
        _firebaseApp = FirebaseApp.Create(new AppOptions()
        {
            Credential = GoogleCredential.FromFile(pathToServiceAccountKey),
        });
    }

    public async Task SendNotificationAsync(string registrationToken, string title, string body)
    {
        var message = new Message()
        {
            Token = registrationToken,
            Notification = new Notification()
            {
                Title = title,
                Body = body
            }
        };

        var messaging = FirebaseMessaging.GetMessaging(_firebaseApp);
        string response = await messaging.SendAsync(message);
        // Response contains the message ID from the FCM server
    }
}
