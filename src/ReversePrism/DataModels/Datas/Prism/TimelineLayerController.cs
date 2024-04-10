using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Director                                 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 028 LayerClips                               000185D14BA8 ModelClassListType List`1<TimelineLayerClip> List`1<TimelineLayerClip> List<TimelineLayerClip> Pointer
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

            value.Director                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x020), ReversePrism.DataModels.PlayableDirector.FromPointer); // 024664F0D938 0x20 Director                    ( 00018674DA70 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.LayerClips                                = GetObjectList<TimelineLayerClip>(new IntPtr(p + 0x028), ReversePrism.DataModels.TimelineLayerClip.FromPointer); // 024664F0D958 0x28 LayerClips                  ( 000185D14BA8 ModelClassListType List`1<TimelineLayerClip> List`1<TimelineLayerClip> List<TimelineLayerClip> Pointer )

            return value;
        }
    }
}
