using FundamentosBlazor.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;

namespace FundamentosBlazor.Components.Pages
{
    public partial class DependencyIjectionPage
    {
        [Inject] 
        public IMyService? MyService { get; set; }

        public async Task<string?> GetMessage()
        {
            var result = MyService?.GetMessage();

            return result;
        }
    }
}
