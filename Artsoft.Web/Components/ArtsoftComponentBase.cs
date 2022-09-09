using Microsoft.AspNetCore.Components;

namespace Artsoft.Web.Components
{
    public abstract class ArtsoftComponentBase : OwningComponentBase
    {
        protected CancellationTokenSource cancellationTokenSource = new();

        public CancellationToken CancellationToken
        {
            get 
            { 
                return cancellationTokenSource.Token; 
            }
        }

        protected override void Dispose(bool disposing)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
        }
    }
}