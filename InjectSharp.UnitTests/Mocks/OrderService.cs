namespace InjectSharp.Mocks
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }

    public class OrderRepository : IOrderRepository
    {
    }

    public interface IOrderRepository
    {
        
    }
}