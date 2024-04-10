using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Lock                                     <object> IL2CPP_TYPE_OBJECT
    // 008 _instance                                FSharpUtils IL2CPP_TYPE_CLASS
    // 010 OfSeq                                    000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 MapType                                  000186692850 ModelClassType Type Type Type Pointer
    // 020 FSharpCoreAssembly                       00018658AEE0 ModelClassType Assembly Assembly Assembly Pointer
    // 028 <IsUnion>k__BackingField                 MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 030 <GetUnionCases>k__BackingField           MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 038 <PreComputeUnionTagReader>k__BackingField MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 040 <PreComputeUnionReader>k__BackingField   MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 048 <PreComputeUnionConstructor>k__BackingField MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 050 <GetUnionCaseInfoDeclaringType>k__BackingField Func`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 058 <GetUnionCaseInfoName>k__BackingField    Func`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 060 <GetUnionCaseInfoTag>k__BackingField     Func`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 068 <GetUnionCaseInfoFields>k__BackingField  MethodCall`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 000 FSharpSetTypeName                        string IL2CPP_TYPE_STRING
    // 000 FSharpListTypeName                       string IL2CPP_TYPE_STRING
    // 000 FSharpMapTypeName                        string IL2CPP_TYPE_STRING
    public partial class FSharpUtils : DataModel
    {
        public MethodInfo?                              OfSeq                                   { get; set; }
        public Type?                                    MapType                                 { get; set; }
        public Assembly?                                FSharpCoreAssembly                      { get; set; }

        public static FSharpUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FSharpUtils() { Pointer= p0 };

            value.OfSeq                                     = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0245A603A598 0x10 OfSeq                       ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.MapType                                   = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0245A603A5B8 0x18 MapType                     ( 000186692850 ModelClassType Type Type Type Pointer )
            value.FSharpCoreAssembly                        = GetObject<Assembly>(new IntPtr(p + 0x020), ReversePrism.DataModels.Assembly.FromPointer); // 0245A603A5D8 0x20 FSharpCoreAssembly          ( 00018658AEE0 ModelClassType Assembly Assembly Assembly Pointer )

            return value;
        }
    }
}
