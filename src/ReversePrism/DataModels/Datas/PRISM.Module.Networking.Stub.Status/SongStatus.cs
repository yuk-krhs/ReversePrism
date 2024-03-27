using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseLinkActiveDate                   000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 FirstClearedDate                         000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<SongStatus> IL2CPP_TYPE_GENERICINST
    // 040 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSongIdFieldNumber                     int IL2CPP_TYPE_I4
    // 048 MstSongId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSongTypeIdFieldNumber                 int IL2CPP_TYPE_I4
    // 04C MstSongTypeId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 050 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 054 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BpmFieldNumber                           int IL2CPP_TYPE_I4
    // 058 Bpm                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsAdvanceDownloadFieldNumber             int IL2CPP_TYPE_I4
    // 05C IsAdvanceDownload                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsSongPartsFieldNumber                   int IL2CPP_TYPE_I4
    // 05D IsSongParts                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PurchaseLinkFieldNumber                  int IL2CPP_TYPE_I4
    // 060 PurchaseLink                             000186671910 ModelPrimitiveType string string string String
    // 000 PurchaseLinkActiveDateFieldNumber        int IL2CPP_TYPE_I4
    // 068 _PurchaseLinkActiveDate                  000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 070 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SongCategoryFieldNumber                  int IL2CPP_TYPE_I4
    // 078 SongCategory                             000186529080 ModelEnumType SongCategory SongCategory SongCategory Int32
    // 000 DifficultyLevelListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_difficultyLevelList_codec      FieldCodec`1<SongDifficultyLevelStatus> IL2CPP_TYPE_GENERICINST
    // 080 DifficultyLevelList                      000185CF1868 ModelClassListType RepeatedField`1<SongDifficultyLevelStatus> RepeatedField`1<SongDifficultyLevelStatus> List<SongDifficultyLevelStatus> Pointer
    // 000 IsPlayedFieldNumber                      int IL2CPP_TYPE_I4
    // 088 IsPlayed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 FirstClearedDateFieldNumber              int IL2CPP_TYPE_I4
    // 090 _FirstClearedDate                        000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 OriginalMemberIdolListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_originalMemberIdolList_codec   FieldCodec`1<MvIdolStatus> IL2CPP_TYPE_GENERICINST
    // 098 OriginalMemberIdolList                   000185CE77F8 ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer
    // 000 IsFocusCameraFieldNumber                 int IL2CPP_TYPE_I4
    // 0A0 IsFocusCamera                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 Is3DFieldNumber                          int IL2CPP_TYPE_I4
    // 0A1 Is3D                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 Is2DFieldNumber                          int IL2CPP_TYPE_I4
    // 0A2 Is2D                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SongStatus
    {
        public DateTime                                 PurchaseLinkActiveDate                  { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 FirstClearedDate                        { get; set; }
        public int                                      MstSongId                               { get; set; }
        public int                                      MstSongTypeId                           { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      Bpm                                     { get; set; }
        public bool                                     IsAdvanceDownload                       { get; set; }
        public bool                                     IsSongParts                             { get; set; }
        public string                                   PurchaseLink                            { get; set; }
        public Timestamp?                               _PurchaseLinkActiveDate                 { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public SongCategory                             SongCategory                            { get; set; }
        public List<SongDifficultyLevelStatus>?         DifficultyLevelList                     { get; set; }
        public bool                                     IsPlayed                                { get; set; }
        public Timestamp?                               _FirstClearedDate                       { get; set; }
        public List<MvIdolStatus>?                      OriginalMemberIdolList                  { get; set; }
        public bool                                     IsFocusCamera                           { get; set; }
        public bool                                     Is3D                                    { get; set; }
        public bool                                     Is2D                                    { get; set; }

        public static SongStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongStatus();

            value.PurchaseLinkActiveDate                    = GetDateTime(new IntPtr(p + 0x010)); // 0270D1373CA0 0x10 PurchaseLinkActiveDate      ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0270D1373CC0 0x20 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FirstClearedDate                          = GetDateTime(new IntPtr(p + 0x030)); // 0270D1373CE0 0x30 FirstClearedDate            ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstSongId                                 = GetInt32(new IntPtr(p + 0x048)); // 0270D1373D60 0x48 MstSongId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSongTypeId                             = GetInt32(new IntPtr(p + 0x04C)); // 0270D1373DA0 0x4C MstSongTypeId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x050)); // 0270D1373DE0 0x50 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x054)); // 0270D1373E20 0x54 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Bpm                                       = GetInt32(new IntPtr(p + 0x058)); // 0270D1373E60 0x58 Bpm                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsAdvanceDownload                         = GetBool(new IntPtr(p + 0x05C)); // 0270D1373EA0 0x5C IsAdvanceDownload           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSongParts                               = GetBool(new IntPtr(p + 0x05D)); // 0270D1373EE0 0x5D IsSongParts                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PurchaseLink                              = GetString(new IntPtr(p + 0x060)); // 0270D1373F20 0x60 PurchaseLink                ( 000186671910 ModelPrimitiveType string string string String )
            value._PurchaseLinkActiveDate                   = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1373F60 0x68 _PurchaseLinkActiveDate     ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x070), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1373FA0 0x70 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SongCategory                              = (SongCategory)GetInt32(new IntPtr(p + 0x078)); // 0270D1373FE0 0x78 SongCategory                ( 000186529080 ModelEnumType SongCategory SongCategory SongCategory Int32 )
            value.DifficultyLevelList                       = GetObjectList<SongDifficultyLevelStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.SongDifficultyLevelStatus.FromPointer); // 0270D1374040 0x80 DifficultyLevelList         ( 000185CF1868 ModelClassListType RepeatedField`1<SongDifficultyLevelStatus> RepeatedField`1<SongDifficultyLevelStatus> List<SongDifficultyLevelStatus> Pointer )
            value.IsPlayed                                  = GetBool(new IntPtr(p + 0x088)); // 0270D1374080 0x88 IsPlayed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._FirstClearedDate                         = GetObject<Timestamp>(new IntPtr(p + 0x090), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D13740C0 0x90 _FirstClearedDate           ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.OriginalMemberIdolList                    = GetObjectList<MvIdolStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.MvIdolStatus.FromPointer); // 0270D1374120 0x98 OriginalMemberIdolList      ( 000185CE77F8 ModelClassListType RepeatedField`1<MvIdolStatus> RepeatedField`1<MvIdolStatus> List<MvIdolStatus> Pointer )
            value.IsFocusCamera                             = GetBool(new IntPtr(p + 0x0A0)); // 0270D1374160 0xA0 IsFocusCamera               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Is3D                                      = GetBool(new IntPtr(p + 0x0A1)); // 0270D13741A0 0xA1 Is3D                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Is2D                                      = GetBool(new IntPtr(p + 0x0A2)); // 0270D13741E0 0xA2 Is2D                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PurchaseLinkActiveDate        = ToDateTime(value._PurchaseLinkActiveDate);
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.FirstClearedDate              = ToDateTime(value._FirstClearedDate);

            return value;
        }
    }
}
