using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_VendorKey                              string IL2CPP_TYPE_STRING
    // 000 k_EventTopicName                         string IL2CPP_TYPE_STRING
    // 000 k_MaxEventsPerHour                       int IL2CPP_TYPE_I4
    // 000 k_MaxNumberOfElements                    int IL2CPP_TYPE_I4
    // 000 k_Version                                int IL2CPP_TYPE_I4
    public partial class Telemetry : DataModel
    {

        public static Telemetry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Telemetry() { Pointer= p0 };


            return value;
        }
    }
}
