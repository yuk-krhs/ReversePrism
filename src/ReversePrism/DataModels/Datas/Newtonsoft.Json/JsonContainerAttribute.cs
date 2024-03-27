using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       000186671910 ModelPrimitiveType string string string String
    // 018 Title                                    000186671910 ModelPrimitiveType string string string String
    // 020 Description                              000186671910 ModelPrimitiveType string string string String
    // 028 ItemConverterType                        000186692850 ModelClassType Type Type Type Pointer
    // 030 <ItemConverterParameters>k__BackingField <object>[] IL2CPP_TYPE_SZARRAY
    // 038 NamingStrategyInstance                   00018667F1A0 ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer
    // 040 _isReference                             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 042 _itemIsReference                         Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 044 _itemReferenceLoopHandling               Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    // 04C _itemTypeNameHandling                    Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    // 058 NamingStrategyType                       000186692850 ModelClassType Type Type Type Pointer
    // 060 _namingStrategyParameters                <object>[] IL2CPP_TYPE_SZARRAY
    public partial class JsonContainerAttribute
    {
        public string                                   Id                                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public Type?                                    ItemConverterType                       { get; set; }
        public NamingStrategy?                          NamingStrategyInstance                  { get; set; }
        public Type?                                    NamingStrategyType                      { get; set; }

        public static JsonContainerAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonContainerAttribute();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 027005FE7770 0x10 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 027005FE7790 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 027005FE77B0 0x20 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ItemConverterType                         = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 027005FE77D0 0x28 ItemConverterType           ( 000186692850 ModelClassType Type Type Type Pointer )
            value.NamingStrategyInstance                    = GetObject<NamingStrategy>(new IntPtr(p + 0x038), ReversePrism.DataModels.NamingStrategy.FromPointer); // 027005FE7810 0x38 NamingStrategyInstance      ( 00018667F1A0 ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer )
            value.NamingStrategyType                        = GetObject<Type>(new IntPtr(p + 0x058), ReversePrism.DataModels.Type.FromPointer); // 027005FE78B0 0x58 NamingStrategyType          ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
