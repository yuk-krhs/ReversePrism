using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveRankingUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 018 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 024 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Rank                                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 02C Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 030 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 034 TotalPower                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstPotentialLiveSkillIdFieldNumber       int IL2CPP_TYPE_I4
    // 038 MstPotentialLiveSkillId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LiveSkillLevelFieldNumber                int IL2CPP_TYPE_I4
    // 03C LiveSkillLevel                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Slot                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveRankingUnitIdolStatus
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      CardId                                  { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      TotalPower                              { get; set; }
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public int                                      LiveSkillLevel                          { get; set; }
        public int                                      Slot                                    { get; set; }

        public static LiveRankingUnitIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveRankingUnitIdolStatus();

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0270D1353028 0x18 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D1353068 0x1C MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D13530A8 0x20 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x024)); // 0270D13530E8 0x24 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x028)); // 0270D1353128 0x28 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x02C)); // 0270D1353168 0x2C Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x030)); // 0270D13531A8 0x30 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x034)); // 0270D13531E8 0x34 TotalPower                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x038)); // 0270D1353228 0x38 MstPotentialLiveSkillId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveSkillLevel                            = GetInt32(new IntPtr(p + 0x03C)); // 0270D1353268 0x3C LiveSkillLevel              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Slot                                      = GetInt32(new IntPtr(p + 0x040)); // 0270D13532A8 0x40 Slot                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
