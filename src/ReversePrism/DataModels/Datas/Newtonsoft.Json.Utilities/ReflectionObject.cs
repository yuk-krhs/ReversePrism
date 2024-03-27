using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Creator>k__BackingField                 ObjectConstructor`1<<object>> IL2CPP_TYPE_GENERICINST
    // 018 <Members>k__BackingField                 IDictionary`2<string, ReflectionMember> IL2CPP_TYPE_GENERICINST
    public partial class ReflectionObject
    {

        public static ReflectionObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionObject();


            return value;
        }
    }
}
