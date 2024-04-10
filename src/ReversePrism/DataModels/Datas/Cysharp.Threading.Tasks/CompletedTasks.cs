using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AsyncUnit                                UniTask`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    // 010 True                                     UniTask`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 False                                    UniTask`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 Zero                                     UniTask`1<int> IL2CPP_TYPE_GENERICINST
    // 040 MinusOne                                 UniTask`1<int> IL2CPP_TYPE_GENERICINST
    // 050 One                                      UniTask`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CompletedTasks : DataModel
    {

        public static CompletedTasks? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompletedTasks() { Pointer= p0 };


            return value;
        }
    }
}
