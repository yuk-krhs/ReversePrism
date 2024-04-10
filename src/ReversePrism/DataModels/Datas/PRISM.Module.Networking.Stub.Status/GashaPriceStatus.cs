using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResetDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<GashaPriceStatus> IL2CPP_TYPE_GENERICINST
    // 040 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaPriceIdFieldNumber                  int IL2CPP_TYPE_I4
    // 048 GashaPriceId                             000186671910 ModelPrimitiveType string string string String
    // 000 ExecCountFieldNumber                     int IL2CPP_TYPE_I4
    // 050 ExecCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PriceProductFieldNumber                  int IL2CPP_TYPE_I4
    // 058 PriceProduct                             0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 UseRangeFieldNumber                      int IL2CPP_TYPE_I4
    // 060 UseRange                                 00018660C9D0 ModelClassType RangeStatus RangeStatus RangeStatus Pointer
    // 000 IsRetryFieldNumber                       int IL2CPP_TYPE_I4
    // 068 IsRetry                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 LimitTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 06C LimitType                                000186606410 ModelEnumType GashaLimitType GashaLimitType GashaLimitType Int32
    // 000 LimitCountTypeFieldNumber                int IL2CPP_TYPE_I4
    // 070 LimitCountType                           000186605D80 ModelEnumType GashaLimitCountType GashaLimitCountType GashaLimitCountType Int32
    // 000 LimitValueFieldNumber                    int IL2CPP_TYPE_I4
    // 074 LimitValue                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsActiveFieldNumber                      int IL2CPP_TYPE_I4
    // 078 IsActive                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ResetDateFieldNumber                     int IL2CPP_TYPE_I4
    // 080 _ResetDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 RemainingExecCountFieldNumber            int IL2CPP_TYPE_I4
    // 088 RemainingExecCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 DiscountAmountFieldNumber                int IL2CPP_TYPE_I4
    // 08C DiscountAmount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 090 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 098 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PopFieldNumber                           int IL2CPP_TYPE_I4
    // 0A0 Pop                                      000186671910 ModelPrimitiveType string string string String
    // 000 ButtonTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 0A8 ButtonType                               0001865F36E0 ModelEnumType GashaButtonType GashaButtonType GashaButtonType Int32
    // 000 ButtonTextFieldNumber                    int IL2CPP_TYPE_I4
    // 0B0 ButtonText                               000186671910 ModelPrimitiveType string string string String
    // 000 IsEmphasisFieldNumber                    int IL2CPP_TYPE_I4
    // 0B8 IsEmphasis                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 0BC SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ButtonColorFieldNumber                   int IL2CPP_TYPE_I4
    // 0C0 ButtonColor                              000186671910 ModelPrimitiveType string string string String
    // 000 IsCompensationFieldNumber                int IL2CPP_TYPE_I4
    // 0C8 IsCompensation                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GashaPriceStatus : DataModel
    {
        public DateTime                                 ResetDate                               { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public string                                   GashaPriceId                            { get; set; }
        public int                                      ExecCount                               { get; set; }
        public ProductWithAmountStatus?                 PriceProduct                            { get; set; }
        public RangeStatus?                             UseRange                                { get; set; }
        public bool                                     IsRetry                                 { get; set; }
        public GashaLimitType                           LimitType                               { get; set; }
        public GashaLimitCountType                      LimitCountType                          { get; set; }
        public int                                      LimitValue                              { get; set; }
        public bool                                     IsActive                                { get; set; }
        public Timestamp?                               _ResetDate                              { get; set; }
        public int                                      RemainingExecCount                      { get; set; }
        public int                                      DiscountAmount                          { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public string                                   Pop                                     { get; set; }
        public GashaButtonType                          ButtonType                              { get; set; }
        public string                                   ButtonText                              { get; set; }
        public bool                                     IsEmphasis                              { get; set; }
        public int                                      SortId                                  { get; set; }
        public string                                   ButtonColor                             { get; set; }
        public bool                                     IsCompensation                          { get; set; }

        public static GashaPriceStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaPriceStatus() { Pointer= p0 };

            value.ResetDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 024661538730 0x10 ResetDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 024661538750 0x20 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x030)); // 024661538770 0x30 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaPriceId                              = GetString(new IntPtr(p + 0x048)); // 0246615387F0 0x48 GashaPriceId                ( 000186671910 ModelPrimitiveType string string string String )
            value.ExecCount                                 = GetInt32(new IntPtr(p + 0x050)); // 024661538830 0x50 ExecCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PriceProduct                              = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024661538870 0x58 PriceProduct                ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.UseRange                                  = GetObject<RangeStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.RangeStatus.FromPointer); // 0246615388B0 0x60 UseRange                    ( 00018660C9D0 ModelClassType RangeStatus RangeStatus RangeStatus Pointer )
            value.IsRetry                                   = GetBool(new IntPtr(p + 0x068)); // 0246615388F0 0x68 IsRetry                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LimitType                                 = (GashaLimitType)GetInt32(new IntPtr(p + 0x06C)); // 024661538930 0x6C LimitType                   ( 000186606410 ModelEnumType GashaLimitType GashaLimitType GashaLimitType Int32 )
            value.LimitCountType                            = (GashaLimitCountType)GetInt32(new IntPtr(p + 0x070)); // 024661538970 0x70 LimitCountType              ( 000186605D80 ModelEnumType GashaLimitCountType GashaLimitCountType GashaLimitCountType Int32 )
            value.LimitValue                                = GetInt32(new IntPtr(p + 0x074)); // 0246615389B0 0x74 LimitValue                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x078)); // 0246615389F0 0x78 IsActive                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._ResetDate                                = GetObject<Timestamp>(new IntPtr(p + 0x080), ReversePrism.DataModels.Timestamp.FromPointer); // 024661538A30 0x80 _ResetDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.RemainingExecCount                        = GetInt32(new IntPtr(p + 0x088)); // 024661538A70 0x88 RemainingExecCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DiscountAmount                            = GetInt32(new IntPtr(p + 0x08C)); // 024661538AB0 0x8C DiscountAmount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x090), ReversePrism.DataModels.Timestamp.FromPointer); // 024661538AF0 0x90 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x098), ReversePrism.DataModels.Timestamp.FromPointer); // 024661538B30 0x98 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Pop                                       = GetString(new IntPtr(p + 0x0A0)); // 024661538B70 0xA0 Pop                         ( 000186671910 ModelPrimitiveType string string string String )
            value.ButtonType                                = (GashaButtonType)GetInt32(new IntPtr(p + 0x0A8)); // 024661538BB0 0xA8 ButtonType                  ( 0001865F36E0 ModelEnumType GashaButtonType GashaButtonType GashaButtonType Int32 )
            value.ButtonText                                = GetString(new IntPtr(p + 0x0B0)); // 024661538BF0 0xB0 ButtonText                  ( 000186671910 ModelPrimitiveType string string string String )
            value.IsEmphasis                                = GetBool(new IntPtr(p + 0x0B8)); // 024661538C30 0xB8 IsEmphasis                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x0BC)); // 024661538C70 0xBC SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ButtonColor                               = GetString(new IntPtr(p + 0x0C0)); // 024661538CB0 0xC0 ButtonColor                 ( 000186671910 ModelPrimitiveType string string string String )
            value.IsCompensation                            = GetBool(new IntPtr(p + 0x0C8)); // 024661538CF0 0xC8 IsCompensation              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResetDate                     = ToDateTime(value._ResetDate);
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
