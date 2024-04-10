using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   0001865D9600 ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class NativeCallbackRegistration : DataModel
    {
        public GCHandle                                 Handle                                  { get; set; }

        public static NativeCallbackRegistration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeCallbackRegistration() { Pointer= p0 };

            value.Handle                                    = (GCHandle)GetInt32(new IntPtr(p + 0x010)); // 02466940EED8 0x10 Handle                      ( 0001865D9600 ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
