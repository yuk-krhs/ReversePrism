using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Size                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Buffer                                   0001865AB9A0 ModelEnumType <buffer>e__FixedBuffer <buffer>e__FixedBuffer <buffer>e__FixedBuffer Int32
    public partial class IMECompositionString
    {
        public int                                      Size                                    { get; set; }
        public <buffer>e__FixedBuffer                   Buffer                                  { get; set; }

        public static IMECompositionString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IMECompositionString();

            value.Size                                      = GetInt32(new IntPtr(p + 0x010)); // 0270D77000A8 0x10 Size                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = (<buffer>e__FixedBuffer)GetInt32(new IntPtr(p + 0x014)); // 0270D77000C8 0x14 Buffer                      ( 0001865AB9A0 ModelEnumType <buffer>e__FixedBuffer <buffer>e__FixedBuffer <buffer>e__FixedBuffer Int32 )

            return value;
        }
    }
}
