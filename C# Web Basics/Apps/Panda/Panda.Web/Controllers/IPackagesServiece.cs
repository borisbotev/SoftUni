namespace Panda.Web.Controllers
{
    public interface IPackagesServiece
    {
        void Create(string description, decimal weight, string shippingAddress, string recipientName);
    }
}