namespace ThreeVia.Logic
{
    public class EnableSubmissionService
    {
        public event EventHandler<EnableSubmissionEventArgs> EnableSubmission;


        public void OnEnableSubmission(EnableSubmissionEventArgs e)
        {
            EnableSubmission?.Invoke(this, e);
        }

        public class EnableSubmissionEventArgs : EventArgs
        {
            public EnableSubmissionEventArgs(bool enable)
            {
                Enable = enable;
            }

            public bool Enable { get; }
        }
    }
}
