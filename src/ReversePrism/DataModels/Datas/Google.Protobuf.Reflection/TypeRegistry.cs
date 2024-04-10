using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Empty>k__BackingField                   TypeRegistry IL2CPP_TYPE_CLASS
    // 010 fullNameToMessageMap                     Dictionary`2<string, MessageDescriptor> IL2CPP_TYPE_GENERICINST
    public partial class TypeRegistry : DataModel
    {

        public static TypeRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeRegistry() { Pointer= p0 };


            return value;
        }
    }
}
