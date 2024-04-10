using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 DefaultLight                             0001865243D0 ModelClassType Light Light Light Pointer
    // 028 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 030 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DefaultLightView : DataModel
    {
        public Light?                                   DefaultLight                            { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static DefaultLightView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultLightView() { Pointer= p0 };

            value.DefaultLight                              = GetObject<Light>(new IntPtr(p + 0x020), ReversePrism.DataModels.Light.FromPointer); // 024664FAC0A8 0x20 DefaultLight                ( 0001865243D0 ModelClassType Light Light Light Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x030)); // 024664FAC0E8 0x30 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
