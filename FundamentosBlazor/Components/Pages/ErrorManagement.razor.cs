namespace FundamentosBlazor.Components.Pages
{
    public partial class ErrorManagement
    {
        private string _errorMessage = string.Empty;
        private bool _hasError = false;

        public void ErrorTriggered()
        {
            try
            {
                throw new InvalidOperationException("This is an error controlled!!");
            }
            catch (Exception ex)
            {
                _hasError = true;
                _errorMessage = ex.Message;

                throw;
            }
        }
    }
}
