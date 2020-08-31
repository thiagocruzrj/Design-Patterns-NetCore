namespace DesignPatterns.Facade
{
    public class Facade
    {
        private Logger _logger;
        private Payment _payment;
        private SecurityInfo _securityInfo;
        private Transaction _transaction;

        public Facade()
        {
            _logger = new Logger();
            _payment = new Payment();
            _securityInfo = new SecurityInfo();
            _transaction = new Transaction();
        }

        public bool Pay(string userId, double amount)
        {

        }
    }
}