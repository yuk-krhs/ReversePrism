using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _dynamicCodeGeneration                   Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 002 _fullyTrusted                            Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 IdPropertyName                           string IL2CPP_TYPE_STRING
    // 000 RefPropertyName                          string IL2CPP_TYPE_STRING
    // 000 TypePropertyName                         string IL2CPP_TYPE_STRING
    // 000 ValuePropertyName                        string IL2CPP_TYPE_STRING
    // 000 ArrayValuesPropertyName                  string IL2CPP_TYPE_STRING
    // 000 ShouldSerializePrefix                    string IL2CPP_TYPE_STRING
    // 000 SpecifiedPostfix                         string IL2CPP_TYPE_STRING
    // 000 ConcurrentDictionaryTypeName             string IL2CPP_TYPE_STRING
    // 008 CreatorCache                             ThreadSafeStore`2<Type, Func`2<<object>[], <object>>> IL2CPP_TYPE_GENERICINST
    // 010 AssociatedMetadataTypesCache             ThreadSafeStore`2<Type, Type> IL2CPP_TYPE_GENERICINST
    // 018 MetadataTypeAttributeReflectionObject    ModelClassType ReflectionObject ReflectionObject ReflectionObject Pointer
    public partial class JsonTypeReflector : DataModel
    {
        public ReflectionObject?                        MetadataTypeAttributeReflectionObject   { get; set; }

        public static JsonTypeReflector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonTypeReflector() { Pointer= p0 };

            value.MetadataTypeAttributeReflectionObject     = GetObject<ReflectionObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.ReflectionObject.FromPointer); // 0x18 MetadataTypeAttributeReflectionObject ( ModelClassType ReflectionObject ReflectionObject ReflectionObject Pointer )

            return value;
        }
    }
}
