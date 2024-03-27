using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TrackList                                000185D156A8 ModelClassListType List`1<TrackAsset> List`1<TrackAsset> List<TrackAsset> Pointer
    // 018 ClipList                                 000185D14988 ModelClassListType List`1<TimelineClip> List`1<TimelineClip> List<TimelineClip> Pointer
    // 020 MarkerList                               000185CE61F8 ModelClassListType List`1<IMarker> List`1<IMarker> List<IMarker> Pointer
    public partial class TransientBuildData
    {
        public List<TrackAsset>?                        TrackList                               { get; set; }
        public List<TimelineClip>?                      ClipList                                { get; set; }
        public List<IMarker>?                           MarkerList                              { get; set; }

        public static TransientBuildData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransientBuildData();

            value.TrackList                                 = GetObjectList<TrackAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.TrackAsset.FromPointer); // 027006F4FCD0 0x10 TrackList                   ( 000185D156A8 ModelClassListType List`1<TrackAsset> List`1<TrackAsset> List<TrackAsset> Pointer )
            value.ClipList                                  = GetObjectList<TimelineClip>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimelineClip.FromPointer); // 027006F4FCF0 0x18 ClipList                    ( 000185D14988 ModelClassListType List`1<TimelineClip> List`1<TimelineClip> List<TimelineClip> Pointer )
            value.MarkerList                                = GetObjectList<IMarker>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMarker.FromPointer); // 027006F4FD10 0x20 MarkerList                  ( 000185CE61F8 ModelClassListType List`1<IMarker> List`1<IMarker> List<IMarker> Pointer )

            return value;
        }
    }
}
