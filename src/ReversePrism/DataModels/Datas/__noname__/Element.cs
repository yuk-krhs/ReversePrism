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
    public partial class Element
    {
        public int                                      PrefixOffset                            { get; set; }
        public int                                      PrefixLength                            { get; set; }
        public int                                      LocalNameOffset                         { get; set; }
        public int                                      LocalNameLength                         { get; set; }

        public static Element? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Element();

            value.PrefixOffset                              = GetInt32(new IntPtr(p + 0x010)); // 0270D7C160D8 0x10 PrefixOffset                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PrefixLength                              = GetInt32(new IntPtr(p + 0x014)); // 0270D7C160F8 0x14 PrefixLength                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LocalNameOffset                           = GetInt32(new IntPtr(p + 0x018)); // 0270D7C16118 0x18 LocalNameOffset             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LocalNameLength                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D7C16138 0x1C LocalNameLength             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
