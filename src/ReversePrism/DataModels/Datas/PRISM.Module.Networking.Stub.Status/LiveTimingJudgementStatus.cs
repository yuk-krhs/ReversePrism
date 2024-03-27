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
    // 018 Perfect                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GreatFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Great                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoodFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Good                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MissFieldNumber                          int IL2CPP_TYPE_I4
    // 024 Miss                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GreatFastFieldNumber                     int IL2CPP_TYPE_I4
    // 028 GreatFast                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GreatSlowFieldNumber                     int IL2CPP_TYPE_I4
    // 02C GreatSlow                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GreatReverseFieldNumber                  int IL2CPP_TYPE_I4
    // 030 GreatReverse                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoodFastFieldNumber                      int IL2CPP_TYPE_I4
    // 034 GoodFast                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoodSlowFieldNumber                      int IL2CPP_TYPE_I4
    // 038 GoodSlow                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GoodReverseFieldNumber                   int IL2CPP_TYPE_I4
    // 03C GoodReverse                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveTimingJudgementStatus
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

        public static LiveTimingJudgementStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveTimingJudgementStatus();

            value.Perfect                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D135EAC0 0x18 Perfect                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Great                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D135EB00 0x1C Great                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Good                                      = GetInt32(new IntPtr(p + 0x020)); // 0270D135EB40 0x20 Good                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Miss                                      = GetInt32(new IntPtr(p + 0x024)); // 0270D135EB80 0x24 Miss                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GreatFast                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D135EBC0 0x28 GreatFast                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GreatSlow                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D135EC00 0x2C GreatSlow                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GreatReverse                              = GetInt32(new IntPtr(p + 0x030)); // 0270D135EC40 0x30 GreatReverse                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodFast                                  = GetInt32(new IntPtr(p + 0x034)); // 0270D135EC80 0x34 GoodFast                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodSlow                                  = GetInt32(new IntPtr(p + 0x038)); // 0270D135ECC0 0x38 GoodSlow                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodReverse                               = GetInt32(new IntPtr(p + 0x03C)); // 0270D135ED00 0x3C GoodReverse                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
