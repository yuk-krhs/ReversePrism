using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Distance                                 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 000 <current>k__BackingField                 ProximitySensor IL2CPP_TYPE_CLASS
    public partial class ProximitySensor
    {
        public AxisControl?                             Distance                                { get; set; }

        public static ProximitySensor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProximitySensor();

            value.Distance                                  = GetObject<AxisControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.AxisControl.FromPointer); // 0270D771A720 0x170 Distance                    ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
