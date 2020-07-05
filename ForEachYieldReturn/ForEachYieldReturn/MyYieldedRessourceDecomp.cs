using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ForEachYieldReturn
{
    internal class MyYieldedRessourceDecomp
    {
        //[IteratorStateMachine(typeof(MyYieldedRessource._GetMyItems___0))]
        public static IEnumerable<int> GetMyItems(bool withError)
        {
            MyYieldedRessourceDecomp._GetMyItems___0 getMyItemsD0 = new MyYieldedRessourceDecomp._GetMyItems___0(-2);
            getMyItemsD0._3E3__withError = withError;
            return (IEnumerable<int>)getMyItemsD0;
        }

        public MyYieldedRessourceDecomp()
        {
            
        }

   // [CompilerGenerated]
    private sealed class _GetMyItems___0 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator
    {
      private int _3E1__state;
      private int _3E2__current;
      private int _3El__initialThreadId;
      private bool withError;
        public bool _3E3__withError;

      [DebuggerHidden]
        public _GetMyItems___0(int _param1)
        {            
            this._3E1__state = _param1;
            this._3El__initialThreadId = Environment.CurrentManagedThreadId;
        }

        [DebuggerHidden]
        void IDisposable.Dispose()
        {
        }

        bool IEnumerator.MoveNext()
        {
            switch (this._3E1__state)
        {
          case 0:
            this._3E1__state = -1;
                this._3E2__current = 1;
                this._3E1__state = 1;
                return true;
          case 1:
            this._3E1__state = -1;
                this._3E2__current = 2;
                this._3E1__state = 2;
                return true;
          case 2:
            this._3E1__state = -1;
                this._3E2__current = 3;
                this._3E1__state = 3;
                return true;
          case 3:
            this._3E1__state = -1;
                this._3E2__current = 4;
                this._3E1__state = 4;
                return true;
          case 4:
            this._3E1__state = -1;
                this._3E2__current = 5;
                this._3E1__state = 5;
                return true;
          case 5:
            this._3E1__state = -1;
                if (this.withError)
                    throw new Exception("Exception");
                return false;
                default:
            return false;
            }
        }

        int IEnumerator<int>.Current
        {
            [DebuggerHidden]
            get
            {
                return this._3E2__current;
            }
        }

        [DebuggerHidden]
        void IEnumerator.Reset()
        {
            throw new NotSupportedException();
        }

        object IEnumerator.Current
        {
            [DebuggerHidden]
            get
            {
                return (object)this._3E2__current;
            }
        }

        [DebuggerHidden]
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
                MyYieldedRessourceDecomp._GetMyItems___0 getMyItemsD0;
            if (this._3E1__state == -2 && this._3El__initialThreadId == Environment.CurrentManagedThreadId)
        {
                this._3E1__state = 0;
                getMyItemsD0 = this;
            }
        else
                getMyItemsD0 = new MyYieldedRessourceDecomp._GetMyItems___0(0);
            getMyItemsD0.withError = this._3E3__withError;
            return (IEnumerator<int>)getMyItemsD0;
        }

        [DebuggerHidden]
        IEnumerator IEnumerable.GetEnumerator()
        {
                //   return (IEnumerator) Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();

                return null;
        }
    }
}
}
