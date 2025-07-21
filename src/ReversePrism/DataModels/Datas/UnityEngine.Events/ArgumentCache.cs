using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ObjectArgument                         ModelClassType Object Object Object Pointer
    // 018 M_ObjectArgumentAssemblyTypeName         ModelPrimitiveType string string string String
    // 020 M_IntArgument                            ModelPrimitiveType int int int Int32
    // 024 M_FloatArgument                          ModelPrimitiveType float float float Single
    // 028 M_StringArgument                         ModelPrimitiveType string string string String
    // 030 M_BoolArgument                           ModelPrimitiveType bool bool bool Bool
    public partial class ArgumentCache : DataModel
    {
        public Object?                                  M_ObjectArgument                        { get; set; }
        public string                                   M_ObjectArgumentAssemblyTypeName        { get; set; }
        public int                                      M_IntArgument                           { get; set; }
        public float                                    M_FloatArgument                         { get; set; }
        public string                                   M_StringArgument                        { get; set; }
        public bool                                     M_BoolArgument                          { get; set; }

        public static ArgumentCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArgumentCache() { Pointer= p0 };

            value.M_ObjectArgument                          = GetObject<Object>(new IntPtr(p + 0x010), ReversePrism.DataModels.Object.FromPointer); // 0x10 M_ObjectArgument            ( ModelClassType Object Object Object Pointer )
            value.M_ObjectArgumentAssemblyTypeName          = GetString(new IntPtr(p + 0x018)); // 0x18 M_ObjectArgumentAssemblyTypeName ( ModelPrimitiveType string string string String )
            value.M_IntArgument                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_IntArgument               ( ModelPrimitiveType int int int Int32 )
            value.M_FloatArgument                           = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_FloatArgument             ( ModelPrimitiveType float float float Single )
            value.M_StringArgument                          = GetString(new IntPtr(p + 0x028)); // 0x28 M_StringArgument            ( ModelPrimitiveType string string string String )
            value.M_BoolArgument                            = GetBool(new IntPtr(p + 0x030)); // 0x30 M_BoolArgument              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
