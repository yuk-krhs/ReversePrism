using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <IsOpenGL>k__BackingField                bool IL2CPP_TYPE_BOOLEAN
    // 001 <IsDX10>k__BackingField                  bool IL2CPP_TYPE_BOOLEAN
    public partial class DeferredConfig : DataModel
    {

        public static DeferredConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeferredConfig() { Pointer= p0 };


            return value;
        }
    }
}
