using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_label                                  ModelPrimitiveType string string string String
    // 018 M_isInitializer                          ModelPrimitiveType bool bool bool Bool
    // 01C M_visibility                             ModelEnumType ButtonVisibility ButtonVisibility ButtonVisibility Int32
    public partial class RuntimeInspectorButtonAttribute : DataModel
    {
        public string                                   M_label                                 { get; set; }
        public bool                                     M_isInitializer                         { get; set; }
        public ButtonVisibility                         M_visibility                            { get; set; }

        public static RuntimeInspectorButtonAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInspectorButtonAttribute() { Pointer= p0 };

            value.M_label                                   = GetString(new IntPtr(p + 0x010)); // 0x10 M_label                     ( ModelPrimitiveType string string string String )
            value.M_isInitializer                           = GetBool(new IntPtr(p + 0x018)); // 0x18 M_isInitializer             ( ModelPrimitiveType bool bool bool Bool )
            value.M_visibility                              = (ButtonVisibility)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_visibility                ( ModelEnumType ButtonVisibility ButtonVisibility ButtonVisibility Int32 )

            return value;
        }
    }
}
