using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Size                                   ModelPrimitiveType int int int Int32
    // 018 M_Buffer                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 M_changed                                ModelPrimitiveType bool bool bool Bool
    // 024 M_hash                                   ModelPrimitiveType int int int Int32
    public partial class SocketAddress : DataModel
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
            var value   = new SocketAddress() { Pointer= p0 };

            value.M_Size                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Size                      ( ModelPrimitiveType int int int Int32 )
            value.M_Buffer                                  = GetSByteList(new IntPtr(p + 0x018)); // 0x18 M_Buffer                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_changed                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 M_changed                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_hash                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_hash                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
