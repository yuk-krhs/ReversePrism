using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReceivedDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 ReleaseDate                              000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 FavoriteAddDate                          000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<StoryStatus> IL2CPP_TYPE_GENERICINST
    // 040 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryIdFieldNumber                       int IL2CPP_TYPE_I4
    // 048 StoryId                                  0001865979C0 ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer
    // 000 IsNewFieldNumber                         int IL2CPP_TYPE_I4
    // 050 IsNew                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 StoryStateTypeFieldNumber                int IL2CPP_TYPE_I4
    // 054 StoryStateType                           0001865A45D0 ModelEnumType StoryStateType StoryStateType StoryStateType Int32
    // 000 ReceivedDateFieldNumber                  int IL2CPP_TYPE_I4
    // 058 _ReceivedDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 IsFavoriteFieldNumber                    int IL2CPP_TYPE_I4
    // 060 IsFavorite                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ProductRewardListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_productRewardList_codec        FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 068 ProductRewardList                        000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 070 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ReleaseDateFieldNumber                   int IL2CPP_TYPE_I4
    // 078 _ReleaseDate                             000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 VisibleFieldNumber                       int IL2CPP_TYPE_I4
    // 080 Visible                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 FavoriteAddDateFieldNumber               int IL2CPP_TYPE_I4
    // 088 _FavoriteAddDate                         000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EpisodeTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 090 EpisodeType                              000186596D50 ModelEnumType StoryEpisodeType StoryEpisodeType StoryEpisodeType Int32
    // 000 MstCharacterInfoIdListFieldNumber        int IL2CPP_TYPE_I4
    // 010 _repeated_mstCharacterInfoIdList_codec   FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 098 MstCharacterInfoIdList                   000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class StoryStatus
    {
        public DateTime                                 ReceivedDate                            { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public DateTime                                 FavoriteAddDate                         { get; set; }
        public StoryIDStatus?                           StoryId                                 { get; set; }
        public bool                                     IsNew                                   { get; set; }
        public StoryStateType                           StoryStateType                          { get; set; }
        public Timestamp?                               _ReceivedDate                           { get; set; }
        public bool                                     IsFavorite                              { get; set; }
        public List<ProductWithAmountStatus>?           ProductRewardList                       { get; set; }
        public int                                      SortId                                  { get; set; }
        public Timestamp?                               _ReleaseDate                            { get; set; }
        public bool                                     Visible                                 { get; set; }
        public Timestamp?                               _FavoriteAddDate                        { get; set; }
        public StoryEpisodeType                         EpisodeType                             { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }

        public static StoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryStatus();

            value.ReceivedDate                              = GetDateTime(new IntPtr(p + 0x010)); // 0270D2A3F1E8 0x10 ReceivedDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x020)); // 0270D2A3F208 0x20 ReleaseDate                 ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.FavoriteAddDate                           = GetDateTime(new IntPtr(p + 0x030)); // 0270D2A3F228 0x30 FavoriteAddDate             ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.StoryId                                   = GetObject<StoryIDStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.StoryIDStatus.FromPointer); // 0270D2A3F2A8 0x48 StoryId                     ( 0001865979C0 ModelClassType StoryIDStatus StoryIDStatus StoryIDStatus Pointer )
            value.IsNew                                     = GetBool(new IntPtr(p + 0x050)); // 0270D2A3F2E8 0x50 IsNew                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StoryStateType                            = (StoryStateType)GetInt32(new IntPtr(p + 0x054)); // 0270D2A3F328 0x54 StoryStateType              ( 0001865A45D0 ModelEnumType StoryStateType StoryStateType StoryStateType Int32 )
            value._ReceivedDate                             = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2A3F368 0x58 _ReceivedDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.IsFavorite                                = GetBool(new IntPtr(p + 0x060)); // 0270D2A3F3A8 0x60 IsFavorite                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProductRewardList                         = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D2A3F408 0x68 ProductRewardList           ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x070)); // 0270D2A3F448 0x70 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._ReleaseDate                              = GetObject<Timestamp>(new IntPtr(p + 0x078), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2A3F488 0x78 _ReleaseDate                ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.Visible                                   = GetBool(new IntPtr(p + 0x080)); // 0270D2A3F4C8 0x80 Visible                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value._FavoriteAddDate                          = GetObject<Timestamp>(new IntPtr(p + 0x088), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2A3F508 0x88 _FavoriteAddDate            ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.EpisodeType                               = (StoryEpisodeType)GetInt32(new IntPtr(p + 0x090)); // 0270D2A3F548 0x90 EpisodeType                 ( 000186596D50 ModelEnumType StoryEpisodeType StoryEpisodeType StoryEpisodeType Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x098)); // 0270D2A3F5A8 0x98 MstCharacterInfoIdList      ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.ReceivedDate                  = ToDateTime(value._ReceivedDate);
            value.ReleaseDate                   = ToDateTime(value._ReleaseDate);
            value.FavoriteAddDate               = ToDateTime(value._FavoriteAddDate);

            return value;
        }
    }
}
