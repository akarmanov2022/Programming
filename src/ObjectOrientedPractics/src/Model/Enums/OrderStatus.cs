namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Перечисление статусов заказа.
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