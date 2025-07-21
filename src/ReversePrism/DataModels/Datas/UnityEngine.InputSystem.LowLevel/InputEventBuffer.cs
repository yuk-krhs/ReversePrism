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
    // 020 M_SizeInBytes                            ModelPrimitiveType long long long Int64
    // 028 M_EventCount                             ModelPrimitiveType int int int Int32
    // 02C M_WeOwnTheBuffer                         ModelPrimitiveType bool bool bool Bool
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

            value.M_SizeInBytes                             = GetInt64(new IntPtr(p + 0x020)); // 0x20 M_SizeInBytes               ( ModelPrimitiveType long long long Int64 )
            value.M_EventCount                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_EventCount                ( ModelPrimitiveType int int int Int32 )
            value.M_WeOwnTheBuffer                          = GetBool(new IntPtr(p + 0x02C)); // 0x2C M_WeOwnTheBuffer            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
