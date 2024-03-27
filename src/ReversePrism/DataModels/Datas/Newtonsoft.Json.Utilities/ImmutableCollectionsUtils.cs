using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ImmutableListGenericInterfaceTypeName    string IL2CPP_TYPE_STRING
    // 000 ImmutableQueueGenericInterfaceTypeName   string IL2CPP_TYPE_STRING
    // 000 ImmutableStackGenericInterfaceTypeName   string IL2CPP_TYPE_STRING
    // 000 ImmutableSetGenericInterfaceTypeName     string IL2CPP_TYPE_STRING
    // 000 ImmutableArrayTypeName                   string IL2CPP_TYPE_STRING
    // 000 ImmutableArrayGenericTypeName            string IL2CPP_TYPE_STRING
    // 000 ImmutableListTypeName                    string IL2CPP_TYPE_STRING
    // 000 ImmutableListGenericTypeName             string IL2CPP_TYPE_STRING
    // 000 ImmutableQueueTypeName                   string IL2CPP_TYPE_STRING
    // 000 ImmutableQueueGenericTypeName            string IL2CPP_TYPE_STRING
    // 000 ImmutableStackTypeName                   string IL2CPP_TYPE_STRING
    // 000 ImmutableStackGenericTypeName            string IL2CPP_TYPE_STRING
    // 000 ImmutableSortedSetTypeName               string IL2CPP_TYPE_STRING
    // 000 ImmutableSortedSetGenericTypeName        string IL2CPP_TYPE_STRING
    // 000 ImmutableHashSetTypeName                 string IL2CPP_TYPE_STRING
    // 000 ImmutableHashSetGenericTypeName          string IL2CPP_TYPE_STRING
    // 000 ArrayContractImmutableCollectionDefinitions IList`1<ImmutableCollectionTypeInfo> IL2CPP_TYPE_GENERICINST
    // 000 ImmutableDictionaryGenericInterfaceTypeName string IL2CPP_TYPE_STRING
    // 000 ImmutableDictionaryTypeName              string IL2CPP_TYPE_STRING
    // 000 ImmutableDictionaryGenericTypeName       string IL2CPP_TYPE_STRING
    // 000 ImmutableSortedDictionaryTypeName        string IL2CPP_TYPE_STRING
    // 000 ImmutableSortedDictionaryGenericTypeName string IL2CPP_TYPE_STRING
    // 008 DictionaryContractImmutableCollectionDefinitions IList`1<ImmutableCollectionTypeInfo> IL2CPP_TYPE_GENERICINST
    public partial class ImmutableCollectionsUtils
    {

        public static ImmutableCollectionsUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImmutableCollectionsUtils();


            return value;
        }
    }
}
