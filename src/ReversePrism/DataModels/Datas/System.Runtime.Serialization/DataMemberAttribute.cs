using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 IsNameSetExplicitly                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C Order                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 IsRequired                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 021 EmitDefaultValue                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataMemberAttribute
    {
        public string                                   Name                                    { get; set; }
        public bool                                     IsNameSetExplicitly                     { get; set; }
        public int                                      Order                                   { get; set; }
        public bool                                     IsRequired                              { get; set; }
        public bool                                     EmitDefaultValue                        { get; set; }

        public static DataMemberAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataMemberAttribute();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027004CC31E8 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNameSetExplicitly                       = GetBool(new IntPtr(p + 0x018)); // 027004CC3208 0x18 IsNameSetExplicitly         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Order                                     = GetInt32(new IntPtr(p + 0x01C)); // 027004CC3228 0x1C Order                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRequired                                = GetBool(new IntPtr(p + 0x020)); // 027004CC3248 0x20 IsRequired                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EmitDefaultValue                          = GetBool(new IntPtr(p + 0x021)); // 027004CC3268 0x21 EmitDefaultValue            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
