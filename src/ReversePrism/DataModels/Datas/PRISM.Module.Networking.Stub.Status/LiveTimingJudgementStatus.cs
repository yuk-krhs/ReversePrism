using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveTimingJudgementStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PerfectFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Perfect                                  ModelPrimitiveType int int int Int32
    // 000 GreatFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Great                                    ModelPrimitiveType int int int Int32
    // 000 GoodFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Good                                     ModelPrimitiveType int int int Int32
    // 000 MissFieldNumber                          int IL2CPP_TYPE_I4
    // 024 Miss                                     ModelPrimitiveType int int int Int32
    // 000 GreatFastFieldNumber                     int IL2CPP_TYPE_I4
    // 028 GreatFast                                ModelPrimitiveType int int int Int32
    // 000 GreatSlowFieldNumber                     int IL2CPP_TYPE_I4
    // 02C GreatSlow                                ModelPrimitiveType int int int Int32
    // 000 GreatReverseFieldNumber                  int IL2CPP_TYPE_I4
    // 030 GreatReverse                             ModelPrimitiveType int int int Int32
    // 000 GoodFastFieldNumber                      int IL2CPP_TYPE_I4
    // 034 GoodFast                                 ModelPrimitiveType int int int Int32
    // 000 GoodSlowFieldNumber                      int IL2CPP_TYPE_I4
    // 038 GoodSlow                                 ModelPrimitiveType int int int Int32
    // 000 GoodReverseFieldNumber                   int IL2CPP_TYPE_I4
    // 03C GoodReverse                              ModelPrimitiveType int int int Int32
    // 000 ShinyFieldNumber                         int IL2CPP_TYPE_I4
    // 040 Shiny                                    ModelPrimitiveType int int int Int32
    // 000 PerfectFastFieldNumber                   int IL2CPP_TYPE_I4
    // 044 PerfectFast                              ModelPrimitiveType int int int Int32
    // 000 PerfectSlowFieldNumber                   int IL2CPP_TYPE_I4
    // 048 PerfectSlow                              ModelPrimitiveType int int int Int32
    public partial class LiveTimingJudgementStatus : DataModel
    {
        public int                                      Perfect                                 { get; set; }
        public int                                      Great                                   { get; set; }
        public int                                      Good                                    { get; set; }
        public int                                      Miss                                    { get; set; }
        public int                                      GreatFast                               { get; set; }
        public int                                      GreatSlow                               { get; set; }
        public int                                      GreatReverse                            { get; set; }
        public int                                      GoodFast                                { get; set; }
        public int                                      GoodSlow                                { get; set; }
        public int                                      GoodReverse                             { get; set; }
        public int                                      Shiny                                   { get; set; }
        public int                                      PerfectFast                             { get; set; }
        public int                                      PerfectSlow                             { get; set; }

        public static LiveTimingJudgementStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveTimingJudgementStatus() { Pointer= p0 };

            value.Perfect                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Perfect                     ( ModelPrimitiveType int int int Int32 )
            value.Great                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Great                       ( ModelPrimitiveType int int int Int32 )
            value.Good                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Good                        ( ModelPrimitiveType int int int Int32 )
            value.Miss                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Miss                        ( ModelPrimitiveType int int int Int32 )
            value.GreatFast                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 GreatFast                   ( ModelPrimitiveType int int int Int32 )
            value.GreatSlow                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C GreatSlow                   ( ModelPrimitiveType int int int Int32 )
            value.GreatReverse                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 GreatReverse                ( ModelPrimitiveType int int int Int32 )
            value.GoodFast                                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 GoodFast                    ( ModelPrimitiveType int int int Int32 )
            value.GoodSlow                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 GoodSlow                    ( ModelPrimitiveType int int int Int32 )
            value.GoodReverse                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C GoodReverse                 ( ModelPrimitiveType int int int Int32 )
            value.Shiny                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Shiny                       ( ModelPrimitiveType int int int Int32 )
            value.PerfectFast                               = GetInt32(new IntPtr(p + 0x044)); // 0x44 PerfectFast                 ( ModelPrimitiveType int int int Int32 )
            value.PerfectSlow                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 PerfectSlow                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
