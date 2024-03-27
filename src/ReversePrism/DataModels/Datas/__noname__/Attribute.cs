using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrefixOffset                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 PrefixLength                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 LocalNameOffset                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C LocalNameLength                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 NsOffset                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 NsLength                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Offset                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Attribute
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
            var value   = new Attribute();

            value.PrefixOffset                              = GetInt32(new IntPtr(p + 0x010)); // 0270D7C15FD8 0x10 PrefixOffset                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PrefixLength                              = GetInt32(new IntPtr(p + 0x014)); // 0270D7C15FF8 0x14 PrefixLength                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LocalNameOffset                           = GetInt32(new IntPtr(p + 0x018)); // 0270D7C16018 0x18 LocalNameOffset             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LocalNameLength                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D7C16038 0x1C LocalNameLength             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NsOffset                                  = GetInt32(new IntPtr(p + 0x020)); // 0270D7C16058 0x20 NsOffset                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NsLength                                  = GetInt32(new IntPtr(p + 0x024)); // 0270D7C16078 0x24 NsLength                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D7C16098 0x28 Offset                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x02C)); // 0270D7C160B8 0x2C Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
