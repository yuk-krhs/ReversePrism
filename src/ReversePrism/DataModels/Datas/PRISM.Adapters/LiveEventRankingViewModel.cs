using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 014 SelectedFunctionIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SelectedRewardIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C SelectedRankingIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 onChangeIndex                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventRankingViewModel : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public int                                      SelectedFunctionIndex                   { get; set; }
        public int                                      SelectedRewardIndex                     { get; set; }
        public int                                      SelectedRankingIndex                    { get; set; }

        public static LiveEventRankingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingViewModel() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 024666301C48 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SelectedFunctionIndex                     = GetInt32(new IntPtr(p + 0x014)); // 024666301C68 0x14 SelectedFunctionIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedRewardIndex                       = GetInt32(new IntPtr(p + 0x018)); // 024666301C88 0x18 SelectedRewardIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectedRankingIndex                      = GetInt32(new IntPtr(p + 0x01C)); // 024666301CA8 0x1C SelectedRankingIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
