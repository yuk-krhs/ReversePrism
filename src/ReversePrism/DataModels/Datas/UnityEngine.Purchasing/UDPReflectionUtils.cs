using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_InstanceBindingFlags                   BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 k_StaticBindingFlags                     BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 k_PrivateStaticBindingFlags              BindingFlags IL2CPP_TYPE_VALUETYPE
    // 000 s_assemblyTypeCache                      Dictionary`2<Assembly, Type[]> IL2CPP_TYPE_GENERICINST
    // 008 s_typeCache                              Dictionary`2<string, Type> IL2CPP_TYPE_GENERICINST
    // 010 K_whiteListedAssemblies                  000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class UDPReflectionUtils : DataModel
    {
        public List<string>?                            K_whiteListedAssemblies                 { get; set; }

        public static UDPReflectionUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UDPReflectionUtils() { Pointer= p0 };

            value.K_whiteListedAssemblies                   = GetStringList(new IntPtr(p + 0x010)); // 0245A6690220 0x10 K_whiteListedAssemblies     ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
