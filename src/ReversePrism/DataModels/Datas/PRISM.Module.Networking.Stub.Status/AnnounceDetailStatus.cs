using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumListType IReadOnlyList`1<AnnounceCategory> IReadOnlyList`1<AnnounceCategory> List<AnnounceCategory> Pointer
    // 018 BeginDateTime                            ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 LastUpdateDateTime                       ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 DisplayNewMarkEndDateTime                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<AnnounceDetailStatus> IL2CPP_TYPE_GENERICINST
    // 048 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 050 ArticleId                                ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Title                                    ModelPrimitiveType string string string String
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 060 Body                                     ModelPrimitiveType string string string String
    // 000 CategoryFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_category_codec                 FieldCodec`1<AnnounceCategory> IL2CPP_TYPE_GENERICINST
    // 068 Category                                 ModelEnumListType RepeatedField`1<AnnounceCategory> RepeatedField`1<AnnounceCategory> List<AnnounceCategory> Pointer
    // 000 GenreFieldNumber                         int IL2CPP_TYPE_I4
    // 070 Genre                                    ModelEnumType AnnounceGenre AnnounceGenre AnnounceGenre Int32
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 078 BannerUrl                                ModelPrimitiveType string string string String
    // 000 BeginDateTimeFieldNumber                 int IL2CPP_TYPE_I4
    // 080 _BeginDateTime                           ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LastUpdateDateTimeFieldNumber            int IL2CPP_TYPE_I4
    // 088 _LastUpdateDateTime                      ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 DisplayNewMarkEndDateTimeFieldNumber     int IL2CPP_TYPE_I4
    // 090 _DisplayNewMarkEndDateTime               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsDisplayUpdateDateTimeFieldNumber       int IL2CPP_TYPE_I4
    // 098 IsDisplayUpdateDateTime                  ModelPrimitiveType bool bool bool Bool
    // 000 JumpListFieldNumber                      int IL2CPP_TYPE_I4
    // 010 _repeated_jumpList_codec                 FieldCodec`1<JumpStatus> IL2CPP_TYPE_GENERICINST
    // 0A0 JumpList                                 ModelClassListType RepeatedField`1<JumpStatus> RepeatedField`1<JumpStatus> List<JumpStatus> Pointer
    public partial class AnnounceDetailStatus : DataModel
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
            var value   = new AnnounceDetailStatus() { Pointer= p0 };

            value.Category                                  = GetEnumList<AnnounceCategory>(new IntPtr(p + 0x068)); // 0x68 Category                    ( ModelEnumListType RepeatedField`1<AnnounceCategory> RepeatedField`1<AnnounceCategory> List<AnnounceCategory> Pointer )
            value.BeginDateTime                             = GetDateTime(new IntPtr(p + 0x018)); // 0x18 BeginDateTime               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.LastUpdateDateTime                        = GetDateTime(new IntPtr(p + 0x028)); // 0x28 LastUpdateDateTime          ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.DisplayNewMarkEndDateTime                 = GetDateTime(new IntPtr(p + 0x038)); // 0x38 DisplayNewMarkEndDateTime   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ArticleId                                 = GetString(new IntPtr(p + 0x050)); // 0x50 ArticleId                   ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x058)); // 0x58 Title                       ( ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x060)); // 0x60 Body                        ( ModelPrimitiveType string string string String )
            value.Genre                                     = (AnnounceGenre)GetInt32(new IntPtr(p + 0x070)); // 0x70 Genre                       ( ModelEnumType AnnounceGenre AnnounceGenre AnnounceGenre Int32 )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x078)); // 0x78 BannerUrl                   ( ModelPrimitiveType string string string String )
            value._BeginDateTime                            = GetObject<Timestamp>(new IntPtr(p + 0x080), ReversePrism.DataModels.Timestamp.FromPointer); // 0x80 _BeginDateTime              ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._LastUpdateDateTime                       = GetObject<Timestamp>(new IntPtr(p + 0x088), ReversePrism.DataModels.Timestamp.FromPointer); // 0x88 _LastUpdateDateTime         ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._DisplayNewMarkEndDateTime                = GetObject<Timestamp>(new IntPtr(p + 0x090), ReversePrism.DataModels.Timestamp.FromPointer); // 0x90 _DisplayNewMarkEndDateTime  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsDisplayUpdateDateTime                   = GetBool(new IntPtr(p + 0x098)); // 0x98 IsDisplayUpdateDateTime     ( ModelPrimitiveType bool bool bool Bool )
            value.JumpList                                  = GetObjectList<JumpStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.JumpStatus.FromPointer); // 0xA0 JumpList                    ( ModelClassListType RepeatedField`1<JumpStatus> RepeatedField`1<JumpStatus> List<JumpStatus> Pointer )
            value.BeginDateTime                 = ToDateTime(value._BeginDateTime);
            value.LastUpdateDateTime            = ToDateTime(value._LastUpdateDateTime);
            value.DisplayNewMarkEndDateTime     = ToDateTime(value._DisplayNewMarkEndDateTime);

            return value;
        }
    }
}
