using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RateType                                 0001866710F0 ModelEnumType MusicRateType MusicRateType MusicRateType Int32
    // 014 MasterId                                 0001865F4940 ModelPrimitiveType int int int Int32
    // 018 FrameTypeLevel                           0001865F4940 ModelPrimitiveType int int int Int32
    // 01C Star                                     0001865F4940 ModelPrimitiveType int int int Int32
    // 020 Rate                                     000186666F40 ModelPrimitiveType float float float Single
    public partial class MusicRateViewModel
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
            var value   = new MusicRateViewModel();

            value.RateType                                  = (MusicRateType)GetInt32(new IntPtr(p + 0x010)); // 0270D5134D58 0x10 RateType                    ( 0001866710F0 ModelEnumType MusicRateType MusicRateType MusicRateType Int32 )
            value.MasterId                                  = GetInt32(new IntPtr(p + 0x014)); // 0270D5134D78 0x14 MasterId                    ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.FrameTypeLevel                            = GetInt32(new IntPtr(p + 0x018)); // 0270D5134D98 0x18 FrameTypeLevel              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D5134DB8 0x1C Star                        ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Rate                                      = GetSingle(new IntPtr(p + 0x020)); // 0270D5134DD8 0x20 Rate                        ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
