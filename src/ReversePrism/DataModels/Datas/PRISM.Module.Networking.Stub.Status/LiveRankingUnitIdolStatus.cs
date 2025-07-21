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
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Rank                                     ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 024 Star                                     ModelPrimitiveType int int int Int32
    // 000 TotalPowerFieldNumber                    int IL2CPP_TYPE_I4
    // 028 TotalPower                               ModelPrimitiveType int int int Int32
    // 000 MstPotentialLiveSkillIdFieldNumber       int IL2CPP_TYPE_I4
    // 02C MstPotentialLiveSkillId                  ModelPrimitiveType int int int Int32
    // 000 LiveSkillLevelFieldNumber                int IL2CPP_TYPE_I4
    // 030 LiveSkillLevel                           ModelPrimitiveType int int int Int32
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 034 Slot                                     ModelPrimitiveType int int int Int32
    public partial class LiveRankingUnitIdolStatus : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      TotalPower                              { get; set; }
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public int                                      LiveSkillLevel                          { get; set; }
        public int                                      Slot                                    { get; set; }

        public static LiveRankingUnitIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveRankingUnitIdolStatus() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x020)); // 0x20 Rank                        ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Star                        ( ModelPrimitiveType int int int Int32 )
            value.TotalPower                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 TotalPower                  ( ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstPotentialLiveSkillId     ( ModelPrimitiveType int int int Int32 )
            value.LiveSkillLevel                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 LiveSkillLevel              ( ModelPrimitiveType int int int Int32 )
            value.Slot                                      = GetInt32(new IntPtr(p + 0x034)); // 0x34 Slot                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
