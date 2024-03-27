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
    // 000 _parser                                  MessageParser`1<CampaignIconStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MenuTypeFieldNumber                      int IL2CPP_TYPE_I4
    // 038 MenuType                                 0001865FDCF0 ModelEnumType MenuType MenuType MenuType Int32
    // 000 CampaignIconResourceListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_campaignIconResourceList_codec FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 040 CampaignIconResourceList                 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 CampaignIconResourceFieldNumber          int IL2CPP_TYPE_I4
    // 048 CampaignIconResource                     000186671910 ModelPrimitiveType string string string String
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 050 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 058 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class CampaignIconStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public MenuType                                 MenuType                                { get; set; }
        public List<string>?                            CampaignIconResourceList                { get; set; }
        public string                                   CampaignIconResource                    { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }

        public static CampaignIconStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CampaignIconStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D0B4CC90 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D0B4CCB0 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MenuType                                  = (MenuType)GetInt32(new IntPtr(p + 0x038)); // 0270D0B4CD30 0x38 MenuType                    ( 0001865FDCF0 ModelEnumType MenuType MenuType MenuType Int32 )
            value.CampaignIconResourceList                  = GetStringList(new IntPtr(p + 0x040)); // 0270D0B4CD90 0x40 CampaignIconResourceList    ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.CampaignIconResource                      = GetString(new IntPtr(p + 0x048)); // 0270D0B4CDD0 0x48 CampaignIconResource        ( 000186671910 ModelPrimitiveType string string string String )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x050), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0B4CE10 0x50 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0B4CE50 0x58 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}
