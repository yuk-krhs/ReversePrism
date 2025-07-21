using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 FrameType                                ModelPrimitiveType int int int Int32
    // 018 Star                                     ModelPrimitiveType int int int Int32
    // 01C StartRate                                ModelPrimitiveType int int int Int32
    // 020 ProductIdWithAmountList                  ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class MstLiveTotalHighScoreRateReward : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      FrameType                               { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      StartRate                               { get; set; }
        public List<string>?                            ProductIdWithAmountList                 { get; set; }

        public static MstLiveTotalHighScoreRateReward? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveTotalHighScoreRateReward() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.FrameType                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 FrameType                   ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Star                        ( ModelPrimitiveType int int int Int32 )
            value.StartRate                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StartRate                   ( ModelPrimitiveType int int int Int32 )
            value.ProductIdWithAmountList                   = GetStringList(new IntPtr(p + 0x020)); // 0x20 ProductIdWithAmountList     ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
