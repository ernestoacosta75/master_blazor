using FundamentosBlazor.Repositories.Interfaces;

namespace FundamentosBlazor.Repositories
{
    public class MyService : IMyService
    {
        public string GetMessage()
        {
            return "This is a test message";
        }
    }
}
