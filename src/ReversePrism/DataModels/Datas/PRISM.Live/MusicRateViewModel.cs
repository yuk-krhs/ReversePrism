using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RateType                                 ModelEnumType MusicRateType MusicRateType MusicRateType Int32
    // 014 MasterId                                 ModelPrimitiveType int int int Int32
    // 018 FrameTypeLevel                           ModelPrimitiveType int int int Int32
    // 01C Star                                     ModelPrimitiveType int int int Int32
    // 020 Rate                                     ModelPrimitiveType float float float Single
    public partial class MusicRateViewModel : DataModel
    {
        public MusicRateType                            RateType                                { get; set; }
        public int                                      MasterId                                { get; set; }
        public int                                      FrameTypeLevel                          { get; set; }
        public int                                      Star                                    { get; set; }
        public float                                    Rate                                    { get; set; }

        public static MusicRateViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateViewModel() { Pointer= p0 };

            value.RateType                                  = (MusicRateType)GetInt32(new IntPtr(p + 0x010)); // 0x10 RateType                    ( ModelEnumType MusicRateType MusicRateType MusicRateType Int32 )
            value.MasterId                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 MasterId                    ( ModelPrimitiveType int int int Int32 )
            value.FrameTypeLevel                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 FrameTypeLevel              ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Star                        ( ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x020)); // 0x20 Rate                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
