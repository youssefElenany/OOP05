namespace Ass05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //ICircle circle = new Circle { Radius = 5 };
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q2
            //IAuthenticationService authService = new BasicAuthenticationService();

            //bool isAuthenticated = authService.AuthenticateUser("user", "password");
            //bool isAuthorized = authService.AuthorizeUser("user", "admin");

            //Console.WriteLine($"Authenticated: {isAuthenticated}");
            //Console.WriteLine($"Authorized: {isAuthorized}");

            #endregion

            #region Q3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("email@example.com", "This is an email message.");
            //smsService.SendNotification("1234567890", "This is an SMS message.");
            //pushService.SendNotification("userDevice", "This is a push notification.");

            #endregion
        }
    }
}
