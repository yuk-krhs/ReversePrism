using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CreatePropertyMethod                   000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 M_CreatePropertyBagMethod                000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 M_CreateIndexedCollectionPropertyBagMethod 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 028 M_CreateSetPropertyBagMethod             000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 M_CreateKeyValueCollectionPropertyBagMethod 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 M_CreateKeyValuePairPropertyBagMethod    000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 M_CreateArrayPropertyBagMethod           000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 M_CreateListPropertyBagMethod            000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 050 M_CreateHashSetPropertyBagMethod         000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 M_CreateDictionaryPropertyBagMethod      000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class ReflectedPropertyBagProvider
    {
        public MethodInfo?                              M_CreatePropertyMethod                  { get; set; }
        public MethodInfo?                              M_CreatePropertyBagMethod               { get; set; }
        public MethodInfo?                              M_CreateIndexedCollectionPropertyBagMethod { get; set; }
        public MethodInfo?                              M_CreateSetPropertyBagMethod            { get; set; }
        public MethodInfo?                              M_CreateKeyValueCollectionPropertyBagMethod { get; set; }
        public MethodInfo?                              M_CreateKeyValuePairPropertyBagMethod   { get; set; }
        public MethodInfo?                              M_CreateArrayPropertyBagMethod          { get; set; }
        public MethodInfo?                              M_CreateListPropertyBagMethod           { get; set; }
        public MethodInfo?                              M_CreateHashSetPropertyBagMethod        { get; set; }
        public MethodInfo?                              M_CreateDictionaryPropertyBagMethod     { get; set; }

        public static ReflectedPropertyBagProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectedPropertyBagProvider();

            value.M_CreatePropertyMethod                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968F30 0x10 M_CreatePropertyMethod      ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreatePropertyBagMethod                 = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968F50 0x18 M_CreatePropertyBagMethod   ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateIndexedCollectionPropertyBagMethod = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968F70 0x20 M_CreateIndexedCollectionPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateSetPropertyBagMethod              = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968F90 0x28 M_CreateSetPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateKeyValueCollectionPropertyBagMethod = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968FB0 0x30 M_CreateKeyValueCollectionPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateKeyValuePairPropertyBagMethod     = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968FD0 0x38 M_CreateKeyValuePairPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateArrayPropertyBagMethod            = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006968FF0 0x40 M_CreateArrayPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateListPropertyBagMethod             = GetObject<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006969010 0x48 M_CreateListPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateHashSetPropertyBagMethod          = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006969030 0x50 M_CreateHashSetPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.M_CreateDictionaryPropertyBagMethod       = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 027006969050 0x58 M_CreateDictionaryPropertyBagMethod ( 000186613DA0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
