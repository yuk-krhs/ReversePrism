using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstUnitId                                ModelPrimitiveType int int int Int32
    // 014 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 018 Season                                   ModelPrimitiveType int int int Int32
    // 020 MstSubSeasonIdList                       ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    public partial class ProduceAutoSettingPopupViewModel : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      Season                                  { get; set; }
        public List<int>?                               MstSubSeasonIdList                      { get; set; }

        public static ProduceAutoSettingPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingPopupViewModel() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Season                      ( ModelPrimitiveType int int int Int32 )
            value.MstSubSeasonIdList                        = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstSubSeasonIdList          ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )

            return value;
        }
    }
}
