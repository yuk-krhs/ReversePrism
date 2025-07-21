using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrefixOffset                             ModelPrimitiveType int int int Int32
    // 014 PrefixLength                             ModelPrimitiveType int int int Int32
    // 018 LocalNameOffset                          ModelPrimitiveType int int int Int32
    // 01C LocalNameLength                          ModelPrimitiveType int int int Int32
    // 020 NsOffset                                 ModelPrimitiveType int int int Int32
    // 024 NsLength                                 ModelPrimitiveType int int int Int32
    // 028 Offset                                   ModelPrimitiveType int int int Int32
    // 02C Length                                   ModelPrimitiveType int int int Int32
    public partial class Attribute : DataModel
    {
        public int                                      PrefixOffset                            { get; set; }
        public int                                      PrefixLength                            { get; set; }
        public int                                      LocalNameOffset                         { get; set; }
        public int                                      LocalNameLength                         { get; set; }
        public int                                      NsOffset                                { get; set; }
        public int                                      NsLength                                { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Length                                  { get; set; }

        public static Attribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Attribute() { Pointer= p0 };

            value.PrefixOffset                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 PrefixOffset                ( ModelPrimitiveType int int int Int32 )
            value.PrefixLength                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 PrefixLength                ( ModelPrimitiveType int int int Int32 )
            value.LocalNameOffset                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 LocalNameOffset             ( ModelPrimitiveType int int int Int32 )
            value.LocalNameLength                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LocalNameLength             ( ModelPrimitiveType int int int Int32 )
            value.NsOffset                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 NsOffset                    ( ModelPrimitiveType int int int Int32 )
            value.NsLength                                  = GetInt32(new IntPtr(p + 0x024)); // 0x24 NsLength                    ( ModelPrimitiveType int int int Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
