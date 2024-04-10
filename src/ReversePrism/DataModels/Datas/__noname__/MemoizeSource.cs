using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 source                                   IUniTaskSource`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 result                                   <var> IL2CPP_TYPE_VAR
    // 000 exception                                ExceptionDispatchInfo IL2CPP_TYPE_CLASS
    // 000 status                                   UniTaskStatus IL2CPP_TYPE_VALUETYPE
    public partial class MemoizeSource : DataModel
    {

        public static MemoizeSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoizeSource() { Pointer= p0 };


            return value;
        }
    }
}
