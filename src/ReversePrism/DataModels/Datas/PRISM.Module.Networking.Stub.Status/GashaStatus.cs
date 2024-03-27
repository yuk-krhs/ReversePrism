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
    public partial class GashaStatus
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
            var value   = new GashaStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D15A4A18 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D15A4A38 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaId                                   = GetString(new IntPtr(p + 0x038)); // 0270D15A4AB8 0x38 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaContentsType                         = (GashaContentsType)GetInt32(new IntPtr(p + 0x040)); // 0270D15A4AF8 0x40 GashaContentsType           ( 0001865F4BE0 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D15A4B38 0x48 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D15A4B78 0x50 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PriceList                                 = GetObjectList<GashaPriceStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.GashaPriceStatus.FromPointer); // 0270D15A4BD8 0x58 PriceList                   ( 000185CDBF68 ModelClassListType RepeatedField`1<GashaPriceStatus> RepeatedField`1<GashaPriceStatus> List<GashaPriceStatus> Pointer )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x060)); // 0270D15A4C18 0x60 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Caution                                   = GetString(new IntPtr(p + 0x068)); // 0270D15A4C58 0x68 Caution                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceId                                = GetString(new IntPtr(p + 0x070)); // 0270D15A4C98 0x70 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.IsPickup                                  = GetBool(new IntPtr(p + 0x078)); // 0270D15A4CD8 0x78 IsPickup                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x07C)); // 0270D15A4D18 0x7C SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsBonus                                   = GetBool(new IntPtr(p + 0x080)); // 0270D15A4D58 0x80 IsBonus                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PrismGaugeId                              = GetString(new IntPtr(p + 0x088)); // 0270D15A4D98 0x88 PrismGaugeId                ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x090)); // 0270D15A4DD8 0x90 GashaExchangeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.StepList                                  = GetObjectList<GashaStepStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.GashaStepStatus.FromPointer); // 0270D15A4E38 0x98 StepList                    ( 000185CDD658 ModelClassListType RepeatedField`1<GashaStepStatus> RepeatedField`1<GashaStepStatus> List<GashaStepStatus> Pointer )
            value.IsCompensation                            = GetBool(new IntPtr(p + 0x0A0)); // 0270D15A4E78 0xA0 IsCompensation              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x0A8)); // 0270D15A4ED8 0xA8 DetailIdList                ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
