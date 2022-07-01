namespace SolutionProject.Common.EmailSender
{
    internal class SendGridClient
    {
        private string apiKey;

        public SendGridClient(string apiKey)
        {
            this.apiKey = apiKey;
        }
    }
}