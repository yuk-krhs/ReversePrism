using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainLightIndex                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 VisibleLights                            NativeArray`1<VisibleLight> IL2CPP_TYPE_GENERICINST
    public partial class LightData : DataModel
    {
        public int                                      MainLightIndex                          { get; set; }

        public static LightData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightData() { Pointer= p0 };

            value.MainLightIndex                            = GetInt32(new IntPtr(p + 0x010)); // 02466BB1A328 0x10 MainLightIndex              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
