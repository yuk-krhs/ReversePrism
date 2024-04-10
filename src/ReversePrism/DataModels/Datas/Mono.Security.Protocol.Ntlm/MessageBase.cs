using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 header                                   sbyte[] IL2CPP_TYPE_SZARRAY
    // 010 Type                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Flags                                    0001866B9CA0 ModelEnumType NtlmFlags NtlmFlags NtlmFlags Int32
    public partial class MessageBase : DataModel
    {
        public int                                      Type                                    { get; set; }
        public NtlmFlags                                Flags                                   { get; set; }

        public static MessageBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageBase() { Pointer= p0 };

            value.Type                                      = GetInt32(new IntPtr(p + 0x010)); // 0246679A3D88 0x10 Type                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (NtlmFlags)GetInt32(new IntPtr(p + 0x014)); // 0246679A3DA8 0x14 Flags                       ( 0001866B9CA0 ModelEnumType NtlmFlags NtlmFlags NtlmFlags Int32 )

            return value;
        }
    }
}
