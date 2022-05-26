using System;

namespace WpfTracker.ErrorHandler
{
    public interface IErrorHandler
    {
        public void HandleError(Exception ex);

        public void HandleError(Exception ex, string message);
    }
}
