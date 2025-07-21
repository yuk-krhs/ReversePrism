using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Director                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 028 LayerClips                               ModelClassListType List`1<TimelineLayerClip> List`1<TimelineLayerClip> List<TimelineLayerClip> Pointer
    public partial class TimelineLayerController : DataModel
    {
        public PlayableDirector?                        Director                                { get; set; }
        public List<TimelineLayerClip>?                 LayerClips                              { get; set; }

        public static TimelineLayerController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineLayerController() { Pointer= p0 };

            value.Director                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x20 Director                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.LayerClips                                = GetObjectList<TimelineLayerClip>(new IntPtr(p + 0x028), ReversePrism.DataModels.TimelineLayerClip.FromPointer); // 0x28 LayerClips                  ( ModelClassListType List`1<TimelineLayerClip> List`1<TimelineLayerClip> List<TimelineLayerClip> Pointer )

            return value;
        }
    }
}
