using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scheme                                   ModelPrimitiveType ushort ushort ushort UInt16
    // 012 User                                     ModelPrimitiveType ushort ushort ushort UInt16
    // 014 Host                                     ModelPrimitiveType ushort ushort ushort UInt16
    // 016 PortValue                                ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Path                                     ModelPrimitiveType ushort ushort ushort UInt16
    // 01A Query                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 01C Fragment                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E End                                      ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Scheme                                    = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Scheme                      ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.User                                      = GetUInt16(new IntPtr(p + 0x012)); // 0x12 User                        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Host                                      = GetUInt16(new IntPtr(p + 0x014)); // 0x14 Host                        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.PortValue                                 = GetUInt16(new IntPtr(p + 0x016)); // 0x16 PortValue                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Path                                      = GetUInt16(new IntPtr(p + 0x018)); // 0x18 Path                        ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Query                                     = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A Query                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Fragment                                  = GetUInt16(new IntPtr(p + 0x01C)); // 0x1C Fragment                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.End                                       = GetUInt16(new IntPtr(p + 0x01E)); // 0x1E End                         ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
