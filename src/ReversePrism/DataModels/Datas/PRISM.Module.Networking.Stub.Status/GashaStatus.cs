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
    // 000 _parser                                  MessageParser`1<GashaStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaIdFieldNumber                       int IL2CPP_TYPE_I4
    // 038 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 000 GashaContentsTypeFieldNumber             int IL2CPP_TYPE_I4
    // 040 GashaContentsType                        0001865F4BE0 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 048 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 050 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PriceListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_priceList_codec                FieldCodec`1<GashaPriceStatus> IL2CPP_TYPE_GENERICINST
    // 058 PriceList                                000185CDBF68 ModelClassListType RepeatedField`1<GashaPriceStatus> RepeatedField`1<GashaPriceStatus> List<GashaPriceStatus> Pointer
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 060 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    // 000 CautionFieldNumber                       int IL2CPP_TYPE_I4
    // 068 Caution                                  000186671910 ModelPrimitiveType string string string String
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 070 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 000 IsPickupFieldNumber                      int IL2CPP_TYPE_I4
    // 078 IsPickup                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 07C SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsBonusFieldNumber                       int IL2CPP_TYPE_I4
    // 080 IsBonus                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PrismGaugeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 088 PrismGaugeId                             000186671910 ModelPrimitiveType string string string String
    // 000 GashaExchangeIdFieldNumber               int IL2CPP_TYPE_I4
    // 090 GashaExchangeId                          000186671910 ModelPrimitiveType string string string String
    // 000 StepListFieldNumber                      int IL2CPP_TYPE_I4
    // 010 _repeated_stepList_codec                 FieldCodec`1<GashaStepStatus> IL2CPP_TYPE_GENERICINST
    // 098 StepList                                 000185CDD658 ModelClassListType RepeatedField`1<GashaStepStatus> RepeatedField`1<GashaStepStatus> List<GashaStepStatus> Pointer
    // 000 IsCompensationFieldNumber                int IL2CPP_TYPE_I4
    // 0A0 IsCompensation                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 DetailIdListFieldNumber                  int IL2CPP_TYPE_I4
    // 018 _repeated_detailIdList_codec             FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 0A8 DetailIdList                             000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class GashaStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public string                                   GashaId                                 { get; set; }
        public GashaContentsType                        GashaContentsType                       { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public List<GashaPriceStatus>?                  PriceList                               { get; set; }
        public string                                   BannerUrl                               { get; set; }
        public string                                   Caution                                 { get; set; }
        public string                                   ResourceId                              { get; set; }
        public bool                                     IsPickup                                { get; set; }
        public int                                      SortId                                  { get; set; }
        public bool                                     IsBonus                                 { get; set; }
        public string                                   PrismGaugeId                            { get; set; }
        public string                                   GashaExchangeId                         { get; set; }
        public List<GashaStepStatus>?                   StepList                                { get; set; }
        public bool                                     IsCompensation                          { get; set; }
        public List<string>?                            DetailIdList                            { get; set; }

        public static GashaStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 024661547160 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 024661547180 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaId                                   = GetString(new IntPtr(p + 0x038)); // 024661547200 0x38 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaContentsType                         = (GashaContentsType)GetInt32(new IntPtr(p + 0x040)); // 024661547240 0x40 GashaContentsType           ( 0001865F4BE0 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 024661547280 0x48 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0246615472C0 0x50 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PriceList                                 = GetObjectList<GashaPriceStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.GashaPriceStatus.FromPointer); // 024661547320 0x58 PriceList                   ( 000185CDBF68 ModelClassListType RepeatedField`1<GashaPriceStatus> RepeatedField`1<GashaPriceStatus> List<GashaPriceStatus> Pointer )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x060)); // 024661547360 0x60 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Caution                                   = GetString(new IntPtr(p + 0x068)); // 0246615473A0 0x68 Caution                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceId                                = GetString(new IntPtr(p + 0x070)); // 0246615473E0 0x70 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.IsPickup                                  = GetBool(new IntPtr(p + 0x078)); // 024661547420 0x78 IsPickup                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x07C)); // 024661547460 0x7C SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsBonus                                   = GetBool(new IntPtr(p + 0x080)); // 0246615474A0 0x80 IsBonus                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PrismGaugeId                              = GetString(new IntPtr(p + 0x088)); // 0246615474E0 0x88 PrismGaugeId                ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x090)); // 024661547520 0x90 GashaExchangeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.StepList                                  = GetObjectList<GashaStepStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.GashaStepStatus.FromPointer); // 024661547580 0x98 StepList                    ( 000185CDD658 ModelClassListType RepeatedField`1<GashaStepStatus> RepeatedField`1<GashaStepStatus> List<GashaStepStatus> Pointer )
            value.IsCompensation                            = GetBool(new IntPtr(p + 0x0A0)); // 0246615475C0 0xA0 IsCompensation              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x0A8)); // 024661547620 0xA8 DetailIdList                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
