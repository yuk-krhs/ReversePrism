using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _nullValueHandling                       Nullable`1<NullValueHandling> IL2CPP_TYPE_GENERICINST
    // 018 _defaultValueHandling                    Nullable`1<DefaultValueHandling> IL2CPP_TYPE_GENERICINST
    // 020 _referenceLoopHandling                   Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    // 028 _objectCreationHandling                  Nullable`1<ObjectCreationHandling> IL2CPP_TYPE_GENERICINST
    // 030 _typeNameHandling                        Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    // 038 _isReference                             Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 03C _order                                   Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 044 _required                                Nullable`1<Required> IL2CPP_TYPE_GENERICINST
    // 04C _itemIsReference                         Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 _itemReferenceLoopHandling               Nullable`1<ReferenceLoopHandling> IL2CPP_TYPE_GENERICINST
    // 058 _itemTypeNameHandling                    Nullable`1<TypeNameHandling> IL2CPP_TYPE_GENERICINST
    // 060 ItemConverterType                        ModelClassType Type Type Type Pointer
    // 068 <ItemConverterParameters>k__BackingField <object>[] IL2CPP_TYPE_SZARRAY
    // 070 NamingStrategyType                       ModelClassType Type Type Type Pointer
    // 078 <NamingStrategyParameters>k__BackingField <object>[] IL2CPP_TYPE_SZARRAY
    // 080 PropertyName                             ModelPrimitiveType string string string String
    public partial class JsonPropertyAttribute : DataModel
    {
        public Type?                                    ItemConverterType                       { get; set; }
        public Type?                                    NamingStrategyType                      { get; set; }
        public string                                   PropertyName                            { get; set; }

        public static JsonPropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonPropertyAttribute() { Pointer= p0 };

            value.ItemConverterType                         = GetObject<Type>(new IntPtr(p + 0x060), ReversePrism.DataModels.Type.FromPointer); // 0x60 ItemConverterType           ( ModelClassType Type Type Type Pointer )
            value.NamingStrategyType                        = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0x70 NamingStrategyType          ( ModelClassType Type Type Type Pointer )
            value.PropertyName                              = GetString(new IntPtr(p + 0x080)); // 0x80 PropertyName                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
