using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_DeferredLights                         ModelClassType DeferredLights DeferredLights DeferredLights Pointer
    public partial class DeferredPass : DataModel
    {
        public DeferredLights?                          M_DeferredLights                        { get; set; }

        public static DeferredPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeferredPass() { Pointer= p0 };

            value.M_DeferredLights                          = GetObject<DeferredLights>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.DeferredLights.FromPointer); // 0xE0 M_DeferredLights            ( ModelClassType DeferredLights DeferredLights DeferredLights Pointer )

            return value;
        }
    }
}
