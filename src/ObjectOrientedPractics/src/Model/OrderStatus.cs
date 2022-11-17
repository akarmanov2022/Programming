namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисление всех статусов заказа.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivery,
        Returned,
        Abandoned
    }
}