using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_VisibleLights                          ModelClassListType List`1<Light2D> List`1<Light2D> List<Light2D> Pointer
    // 018 M_VisibleShadows                         ModelClassListType List`1<ShadowCasterGroup2D> List`1<ShadowCasterGroup2D> List<ShadowCasterGroup2D> Pointer
    public partial class Light2DCullResult : DataModel
    {
        public List<Light2D>?                           M_VisibleLights                         { get; set; }
        public List<ShadowCasterGroup2D>?               M_VisibleShadows                        { get; set; }

        public static Light2DCullResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light2DCullResult() { Pointer= p0 };

            value.M_VisibleLights                           = GetObjectList<Light2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Light2D.FromPointer); // 0x10 M_VisibleLights             ( ModelClassListType List`1<Light2D> List`1<Light2D> List<Light2D> Pointer )
            value.M_VisibleShadows                          = GetObjectList<ShadowCasterGroup2D>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShadowCasterGroup2D.FromPointer); // 0x18 M_VisibleShadows            ( ModelClassListType List`1<ShadowCasterGroup2D> List`1<ShadowCasterGroup2D> List<ShadowCasterGroup2D> Pointer )

            return value;
        }
    }
}
