using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExtendedType                             ModelClassType Type Type Type Pointer
    // 018 Method                                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 Properties                               ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer
    public partial class ExposedExtensionMethodHolder : DataModel
    {
        public Type?                                    ExtendedType                            { get; set; }
        public MethodInfo?                              Method                                  { get; set; }
        public RuntimeInspectorButtonAttribute?         Properties                              { get; set; }

        public static ExposedExtensionMethodHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExposedExtensionMethodHolder() { Pointer= p0 };

            value.ExtendedType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ExtendedType                ( ModelClassType Type Type Type Pointer )
            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x18 Method                      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Properties                                = GetObject<RuntimeInspectorButtonAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.RuntimeInspectorButtonAttribute.FromPointer); // 0x20 Properties                  ( ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer )

            return value;
        }
    }
}
