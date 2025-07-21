using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Header                                   ModelPrimitiveType string string string String
    // 018 IntermediateScriptingStructName          ModelPrimitiveType string string string String
    // 020 CodegenOptions                           ModelEnumType CodegenOptions CodegenOptions CodegenOptions Int32
    public partial class NativeTypeAttribute : DataModel
    {
        public string                                   Header                                  { get; set; }
        public string                                   IntermediateScriptingStructName         { get; set; }
        public CodegenOptions                           CodegenOptions                          { get; set; }

        public static NativeTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeTypeAttribute() { Pointer= p0 };

            value.Header                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Header                      ( ModelPrimitiveType string string string String )
            value.IntermediateScriptingStructName           = GetString(new IntPtr(p + 0x018)); // 0x18 IntermediateScriptingStructName ( ModelPrimitiveType string string string String )
            value.CodegenOptions                            = (CodegenOptions)GetInt32(new IntPtr(p + 0x020)); // 0x20 CodegenOptions              ( ModelEnumType CodegenOptions CodegenOptions CodegenOptions Int32 )

            return value;
        }
    }
}
