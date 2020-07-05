using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace ForEachYieldReturn
{    

        internal class YieldReturnDecompiled
        {
            //[IteratorStateMachine(typeof(MyYieldedRessource._GetMyItemsStateMachine))]
            public static IEnumerator<int> GetMyItems(bool withError)
            {
                YieldReturnDecompiled._GetMyItemsStateMachine getMyItemsD0 = new YieldReturnDecompiled._GetMyItemsStateMachine(0);
                getMyItemsD0.withError = withError;
                return (IEnumerator<int>)getMyItemsD0;
            }

            public YieldReturnDecompiled()
            {
             
            }
         
            private sealed class _GetMyItemsStateMachine : IEnumerator<int>, IDisposable, IEnumerator
            {
              private int ____state;
              private int _E2__current;
              public bool withError;
        
                    [DebuggerHidden]
                    public _GetMyItemsStateMachine(int _param1)
                    {                        
                        this.____state = _param1;
                    }
        
                    [DebuggerHidden]
                    void IDisposable.Dispose()
                    {
                    }
        
                    bool IEnumerator.MoveNext()
                    {
                        switch (this.____state)
                {
                  case 0:
                    this.____state = -1;
                            this._E2__current = 1;
                            this.____state = 1;
                            return true;
                  case 1:
                    this.____state = -1;
                            this._E2__current = 2;
                            this.____state = 2;
                            return true;
                  case 2:
                    this.____state = -1;
                            this._E2__current = 3;
                            this.____state = 3;
                            return true;
                  case 3:
                    this.____state = -1;
                            this._E2__current = 4;
                            this.____state = 4;
                            return true;
                  case 4:
                    this.____state = -1;
                            this._E2__current = 5;
                            this.____state = 5;
                            return true;
                  case 5:
                    this.____state = -1;
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
                            return this._E2__current;
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
                            return (object)this._E2__current;
                        }
                    }
                }
            }
    }
