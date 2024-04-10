using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TotalTechnicalRatingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalRatingFieldNumber                   int IL2CPP_TYPE_I4
    // 018 TotalRating                              0001866656B0 ModelPrimitiveType float float float Single
    // 000 TechnicalRatingFrameTypeFieldNumber      int IL2CPP_TYPE_I4
    // 01C TechnicalRatingFrameType                 000186628020 ModelEnumType TechnicalRatingFrameType TechnicalRatingFrameType TechnicalRatingFrameType Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdFieldNumber                         int IL2CPP_TYPE_I4
    // 024 MstId                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TotalTechnicalRatingStatus : DataModel
    {
        public float                                    TotalRating                             { get; set; }
        public TechnicalRatingFrameType                 TechnicalRatingFrameType                { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      MstId                                   { get; set; }

        public static TotalTechnicalRatingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TotalTechnicalRatingStatus() { Pointer= p0 };

            value.TotalRating                               = GetSingle(new IntPtr(p + 0x018)); // 024661301F40 0x18 TotalRating                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TechnicalRatingFrameType                  = (TechnicalRatingFrameType)GetInt32(new IntPtr(p + 0x01C)); // 024661301F80 0x1C TechnicalRatingFrameType    ( 000186628020 ModelEnumType TechnicalRatingFrameType TechnicalRatingFrameType TechnicalRatingFrameType Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x020)); // 024661301FC0 0x20 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstId                                     = GetInt32(new IntPtr(p + 0x024)); // 024661302000 0x24 MstId                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
