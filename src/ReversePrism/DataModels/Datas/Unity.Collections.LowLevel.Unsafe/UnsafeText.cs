using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UntypedListData                        00018673F550 ModelEnumType UntypedUnsafeList UntypedUnsafeList UntypedUnsafeList Int32
    public partial class UnsafeText
    {
        public UntypedUnsafeList                        M_UntypedListData                       { get; set; }

        public static UnsafeText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeText();

            value.M_UntypedListData                         = (UntypedUnsafeList)GetInt32(new IntPtr(p + 0x010)); // 0270D99E2590 0x10 M_UntypedListData           ( 00018673F550 ModelEnumType UntypedUnsafeList UntypedUnsafeList UntypedUnsafeList Int32 )

            return value;
        }
    }
}
