using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BufferSizeUnknown                        long IL2CPP_TYPE_I8
    // 010 m_Buffer                                 NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 020 M_SizeInBytes                            0001865F7700 ModelPrimitiveType long long long Int64
    // 028 M_EventCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_WeOwnTheBuffer                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InputEventBuffer : DataModel
    {
        public long                                     M_SizeInBytes                           { get; set; }
        public int                                      M_EventCount                            { get; set; }
        public bool                                     M_WeOwnTheBuffer                        { get; set; }

        public static InputEventBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEventBuffer() { Pointer= p0 };

            value.M_SizeInBytes                             = GetInt64(new IntPtr(p + 0x020)); // 0245A334E5F0 0x20 M_SizeInBytes               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.M_EventCount                              = GetInt32(new IntPtr(p + 0x028)); // 0245A334E610 0x28 M_EventCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_WeOwnTheBuffer                          = GetBool(new IntPtr(p + 0x02C)); // 0245A334E630 0x2C M_WeOwnTheBuffer            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
