using OOP_4.Classes;
using OOP_4.Interfaces;

namespace OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Implment Interfaces EXplicitly & Implicitly
            //Implemnt the interfaces Explicitly
            AirPlain airPlain = new AirPlain();

            //Implemnt the interfaces Implicitly
            Car car = new Car();
            car.Forward();
            car.Backward();
            #endregion


            #region Deep Copy & Shallow Copy

            #endregion


            #region ICloneable

            #endregion


            #region ICOmpareable

            #endregion

            #endregion


            #region Part02

            #region Part02-Choises
            
            ///Question 1: A
            ///Question 2: A,B,C
            ///Question 3: B
            ///Question 4: B
            ///Question 5: D
            ///Question 6: A
            ///Question 7: B
            ///Question 8: B
            ///Question 9:  B
            ///Question 10: C
            #endregion

            #region Part02-Interfaces

            #region Q01

            Circle circle = new Circle(radius: 5.0);
            Rectangle rectangle = new Rectangle(length: 4.0, width: 6.0);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion

            #region Q02

            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "Michael_WO";
            string password = "WE&*()_*&";
            string role = "admin";

            bool isAuthenticated = authService.AuthenticateUser(username, password);
            bool isAuthorized = authService.AuthorizeUser(username, role);

            #endregion

            #region Q03
            EmailNotificationService emailService = new EmailNotificationService();
            SmsNotificationService smsService = new SmsNotificationService();
            PushNotificationService pushService = new PushNotificationService();

            string recipient = "Michael24@Outlooks.com";
            string message = "Testing Notification!";

            emailService.SendNotification(recipient, message);

            recipient = "2012015986899";
            smsService.SendNotification(recipient, message);

            recipient = "Mobile Client ID";
            pushService.SendNotification(recipient, message);
            #endregion

            #endregion

            #endregion


        }
    }
}
