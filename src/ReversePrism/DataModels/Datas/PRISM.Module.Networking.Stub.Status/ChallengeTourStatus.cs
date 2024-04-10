using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ChallengeTourStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChallengeTourIdFieldNumber               int IL2CPP_TYPE_I4
    // 038 ChallengeTourId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 040 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 048 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 050 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 058 Star                                     00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 CurrentUnitFieldNumber                   int IL2CPP_TYPE_I4
    // 060 CurrentUnit                              00018658C400 ModelClassType ChallengeTourUnitStatus ChallengeTourUnitStatus ChallengeTourUnitStatus Pointer
    // 000 StageListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_stageList_codec                FieldCodec`1<ChallengeTourStageStatus> IL2CPP_TYPE_GENERICINST
    // 068 StageList                                000185CD1978 ModelClassListType RepeatedField`1<ChallengeTourStageStatus> RepeatedField`1<ChallengeTourStageStatus> List<ChallengeTourStageStatus> Pointer
    // 000 ProduceIdolUnitFieldNumber               int IL2CPP_TYPE_I4
    // 070 ProduceIdolUnit                          00018658C400 ModelClassType ChallengeTourUnitStatus ChallengeTourUnitStatus ChallengeTourUnitStatus Pointer
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 078 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 LastClearStageNumberFieldNumber          int IL2CPP_TYPE_I4
    // 07C LastClearStageNumber                     0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      ChallengeTourId                         { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public LimitedValueStatus?                      Star                                    { get; set; }
        public ChallengeTourUnitStatus?                 CurrentUnit                             { get; set; }
        public List<ChallengeTourStageStatus>?          StageList                               { get; set; }
        public ChallengeTourUnitStatus?                 ProduceIdolUnit                         { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public int                                      LastClearStageNumber                    { get; set; }

        public static ChallengeTourStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 024660EDE248 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 024660EDE268 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x038)); // 024660EDE2E8 0x38 ChallengeTourId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EDE328 0x40 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EDE368 0x48 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x050)); // 024660EDE3A8 0x50 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<LimitedValueStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024660EDE3E8 0x58 Star                        ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.CurrentUnit                               = GetObject<ChallengeTourUnitStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.ChallengeTourUnitStatus.FromPointer); // 024660EDE428 0x60 CurrentUnit                 ( 00018658C400 ModelClassType ChallengeTourUnitStatus ChallengeTourUnitStatus ChallengeTourUnitStatus Pointer )
            value.StageList                                 = GetObjectList<ChallengeTourStageStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ChallengeTourStageStatus.FromPointer); // 024660EDE488 0x68 StageList                   ( 000185CD1978 ModelClassListType RepeatedField`1<ChallengeTourStageStatus> RepeatedField`1<ChallengeTourStageStatus> List<ChallengeTourStageStatus> Pointer )
            value.ProduceIdolUnit                           = GetObject<ChallengeTourUnitStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ChallengeTourUnitStatus.FromPointer); // 024660EDE4C8 0x70 ProduceIdolUnit             ( 00018658C400 ModelClassType ChallengeTourUnitStatus ChallengeTourUnitStatus ChallengeTourUnitStatus Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x078)); // 024660EDE508 0x78 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastClearStageNumber                      = GetInt32(new IntPtr(p + 0x07C)); // 024660EDE548 0x7C LastClearStageNumber        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
