using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <ComponentTypeHashToInstance>k__BackingField Dictionary`2<int, IServiceComponent> IL2CPP_TYPE_GENERICINST
    public partial class ComponentRegistry : DataModel
    {

        public static ComponentRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComponentRegistry() { Pointer= p0 };


            return value;
        }
    }
}
