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
            _logger.Log("PaymentStart");
            var result = false;
            var securityId = _securityInfo.GetFromUserId(userId);
            _logger.Log($"Security id {securityId} for user id {userId}");
            _transaction.Start();
            _transaction.Do(() =>
            {
                result = _payment.Pay(securityId, amount);
                _logger.Log($"Paying {amount} for security id {securityId}");
            });

            _transaction.End();
            _logger.Log("Transaction end");
            _logger.Log($"Payment result {result}");

            return result;
        }
    }
}