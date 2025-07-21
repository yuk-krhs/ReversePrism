using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnceDisplayedResult                      ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 AlbumViewedIds                           ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 LastViewedBeginBreakTime                 ModelPrimitiveType long long long Int64
    // 028 SelectedAllSongIdolTab                   ModelPrimitiveType int int int Int32
    // 030 albumViewedIdsHashSet                    HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventSaveData : DataModel
    {
        public List<int>?                               OnceDisplayedResult                     { get; set; }
        public List<int>?                               AlbumViewedIds                          { get; set; }
        public long                                     LastViewedBeginBreakTime                { get; set; }
        public int                                      SelectedAllSongIdolTab                  { get; set; }

        public static LiveEventSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventSaveData() { Pointer= p0 };

            value.OnceDisplayedResult                       = GetInt32List(new IntPtr(p + 0x010)); // 0x10 OnceDisplayedResult         ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.AlbumViewedIds                            = GetInt32List(new IntPtr(p + 0x018)); // 0x18 AlbumViewedIds              ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LastViewedBeginBreakTime                  = GetInt64(new IntPtr(p + 0x020)); // 0x20 LastViewedBeginBreakTime    ( ModelPrimitiveType long long long Int64 )
            value.SelectedAllSongIdolTab                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 SelectedAllSongIdolTab      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
