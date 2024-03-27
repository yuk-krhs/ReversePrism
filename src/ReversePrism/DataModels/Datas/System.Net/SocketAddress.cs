using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Size                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 M_Buffer                                 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 M_changed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 M_hash                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SocketAddress
    {
        public int                                      M_Size                                  { get; set; }
        public List<sbyte>?                             M_Buffer                                { get; set; }
        public bool                                     M_changed                               { get; set; }
        public int                                      M_hash                                  { get; set; }

        public static SocketAddress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SocketAddress();

            value.M_Size                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D7A0C0D8 0x10 M_Size                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_Buffer                                  = GetSByteList(new IntPtr(p + 0x018)); // 0270D7A0C0F8 0x18 M_Buffer                    ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_changed                                 = GetBool(new IntPtr(p + 0x020)); // 0270D7A0C118 0x20 M_changed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_hash                                    = GetInt32(new IntPtr(p + 0x024)); // 0270D7A0C138 0x24 M_hash                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
