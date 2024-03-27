using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 Properties                               00018669B4F0 ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer
    // 020 IsExtensionMethod                        0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class ExposedMethod
    {
        public MethodInfo?                              Method                                  { get; set; }
        public RuntimeInspectorButtonAttribute?         Properties                              { get; set; }
        public bool                                     IsExtensionMethod                       { get; set; }

        public static ExposedMethod? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExposedMethod();

            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270DB1E0DA8 0x10 Method                      ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Properties                                = GetObject<RuntimeInspectorButtonAttribute>(new IntPtr(p + 0x018), ReversePrism.DataModels.RuntimeInspectorButtonAttribute.FromPointer); // 0270DB1E0DC8 0x18 Properties                  ( 00018669B4F0 ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer )
            value.IsExtensionMethod                         = GetBool(new IntPtr(p + 0x020)); // 0270DB1E0DE8 0x20 IsExtensionMethod           ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
