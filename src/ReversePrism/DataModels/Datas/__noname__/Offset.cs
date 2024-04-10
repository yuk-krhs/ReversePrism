using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scheme                                   000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 012 User                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Host                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 016 PortValue                                000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Path                                     000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A Query                                    000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Fragment                                 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E End                                      000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class Offset : DataModel
    {
        public ushort                                   Scheme                                  { get; set; }
        public ushort                                   User                                    { get; set; }
        public ushort                                   Host                                    { get; set; }
        public ushort                                   PortValue                               { get; set; }
        public ushort                                   Path                                    { get; set; }
        public ushort                                   Query                                   { get; set; }
        public ushort                                   Fragment                                { get; set; }
        public ushort                                   End                                     { get; set; }

        public static Offset? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Offset() { Pointer= p0 };

            value.Scheme                                    = GetUInt16(new IntPtr(p + 0x010)); // 0245A4C5E728 0x10 Scheme                      ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.User                                      = GetUInt16(new IntPtr(p + 0x012)); // 0245A4C5E748 0x12 User                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Host                                      = GetUInt16(new IntPtr(p + 0x014)); // 0245A4C5E768 0x14 Host                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.PortValue                                 = GetUInt16(new IntPtr(p + 0x016)); // 0245A4C5E788 0x16 PortValue                   ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Path                                      = GetUInt16(new IntPtr(p + 0x018)); // 0245A4C5E7A8 0x18 Path                        ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Query                                     = GetUInt16(new IntPtr(p + 0x01A)); // 0245A4C5E7C8 0x1A Query                       ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Fragment                                  = GetUInt16(new IntPtr(p + 0x01C)); // 0245A4C5E7E8 0x1C Fragment                    ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.End                                       = GetUInt16(new IntPtr(p + 0x01E)); // 0245A4C5E808 0x1E End                         ( 000186696FC0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
