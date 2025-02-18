using Microsoft.AspNetCore.Components;

namespace FundamentosBlazor.Components.Pages
{
    public partial class CompTest
    {
        [Parameter]
        public int? Id { get; set; }

        [Parameter]
        public string Category { get; set; }

        [Inject] 
        public NavigationManager? Navigation { get; set; }

        public void GoToPage()
        {
            Navigation?.NavigateTo("/Counter");
        }
    }
}
