using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EnumReservedRange> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 StartFieldNumber                         int IL2CPP_TYPE_I4
    // 008 StartDefaultValue                        int IL2CPP_TYPE_I4
    // 01C Start                                    ModelPrimitiveType int int int Int32
    // 000 EndFieldNumber                           int IL2CPP_TYPE_I4
    // 00C EndDefaultValue                          int IL2CPP_TYPE_I4
    // 020 End                                      ModelPrimitiveType int int int Int32
    public partial class EnumReservedRange : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public int                                      Start                                   { get; set; }
        public int                                      End                                     { get; set; }

        public static EnumReservedRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumReservedRange() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Start                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Start                       ( ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 End                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
