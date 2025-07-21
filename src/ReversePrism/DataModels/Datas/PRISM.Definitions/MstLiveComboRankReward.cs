using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DifficultyLevel                          ModelPrimitiveType int int int Int32
    // 014 ComboRank                                ModelPrimitiveType int int int Int32
    // 018 ProductIdWithAmountList                  ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class MstLiveComboRankReward : DataModel
    {
        public int                                      DifficultyLevel                         { get; set; }
        public int                                      ComboRank                               { get; set; }
        public List<string>?                            ProductIdWithAmountList                 { get; set; }

        public static MstLiveComboRankReward? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveComboRankReward() { Pointer= p0 };

            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 DifficultyLevel             ( ModelPrimitiveType int int int Int32 )
            value.ComboRank                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 ComboRank                   ( ModelPrimitiveType int int int Int32 )
            value.ProductIdWithAmountList                   = GetStringList(new IntPtr(p + 0x018)); // 0x18 ProductIdWithAmountList     ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
