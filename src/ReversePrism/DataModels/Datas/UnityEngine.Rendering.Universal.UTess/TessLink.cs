using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 roots                                    NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 020 ranks                                    NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class TessLink : DataModel
    {

        public static TessLink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TessLink() { Pointer= p0 };


            return value;
        }
    }
}
