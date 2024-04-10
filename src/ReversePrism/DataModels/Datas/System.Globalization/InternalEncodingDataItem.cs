using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WebName                                  000186671BA0 ModelPrimitiveType string string string String
    // 018 CodePage                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class InternalEncodingDataItem : DataModel
    {
        public string                                   WebName                                 { get; set; }
        public ushort                                   CodePage                                { get; set; }

        public static InternalEncodingDataItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalEncodingDataItem() { Pointer= p0 };

            value.WebName                                   = GetString(new IntPtr(p + 0x010)); // 0245A4C6BFD0 0x10 WebName                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.CodePage                                  = GetUInt16(new IntPtr(p + 0x018)); // 0245A4C6BFF0 0x18 CodePage                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
