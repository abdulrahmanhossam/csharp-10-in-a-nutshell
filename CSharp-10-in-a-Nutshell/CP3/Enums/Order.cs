namespace CSharp_10_in_a_Nutshell.CP3.Enums;

public class Order
{
    public int OrderId { get; set; }
    public OrderStatus Status { get; set; }

    public void CancelOrder()
    {
        // Code is readable 
        if (Status == OrderStatus.Pending || Status == OrderStatus.Processing)
        {
            Status = OrderStatus.Cancelled;
            Console.WriteLine("Order has been cancelled.");
        }
        else
        {
            Console.WriteLine("Cannot cancel an order that is already shipped or delivered.");
        }
    }
}