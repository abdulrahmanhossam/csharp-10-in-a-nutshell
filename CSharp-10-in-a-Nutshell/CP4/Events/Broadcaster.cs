namespace CSharp_10_in_a_Nutshell.CP4.Events;

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

public class Broadcaster
{
    // under the hood we convert this to (private delegate with add and remove method)
    // we use event from outside to add or remove but we can not use delegate

    /*
        private PriceChangedHandler priceChanged;

        public event PriceChangedHandler PriceChanged
        {
            add { priceChanged += value; } 
            remove { priceChanged -= value; }
        }
    */
    public event PriceChangedHandler PriceChanged;
}