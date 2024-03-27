using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Empty                                    Token IL2CPP_TYPE_VALUETYPE
    // 010 Type                                     000186625F50 ModelEnumType Type Type Type Int32
    // 014 StartPosition                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 EndPosition                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Token
    {
        public Type                                     Type                                    { get; set; }
        public int                                      StartPosition                           { get; set; }
        public int                                      EndPosition                             { get; set; }

        public static Token? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Token();

            value.Type                                      = (Type)GetInt32(new IntPtr(p + 0x010)); // 0270DB843118 0x10 Type                        ( 000186625F50 ModelEnumType Type Type Type Int32 )
            value.StartPosition                             = GetInt32(new IntPtr(p + 0x014)); // 0270DB843138 0x14 StartPosition               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndPosition                               = GetInt32(new IntPtr(p + 0x018)); // 0270DB843158 0x18 EndPosition                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
