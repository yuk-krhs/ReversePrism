using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 000185D17ED8 ModelEnumListType IReadOnlyList`1<AnnounceCategory> IReadOnlyList`1<AnnounceCategory> List<AnnounceCategory> Pointer
    // 018 DisplayNewMarkEndDateTime                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 LastUpdateDateTime                       000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 BeginDateTime                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<AnnounceStatus> IL2CPP_TYPE_GENERICINST
    // 048 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ArticleIdFieldNumber                     int IL2CPP_TYPE_I4
    // 050 ArticleId                                000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 058 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 CategoryFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_category_codec                 FieldCodec`1<AnnounceCategory> IL2CPP_TYPE_GENERICINST
    // 060 Category                                 000185CCDF88 ModelEnumListType RepeatedField`1<AnnounceCategory> RepeatedField`1<AnnounceCategory> List<AnnounceCategory> Pointer
    // 000 GenreFieldNumber                         int IL2CPP_TYPE_I4
    // 068 Genre                                    0001866BFD50 ModelEnumType AnnounceGenre AnnounceGenre AnnounceGenre Int32
    // 000 BannerUrlFieldNumber                     int IL2CPP_TYPE_I4
    // 070 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    // 000 DisplayNewMarkEndDateTimeFieldNumber     int IL2CPP_TYPE_I4
    // 078 _DisplayNewMarkEndDateTime               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 LastUpdateDateTimeFieldNumber            int IL2CPP_TYPE_I4
    // 080 _LastUpdateDateTime                      000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 088 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateTimeFieldNumber                 int IL2CPP_TYPE_I4
    // 090 _BeginDateTime                           000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsDisplayUpdateDateTimeFieldNumber       int IL2CPP_TYPE_I4
    // 098 IsDisplayUpdateDateTime                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AnnounceStatus : DataModel
    {
        public List<AnnounceCategory>?                  Category                                { get; set; }
        public DateTime                                 DisplayNewMarkEndDateTime               { get; set; }
        public DateTime                                 LastUpdateDateTime                      { get; set; }
        public DateTime                                 BeginDateTime                           { get; set; }
        public string                                   ArticleId                               { get; set; }
        public string                                   Title                                   { get; set; }
        public AnnounceGenre                            Genre                                   { get; set; }
        public string                                   BannerUrl                               { get; set; }
        public Timestamp?                               _DisplayNewMarkEndDateTime              { get; set; }
        public Timestamp?                               _LastUpdateDateTime                     { get; set; }
        public int                                      SortId                                  { get; set; }
        public Timestamp?                               _BeginDateTime                          { get; set; }
        public bool                                     IsDisplayUpdateDateTime                 { get; set; }

        public static AnnounceStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceStatus() { Pointer= p0 };

            value.Category                                  = GetEnumList<AnnounceCategory>(new IntPtr(p + 0x060)); // 024660EFF358 0x60 Category                    ( 000185CCDF88 ModelEnumListType RepeatedField`1<AnnounceCategory> RepeatedField`1<AnnounceCategory> List<AnnounceCategory> Pointer )
            value.DisplayNewMarkEndDateTime                 = GetDateTime(new IntPtr(p + 0x018)); // 024660EFF1F8 0x18 DisplayNewMarkEndDateTime   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.LastUpdateDateTime                        = GetDateTime(new IntPtr(p + 0x028)); // 024660EFF218 0x28 LastUpdateDateTime          ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDateTime                             = GetDateTime(new IntPtr(p + 0x038)); // 024660EFF238 0x38 BeginDateTime               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ArticleId                                 = GetString(new IntPtr(p + 0x050)); // 024660EFF2B8 0x50 ArticleId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x058)); // 024660EFF2F8 0x58 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Genre                                     = (AnnounceGenre)GetInt32(new IntPtr(p + 0x068)); // 024660EFF398 0x68 Genre                       ( 0001866BFD50 ModelEnumType AnnounceGenre AnnounceGenre AnnounceGenre Int32 )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x070)); // 024660EFF3D8 0x70 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value._DisplayNewMarkEndDateTime                = GetObject<Timestamp>(new IntPtr(p + 0x078), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EFF418 0x78 _DisplayNewMarkEndDateTime  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._LastUpdateDateTime                       = GetObject<Timestamp>(new IntPtr(p + 0x080), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EFF458 0x80 _LastUpdateDateTime         ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x088)); // 024660EFF498 0x88 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDateTime                            = GetObject<Timestamp>(new IntPtr(p + 0x090), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EFF4D8 0x90 _BeginDateTime              ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsDisplayUpdateDateTime                   = GetBool(new IntPtr(p + 0x098)); // 024660EFF518 0x98 IsDisplayUpdateDateTime     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DisplayNewMarkEndDateTime     = ToDateTime(value._DisplayNewMarkEndDateTime);
            value.LastUpdateDateTime            = ToDateTime(value._LastUpdateDateTime);
            value.BeginDateTime                 = ToDateTime(value._BeginDateTime);

            return value;
        }
    }
}
