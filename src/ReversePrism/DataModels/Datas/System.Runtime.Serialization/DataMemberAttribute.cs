using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 IsNameSetExplicitly                      ModelPrimitiveType bool bool bool Bool
    // 01C Order                                    ModelPrimitiveType int int int Int32
    // 020 IsRequired                               ModelPrimitiveType bool bool bool Bool
    // 021 EmitDefaultValue                         ModelPrimitiveType bool bool bool Bool
    public partial class DataMemberAttribute : DataModel
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
            var value   = new DataMemberAttribute() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.IsNameSetExplicitly                       = GetBool(new IntPtr(p + 0x018)); // 0x18 IsNameSetExplicitly         ( ModelPrimitiveType bool bool bool Bool )
            value.Order                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Order                       ( ModelPrimitiveType int int int Int32 )
            value.IsRequired                                = GetBool(new IntPtr(p + 0x020)); // 0x20 IsRequired                  ( ModelPrimitiveType bool bool bool Bool )
            value.EmitDefaultValue                          = GetBool(new IntPtr(p + 0x021)); // 0x21 EmitDefaultValue            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
