using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 01C CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 020 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 024 Rank                                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 028 TotalPower                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourIdolStatus
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      CardId                                  { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public int                                      TotalPower                              { get; set; }

        public static ChallengeTourIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourIdolStatus();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 027004151458 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x01C)); // 027004151498 0x1C CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x020)); // 0270041514D8 0x20 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x024)); // 027004151518 0x24 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x028)); // 027004151558 0x28 TotalPower                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
