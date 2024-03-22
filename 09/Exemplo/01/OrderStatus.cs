namespace 09.Exemplo.01
{
    public enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

/*

OrderStatus os1 = (OrderStatus)2;

int n1 = (int)OrderStatus.Processing;
*/