using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetType                               000186692F60 ModelClassType Type Type Type Pointer
    // 018 InterfaceType                            000186692F60 ModelClassType Type Type Type Pointer
    // 020 TargetMethods                            000185B7F1F0 ModelClassListType MethodInfo[] MethodInfo[] List<MethodInfo> Pointer
    // 028 InterfaceMethods                         000185B7F1F0 ModelClassListType MethodInfo[] MethodInfo[] List<MethodInfo> Pointer
    public partial class InterfaceMapping
    {
        public Type?                                    TargetType                              { get; set; }
        public Type?                                    InterfaceType                           { get; set; }
        public List<MethodInfo>?                        TargetMethods                           { get; set; }
        public List<MethodInfo>?                        InterfaceMethods                        { get; set; }

        public static InterfaceMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterfaceMapping();

            value.TargetType                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D6A038E8 0x10 TargetType                  ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.InterfaceType                             = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D6A03908 0x18 InterfaceType               ( 000186692F60 ModelClassType Type Type Type Pointer )
            value.TargetMethods                             = GetObjectList<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D6A03928 0x20 TargetMethods               ( 000185B7F1F0 ModelClassListType MethodInfo[] MethodInfo[] List<MethodInfo> Pointer )
            value.InterfaceMethods                          = GetObjectList<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D6A03948 0x28 InterfaceMethods            ( 000185B7F1F0 ModelClassListType MethodInfo[] MethodInfo[] List<MethodInfo> Pointer )

            return value;
        }
    }
}
