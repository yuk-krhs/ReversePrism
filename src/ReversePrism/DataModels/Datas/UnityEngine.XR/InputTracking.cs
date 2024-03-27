using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 trackingAcquired                         Action`1<XRNodeState> IL2CPP_TYPE_GENERICINST
    // 008 trackingLost                             Action`1<XRNodeState> IL2CPP_TYPE_GENERICINST
    // 010 nodeAdded                                Action`1<XRNodeState> IL2CPP_TYPE_GENERICINST
    // 018 nodeRemoved                              Action`1<XRNodeState> IL2CPP_TYPE_GENERICINST
    public partial class InputTracking
    {

        public static InputTracking? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputTracking();


            return value;
        }
    }
}
