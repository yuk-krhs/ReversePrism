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
    // 030 FavoriteDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ArchiveStreamProgramStatus> IL2CPP_TYPE_GENERICINST
    // 040 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStreamProgramIdFieldNumber            int IL2CPP_TYPE_I4
    // 048 MstStreamProgramId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 050 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 DescriptionFieldNumber                   int IL2CPP_TYPE_I4
    // 058 Description                              000186671910 ModelPrimitiveType string string string String
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 060 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 068 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PerformerIdListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_performerIdList_codec          FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 070 PerformerIdList                          000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SecondsFieldNumber                       int IL2CPP_TYPE_I4
    // 078 Seconds                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsFavoriteFieldNumber                    int IL2CPP_TYPE_I4
    // 07C IsFavorite                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CategoryTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 080 CategoryType                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 FavoriteDateFieldNumber                  int IL2CPP_TYPE_I4
    // 088 _FavoriteDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    public partial class ArchiveStreamProgramStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public DateTime                                 FavoriteDate                            { get; set; }
        public int                                      MstStreamProgramId                      { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public List<int>?                               PerformerIdList                         { get; set; }
        public int                                      Seconds                                 { get; set; }
        public bool                                     IsFavorite                              { get; set; }
        public int                                      CategoryType                            { get; set; }
        public Timestamp?                               _FavoriteDate                           { get; set; }

        public static ArchiveStreamProgramStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ArchiveStreamProgramStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 024662A49C48 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 024662A49C68 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FavoriteDate                              = GetDateTime(new IntPtr(p + 0x030)); // 024662A49C88 0x30 FavoriteDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstStreamProgramId                        = GetInt32(new IntPtr(p + 0x048)); // 024662A49D08 0x48 MstStreamProgramId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x050)); // 024662A49D48 0x50 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x058)); // 024662A49D88 0x58 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 024662A49DC8 0x60 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 024662A49E08 0x68 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PerformerIdList                           = GetInt32List(new IntPtr(p + 0x070)); // 024662A49E68 0x70 PerformerIdList             ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.Seconds                                   = GetInt32(new IntPtr(p + 0x078)); // 024662A49EA8 0x78 Seconds                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x07C)); // 024662A49EE8 0x7C IsFavorite                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CategoryType                              = GetInt32(new IntPtr(p + 0x080)); // 024662A49F28 0x80 CategoryType                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._FavoriteDate                             = GetObject<Timestamp>(new IntPtr(p + 0x088), ReversePrism.DataModels.Timestamp.FromPointer); // 024662A49F68 0x88 _FavoriteDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);
            value.FavoriteDate                  = ToDateTime(value._FavoriteDate);

            return value;
        }
    }
}
