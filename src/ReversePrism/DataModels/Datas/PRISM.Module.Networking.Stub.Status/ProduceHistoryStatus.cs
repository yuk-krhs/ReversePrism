using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ProduceHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 MstEpisodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 02C DifficultyLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 030 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 StrategyListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_strategyList_codec             FieldCodec`1<ProduceHistoryStrategyStatus> IL2CPP_TYPE_GENERICINST
    // 038 StrategyList                             000185CEB688 ModelClassListType RepeatedField`1<ProduceHistoryStrategyStatus> RepeatedField`1<ProduceHistoryStrategyStatus> List<ProduceHistoryStrategyStatus> Pointer
    // 000 IsAutoFieldNumber                        int IL2CPP_TYPE_I4
    // 040 IsAuto                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceHistoryStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      DifficultyLevel                         { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public List<ProduceHistoryStrategyStatus>?      StrategyList                            { get; set; }
        public bool                                     IsAuto                                  { get; set; }

        public static ProduceHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceHistoryStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 024661230F30 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x028)); // 024661230FB0 0x28 MstEpisodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x02C)); // 024661230FF0 0x2C DifficultyLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 024661231030 0x30 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.StrategyList                              = GetObjectList<ProduceHistoryStrategyStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceHistoryStrategyStatus.FromPointer); // 024661231090 0x38 StrategyList                ( 000185CEB688 ModelClassListType RepeatedField`1<ProduceHistoryStrategyStatus> RepeatedField`1<ProduceHistoryStrategyStatus> List<ProduceHistoryStrategyStatus> Pointer )
            value.IsAuto                                    = GetBool(new IntPtr(p + 0x040)); // 0246612310D0 0x40 IsAuto                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
