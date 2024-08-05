using Singleton.Start;

namespace Singleton
{
    internal class Program
    {
        static MemoryLogger logger;
        static void Main(string[] args)
        {
            AssignVoucher("sharawy275@gmail.com", "ABC123");

            UserVoucher("ABC123");
            logger.ShowLog();
            Console.ReadKey();
        }
        static void AssignVoucher(string email,string voucher)
        {
            logger = MemoryLogger.Instance;
            // logic here
            logger.LogInfo($"Voucher {voucher} assigned");
            // logic here
            logger.LogError($"unable to send email {email}");
        }
        static void UserVoucher(string voucher)
        {
            logger = MemoryLogger.Instance;

            // logic here
            logger.LogWarning($"3 attempts made to validate the voucher");
            // logic here
            logger.LogInfo($"{voucher} is used");
        }
    }
}
