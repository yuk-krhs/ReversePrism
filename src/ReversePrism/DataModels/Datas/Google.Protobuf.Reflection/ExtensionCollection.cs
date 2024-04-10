using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 extensionsByTypeInDeclarationOrder       IDictionary`2<MessageDescriptor, IList`1<FieldDescriptor>> IL2CPP_TYPE_GENERICINST
    // 018 extensionsByTypeInNumberOrder            IDictionary`2<MessageDescriptor, IList`1<FieldDescriptor>> IL2CPP_TYPE_GENERICINST
    // 020 <UnorderedExtensions>k__BackingField     IList`1<FieldDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class ExtensionCollection : DataModel
    {

        public static ExtensionCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionCollection() { Pointer= p0 };


            return value;
        }
    }
}
