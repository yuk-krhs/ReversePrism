using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Error                                    0001865CB1C0 ModelClassType Exception Exception Exception Pointer
    // 018 Cancelled                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 userState                                <object> IL2CPP_TYPE_OBJECT
    public partial class AsyncCompletedEventArgs
    {
        public Exception?                               Error                                   { get; set; }
        public bool                                     Cancelled                               { get; set; }

        public static AsyncCompletedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncCompletedEventArgs();

            value.Error                                     = GetObject<Exception>(new IntPtr(p + 0x010), ReversePrism.DataModels.Exception.FromPointer); // 0270D7A175D8 0x10 Error                       ( 0001865CB1C0 ModelClassType Exception Exception Exception Pointer )
            value.Cancelled                                 = GetBool(new IntPtr(p + 0x018)); // 0270D7A175F8 0x18 Cancelled                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
