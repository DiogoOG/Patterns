namespace Patterns
{
    public class FastFoodPlace
    {
        private List<ISubscriber> _waitingCustomers = new List<ISubscriber>();

        public void AnnounceOrder(int order)
        {
            foreach (ISubscriber waitingCustomer in _waitingCustomers)
            {
                waitingCustomer.Notify(order);
            }
        }

        public void TakeOrder(ISubscriber customer)
        {
            _waitingCustomers.Add(customer);
        }
    }

    public interface ISubscriber
    {
        void Notify(int order);
    }

    public class Client : ISubscriber
    {
        public void Notify(int order)
        {
            Console.WriteLine($"I saw order {order} be called!");
        }
    }
}
