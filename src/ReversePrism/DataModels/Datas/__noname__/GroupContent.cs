using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MinVal                                   000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 014 MaxVal                                   000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 HasMaxAttr                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 019 HasMinAttr                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 01C Order                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class GroupContent
    {
        public uint                                     MinVal                                  { get; set; }
        public uint                                     MaxVal                                  { get; set; }
        public bool                                     HasMaxAttr                              { get; set; }
        public bool                                     HasMinAttr                              { get; set; }
        public int                                      Order                                   { get; set; }

        public static GroupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GroupContent();

            value.MinVal                                    = GetUInt32(new IntPtr(p + 0x010)); // 0270D75858A0 0x10 MinVal                      ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxVal                                    = GetUInt32(new IntPtr(p + 0x014)); // 0270D75858C0 0x14 MaxVal                      ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.HasMaxAttr                                = GetBool(new IntPtr(p + 0x018)); // 0270D75858E0 0x18 HasMaxAttr                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasMinAttr                                = GetBool(new IntPtr(p + 0x019)); // 0270D7585900 0x19 HasMinAttr                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Order                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D7585920 0x1C Order                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
