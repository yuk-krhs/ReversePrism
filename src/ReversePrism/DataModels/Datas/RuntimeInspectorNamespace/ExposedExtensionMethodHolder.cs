using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExtendedType                             000186693B90 ModelClassType Type Type Type Pointer
    // 018 Method                                   000186614240 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 Properties                               00018669B780 ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer
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

            value.ExtendedType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466B249B88 0x10 ExtendedType                ( 000186693B90 ModelClassType Type Type Type Pointer )
            value.Method                                    = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 02466B249BA8 0x18 Method                      ( 000186614240 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.Properties                                = GetObject<RuntimeInspectorButtonAttribute>(new IntPtr(p + 0x020), ReversePrism.DataModels.RuntimeInspectorButtonAttribute.FromPointer); // 02466B249BC8 0x20 Properties                  ( 00018669B780 ModelClassType RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute RuntimeInspectorButtonAttribute Pointer )

            return value;
        }
    }
}
