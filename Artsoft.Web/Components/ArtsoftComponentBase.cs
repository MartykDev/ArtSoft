using Microsoft.AspNetCore.Components;

namespace Artsoft.Web.Components
{
    public abstract class ArtsoftComponentBase : OwningComponentBase
    {
        private readonly CancellationTokenSource cancellationTokenSource = new();
        public CancellationToken CancellationToken
        {
            get 
            { 
                return cancellationTokenSource.Token; 
            }
        }

        public bool Initialized { get; protected set; }

        protected override void Dispose(bool disposing)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
        }
    }
}