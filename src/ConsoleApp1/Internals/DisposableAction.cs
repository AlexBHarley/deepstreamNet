using System;

namespace ConsoleApp1
{
    class DisposableAction : IDisposable
    {
        readonly System.Action _action;

        public DisposableAction(System.Action action)
        {
            _action = action;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        void Dispose(bool disposing)
        {
            if (disposing)
                _action();
        }
    }
}