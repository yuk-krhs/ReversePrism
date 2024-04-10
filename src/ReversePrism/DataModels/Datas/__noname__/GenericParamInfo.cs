using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 pklass                                   IntPtr IL2CPP_TYPE_PTR
    // 018 name                                     <int> IL2CPP_TYPE_I
    // 020 Flags                                    000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 024 Token                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 028 constraints                              IntPtr IL2CPP_TYPE_PTR
    public partial class GenericParamInfo : DataModel
    {
        public ushort                                   Flags                                   { get; set; }
        public uint                                     Token                                   { get; set; }

        public static GenericParamInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenericParamInfo() { Pointer= p0 };

            value.Flags                                     = GetUInt16(new IntPtr(p + 0x020)); // 0246669A7328 0x20 Flags                       ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Token                                     = GetUInt32(new IntPtr(p + 0x024)); // 0246669A7348 0x24 Token                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
