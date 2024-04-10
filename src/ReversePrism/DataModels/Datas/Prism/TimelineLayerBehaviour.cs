using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimelineLayer                            00018666FD90 ModelClassType TimelineLayer TimelineLayer TimelineLayer Pointer
    // 018 ParentPath                               0001866722E0 ModelPrimitiveType string string string String
    public partial class TimelineLayerBehaviour : DataModel
    {
        public TimelineLayer?                           TimelineLayer                           { get; set; }
        public string                                   ParentPath                              { get; set; }

        public static TimelineLayerBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineLayerBehaviour() { Pointer= p0 };

            value.TimelineLayer                             = GetObject<TimelineLayer>(new IntPtr(p + 0x010), ReversePrism.DataModels.TimelineLayer.FromPointer); // 024664E75898 0x10 TimelineLayer               ( 00018666FD90 ModelClassType TimelineLayer TimelineLayer TimelineLayer Pointer )
            value.ParentPath                                = GetString(new IntPtr(p + 0x018)); // 024664E758B8 0x18 ParentPath                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
