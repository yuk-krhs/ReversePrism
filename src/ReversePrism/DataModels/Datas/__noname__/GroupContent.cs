using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MinVal                                   ModelPrimitiveType uint uint uint UInt32
    // 014 MaxVal                                   ModelPrimitiveType uint uint uint UInt32
    // 018 HasMaxAttr                               ModelPrimitiveType bool bool bool Bool
    // 019 HasMinAttr                               ModelPrimitiveType bool bool bool Bool
    // 01C Order                                    ModelPrimitiveType int int int Int32
    public partial class GroupContent : DataModel
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
            var value   = new GroupContent() { Pointer= p0 };

            value.MinVal                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 MinVal                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxVal                                    = GetUInt32(new IntPtr(p + 0x014)); // 0x14 MaxVal                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.HasMaxAttr                                = GetBool(new IntPtr(p + 0x018)); // 0x18 HasMaxAttr                  ( ModelPrimitiveType bool bool bool Bool )
            value.HasMinAttr                                = GetBool(new IntPtr(p + 0x019)); // 0x19 HasMinAttr                  ( ModelPrimitiveType bool bool bool Bool )
            value.Order                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Order                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
