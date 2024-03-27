using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cache                                    Dictionary`2<Type, <object>> IL2CPP_TYPE_GENERICINST
    // 000 <UpdateLabel>k__BackingField             LabelTarget IL2CPP_TYPE_CLASS
    public partial class CallSiteBinder
    {

        public static CallSiteBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallSiteBinder();


            return value;
        }
    }
}
