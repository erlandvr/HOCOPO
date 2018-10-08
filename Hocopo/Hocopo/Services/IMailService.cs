namespace Hocopo.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string description, string duration);
    }
}