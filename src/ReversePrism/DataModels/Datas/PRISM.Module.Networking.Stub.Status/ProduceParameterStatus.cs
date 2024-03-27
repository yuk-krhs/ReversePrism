using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceParameterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 VocalFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Vocal                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VocalRankFieldNumber                     int IL2CPP_TYPE_I4
    // 01C VocalRank                                000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 DanceFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Dance                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DanceRankFieldNumber                     int IL2CPP_TYPE_I4
    // 024 DanceRank                                000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 VisualFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Visual                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 VisualRankFieldNumber                    int IL2CPP_TYPE_I4
    // 02C VisualRank                               000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 MentalFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Mental                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MentalRankFieldNumber                    int IL2CPP_TYPE_I4
    // 034 MentalRank                               000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    public partial class ProduceParameterStatus
    {
        public int                                      Vocal                                   { get; set; }
        public ProduceParameterRank                     VocalRank                               { get; set; }
        public int                                      Dance                                   { get; set; }
        public ProduceParameterRank                     DanceRank                               { get; set; }
        public int                                      Visual                                  { get; set; }
        public ProduceParameterRank                     VisualRank                              { get; set; }
        public int                                      Mental                                  { get; set; }
        public ProduceParameterRank                     MentalRank                              { get; set; }

        public static ProduceParameterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceParameterStatus();

            value.Vocal                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D1122A90 0x18 Vocal                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VocalRank                                 = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x01C)); // 0270D1122AD0 0x1C VocalRank                   ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Dance                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D1122B10 0x20 Dance                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DanceRank                                 = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x024)); // 0270D1122B50 0x24 DanceRank                   ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Visual                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D1122B90 0x28 Visual                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VisualRank                                = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x02C)); // 0270D1122BD0 0x2C VisualRank                  ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Mental                                    = GetInt32(new IntPtr(p + 0x030)); // 0270D1122C10 0x30 Mental                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MentalRank                                = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x034)); // 0270D1122C50 0x34 MentalRank                  ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )

            return value;
        }
    }
}
