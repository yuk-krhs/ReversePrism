using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 000185D17ED8 ModelEnumListType IReadOnlyList`1<AnnounceCategory> IReadOnlyList`1<AnnounceCategory> List<AnnounceCategory> Pointer
    // 018 BeginDateTime                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 LastUpdateDateTime                       000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 DisplayNewMarkEndDateTime                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<AnnounceDetailStatus> IL2CPP_TYPE_GENERICINST
    // 048 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 050 ArticleId                                000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 060 Body                                     000186671910 ModelPrimitiveType string string string String
    // 000 CategoryFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_category_codec                 FieldCodec`1<AnnounceCategory> IL2CPP_TYPE_GENERICINST
    // 068 Category                                 000185CCDF88 ModelEnumListType RepeatedField`1<AnnounceCategory> RepeatedField`1<AnnounceCategory> List<AnnounceCategory> Pointer
    // 000 GenreFieldNumber                         int IL2CPP_TYPE_I4
    // 070 Genre                                    0001866BFD50 ModelEnumType AnnounceGenre AnnounceGenre AnnounceGenre Int32
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 078 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    // 000 BeginDateTimeFieldNumber                 int IL2CPP_TYPE_I4
    // 080 _BeginDateTime                           000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LastUpdateDateTimeFieldNumber            int IL2CPP_TYPE_I4
    // 088 _LastUpdateDateTime                      000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 DisplayNewMarkEndDateTimeFieldNumber     int IL2CPP_TYPE_I4
    // 090 _DisplayNewMarkEndDateTime               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsDisplayUpdateDateTimeFieldNumber       int IL2CPP_TYPE_I4
    // 098 IsDisplayUpdateDateTime                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 JumpListFieldNumber                      int IL2CPP_TYPE_I4
    // 010 _repeated_jumpList_codec                 FieldCodec`1<JumpStatus> IL2CPP_TYPE_GENERICINST
    // 0A0 JumpList                                 000185CE2348 ModelClassListType RepeatedField`1<JumpStatus> RepeatedField`1<JumpStatus> List<JumpStatus> Pointer
    public partial class AnnounceDetailStatus
    {
        public List<AnnounceCategory>?                  Category                                { get; set; }
        public DateTime                                 BeginDateTime                           { get; set; }
        public DateTime                                 LastUpdateDateTime                      { get; set; }
        public DateTime                                 DisplayNewMarkEndDateTime               { get; set; }
        public string                                   ArticleId                               { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Body                                    { get; set; }
        public AnnounceGenre                            Genre                                   { get; set; }
        public string                                   BannerUrl                               { get; set; }
        public Timestamp?                               _BeginDateTime                          { get; set; }
        public Timestamp?                               _LastUpdateDateTime                     { get; set; }
        public Timestamp?                               _DisplayNewMarkEndDateTime              { get; set; }
        public bool                                     IsDisplayUpdateDateTime                 { get; set; }
        public List<JumpStatus>?                        JumpList                                { get; set; }

        public static AnnounceDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceDetailStatus();

            value.Category                                  = GetEnumList<AnnounceCategory>(new IntPtr(p + 0x068)); // 0270D0F4F1A0 0x68 Category                    ( 000185CCDF88 ModelEnumListType RepeatedField`1<AnnounceCategory> RepeatedField`1<AnnounceCategory> List<AnnounceCategory> Pointer )
            value.BeginDateTime                             = GetDateTime(new IntPtr(p + 0x018)); // 0270D0F4F000 0x18 BeginDateTime               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.LastUpdateDateTime                        = GetDateTime(new IntPtr(p + 0x028)); // 0270D0F4F020 0x28 LastUpdateDateTime          ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.DisplayNewMarkEndDateTime                 = GetDateTime(new IntPtr(p + 0x038)); // 0270D0F4F040 0x38 DisplayNewMarkEndDateTime   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ArticleId                                 = GetString(new IntPtr(p + 0x050)); // 0270D0F4F0C0 0x50 ArticleId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x058)); // 0270D0F4F100 0x58 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x060)); // 0270D0F4F140 0x60 Body                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Genre                                     = (AnnounceGenre)GetInt32(new IntPtr(p + 0x070)); // 0270D0F4F1E0 0x70 Genre                       ( 0001866BFD50 ModelEnumType AnnounceGenre AnnounceGenre AnnounceGenre Int32 )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x078)); // 0270D0F4F220 0x78 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value._BeginDateTime                            = GetObject<Timestamp>(new IntPtr(p + 0x080), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F4F260 0x80 _BeginDateTime              ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._LastUpdateDateTime                       = GetObject<Timestamp>(new IntPtr(p + 0x088), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F4F2A0 0x88 _LastUpdateDateTime         ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._DisplayNewMarkEndDateTime                = GetObject<Timestamp>(new IntPtr(p + 0x090), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F4F2E0 0x90 _DisplayNewMarkEndDateTime  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsDisplayUpdateDateTime                   = GetBool(new IntPtr(p + 0x098)); // 0270D0F4F320 0x98 IsDisplayUpdateDateTime     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.JumpList                                  = GetObjectList<JumpStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.JumpStatus.FromPointer); // 0270D0F4F380 0xA0 JumpList                    ( 000185CE2348 ModelClassListType RepeatedField`1<JumpStatus> RepeatedField`1<JumpStatus> List<JumpStatus> Pointer )
            value.BeginDateTime                 = ToDateTime(value._BeginDateTime);
            value.LastUpdateDateTime            = ToDateTime(value._LastUpdateDateTime);
            value.DisplayNewMarkEndDateTime     = ToDateTime(value._DisplayNewMarkEndDateTime);

            return value;
        }
    }
}
