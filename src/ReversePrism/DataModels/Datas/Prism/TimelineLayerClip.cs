using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType TimelineLayerBehaviour TimelineLayerBehaviour TimelineLayerBehaviour Pointer
    // 020 Parent                                   ModelClassType Transform Transform Transform Pointer
    // 028 Layer                                    ModelClassType TimelineLayer TimelineLayer TimelineLayer Pointer
    public partial class TimelineLayerClip : DataModel
    {
        public TimelineLayerBehaviour?                  Behaviour                               { get; set; }
        public Transform?                               Parent                                  { get; set; }
        public TimelineLayer?                           Layer                                   { get; set; }

        public static TimelineLayerClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineLayerClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<TimelineLayerBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimelineLayerBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType TimelineLayerBehaviour TimelineLayerBehaviour TimelineLayerBehaviour Pointer )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 Parent                      ( ModelClassType Transform Transform Transform Pointer )
            value.Layer                                     = GetObject<TimelineLayer>(new IntPtr(p + 0x028), ReversePrism.DataModels.TimelineLayer.FromPointer); // 0x28 Layer                       ( ModelClassType TimelineLayer TimelineLayer TimelineLayer Pointer )

            return value;
        }
    }
}
