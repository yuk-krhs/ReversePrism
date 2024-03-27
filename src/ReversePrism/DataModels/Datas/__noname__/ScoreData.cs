using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Score                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Card                                     000186727840 ModelClassType AutoModePCardModel AutoModePCardModel AutoModePCardModel Pointer
    public partial class ScoreData
    {
        public int                                      Score                                   { get; set; }
        public AutoModePCardModel?                      Card                                    { get; set; }

        public static ScoreData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScoreData();

            value.Score                                     = GetInt32(new IntPtr(p + 0x010)); // 0270DADDE838 0x10 Score                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Card                                      = GetObject<AutoModePCardModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.AutoModePCardModel.FromPointer); // 0270DADDE858 0x18 Card                        ( 000186727840 ModelClassType AutoModePCardModel AutoModePCardModel AutoModePCardModel Pointer )

            return value;
        }
    }
}
