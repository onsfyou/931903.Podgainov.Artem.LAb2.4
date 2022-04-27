using System.ComponentModel.DataAnnotations;
namespace LAb4.Services
{
    public class SignUpService
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int BirthDay { get; set; }
        public static string BirthMonth { get; set; }
        public static int BirthYear { get; set; }
        public static string Gender { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string Remember { get; set; }

        public static void AccSet1(string FName, string LName, int BDay, string BMonth, int BYear, string Gen)
        {
            FirstName = FName;
            LastName = LName;
            BirthDay = BDay;
            BirthMonth = BMonth;
            BirthYear = BYear;
            Gender = Gen;
        }
        public static void AccSet2(string Em, string Pass, string Remem)
        {
            Email = Em;
            Password = Pass;
            Remember = Remem;
        }
    }
    public static class ServiceProviderExtansions
    {
        public static void AddSignUpService(this IServiceCollection services)
        {
            services.AddTransient<SignUpService>();
        }
    }
}
