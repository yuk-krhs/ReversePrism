using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_inspectedType                          0001866936B0 ModelClassType Type Type Type Pointer
    // 018 M_editorForChildClasses                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 01C M_inspectedTypeDepth                     0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RuntimeInspectorCustomEditorAttribute : DataModel
    {
        public Type?                                    M_inspectedType                         { get; set; }
        public bool                                     M_editorForChildClasses                 { get; set; }
        public int                                      M_inspectedTypeDepth                    { get; set; }

        public static RuntimeInspectorCustomEditorAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeInspectorCustomEditorAttribute() { Pointer= p0 };

            value.M_inspectedType                           = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466B235E38 0x10 M_inspectedType             ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.M_editorForChildClasses                   = GetBool(new IntPtr(p + 0x018)); // 02466B235E58 0x18 M_editorForChildClasses     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.M_inspectedTypeDepth                      = GetInt32(new IntPtr(p + 0x01C)); // 02466B235E78 0x1C M_inspectedTypeDepth        ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
