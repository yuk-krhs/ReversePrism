using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 descriptorsByName                        IDictionary`2<string, IDescriptor> IL2CPP_TYPE_GENERICINST
    // 018 fieldsByNumber                           IDictionary`2<ObjectIntPair`1<IDescriptor>, FieldDescriptor> IL2CPP_TYPE_GENERICINST
    // 020 enumValuesByNumber                       IDictionary`2<ObjectIntPair`1<IDescriptor>, EnumValueDescriptor> IL2CPP_TYPE_GENERICINST
    // 028 dependencies                             HashSet`1<FileDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class DescriptorPool : DataModel
    {

        public static DescriptorPool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DescriptorPool() { Pointer= p0 };


            return value;
        }
    }
}
