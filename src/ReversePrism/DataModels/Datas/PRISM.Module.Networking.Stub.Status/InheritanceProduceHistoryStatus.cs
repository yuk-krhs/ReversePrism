using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<InheritanceProduceHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEpisodeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 MstEpisodeId                             ModelPrimitiveType int int int Int32
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 02C DifficultyLevel                          ModelPrimitiveType int int int Int32
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 030 _CreateDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 StrategyListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_strategyList_codec             FieldCodec`1<InheritanceProduceHistoryStrategyStatus> IL2CPP_TYPE_GENERICINST
    // 038 StrategyList                             ModelClassListType RepeatedField`1<InheritanceProduceHistoryStrategyStatus> RepeatedField`1<InheritanceProduceHistoryStrategyStatus> List<InheritanceProduceHistoryStrategyStatus> Pointer
    // 000 IsAutoFieldNumber                        int IL2CPP_TYPE_I4
    // 040 IsAuto                                   ModelPrimitiveType bool bool bool Bool
    public partial class InheritanceProduceHistoryStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstEpisodeId                            { get; set; }
        public int                                      DifficultyLevel                         { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public List<InheritanceProduceHistoryStrategyStatus>? StrategyList                            { get; set; }
        public bool                                     IsAuto                                  { get; set; }

        public static InheritanceProduceHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceProduceHistoryStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstEpisodeId                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstEpisodeId                ( ModelPrimitiveType int int int Int32 )
            value.DifficultyLevel                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C DifficultyLevel             ( ModelPrimitiveType int int int Int32 )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.Timestamp.FromPointer); // 0x30 _CreateDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.StrategyList                              = GetObjectList<InheritanceProduceHistoryStrategyStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.InheritanceProduceHistoryStrategyStatus.FromPointer); // 0x38 StrategyList                ( ModelClassListType RepeatedField`1<InheritanceProduceHistoryStrategyStatus> RepeatedField`1<InheritanceProduceHistoryStrategyStatus> List<InheritanceProduceHistoryStrategyStatus> Pointer )
            value.IsAuto                                    = GetBool(new IntPtr(p + 0x040)); // 0x40 IsAuto                      ( ModelPrimitiveType bool bool bool Bool )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
