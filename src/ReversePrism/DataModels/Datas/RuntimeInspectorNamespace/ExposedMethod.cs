using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 Properties                               ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer
    // 020 IsExtensionMethod                        ModelPrimitiveType bool bool bool Bool
    public partial class ExposedMethod : DataModel
    {
        public MethodInfo?                              Method                                  { get; set; }
        public RuntimeInspectorButtonAttribute?         Properties                              { get; set; }
        public bool                                     IsExtensionMethod                       { get; set; }

        public static ExposedMethod? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExposedMethod() { Pointer= p0 };

            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x10 Method                      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Properties                                = GetObject<RuntimeInspectorButtonAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeInspectorButtonAttribute.FromPointer); // 0x18 Properties                  ( ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer )
            value.IsExtensionMethod                         = GetBool(new IntPtr(p + 0x020)); // 0x20 IsExtensionMethod           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
