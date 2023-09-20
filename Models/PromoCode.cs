namespace DependencyStore.Models;

public class PromoCode
{
    public PromoCode(DateTime expireDate, decimal value, string code)
    {
        ExpireDate = expireDate;
        Value = value;
        Code = code;
    }

    public DateTime ExpireDate { get; set; }
    public decimal Value { get; set; }
    public string Code { get; set; }
}