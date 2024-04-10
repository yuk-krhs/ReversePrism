using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _headIndex                               int IL2CPP_TYPE_I4
    // 000 _tailIndex                               int IL2CPP_TYPE_I4
    // 000 _array                                   <var>[] IL2CPP_TYPE_SZARRAY
    // 000 _mask                                    int IL2CPP_TYPE_I4
    // 000 _addTakeCount                            int IL2CPP_TYPE_I4
    // 000 _stealCount                              int IL2CPP_TYPE_I4
    // 000 _currentOp                               int IL2CPP_TYPE_I4
    // 000 _frozen                                  bool IL2CPP_TYPE_BOOLEAN
    // 000 _nextQueue                               WorkStealingQueue<<var>> IL2CPP_TYPE_GENERICINST
    // 000 _ownerThreadId                           int IL2CPP_TYPE_I4
    public partial class WorkStealingQueue : DataModel
    {

        public static WorkStealingQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WorkStealingQueue() { Pointer= p0 };


            return value;
        }
    }
}
