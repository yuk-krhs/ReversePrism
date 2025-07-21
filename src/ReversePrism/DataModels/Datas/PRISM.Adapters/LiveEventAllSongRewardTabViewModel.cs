using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 saveData                                 SavableJsonObject`1<LiveEventSaveData> IL2CPP_TYPE_GENERICINST
    // 018 EventId                                  ModelPrimitiveType int int int Int32
    // 020 IdolIds                                  ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    public partial class LiveEventAllSongRewardTabViewModel : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public List<int>?                               IdolIds                                 { get; set; }

        public static LiveEventAllSongRewardTabViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongRewardTabViewModel() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.IdolIds                                   = GetInt32List(new IntPtr(p + 0x020)); // 0x20 IdolIds                     ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )

            return value;
        }
    }
}
