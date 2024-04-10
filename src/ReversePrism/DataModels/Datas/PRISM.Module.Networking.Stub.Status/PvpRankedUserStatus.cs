using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpRankedUserStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstEventId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UserIdFieldNumber                        int IL2CPP_TYPE_I4
    // 020 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 028 Rank                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 030 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 FavoriteProduceIdolFieldNumber           int IL2CPP_TYPE_I4
    // 038 FavoriteProduceIdol                      000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer
    // 000 MstAchievementIdListFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_mstAchievementIdList_codec     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 040 MstAchievementIdList                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 CommentFieldNumber                       int IL2CPP_TYPE_I4
    // 048 Comment                                  000186671910 ModelPrimitiveType string string string String
    // 000 PvpUnitListFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_pvpUnitList_codec              FieldCodec`1<PvpUnitStatus> IL2CPP_TYPE_GENERICINST
    // 050 PvpUnitList                              000185CEE2F8 ModelClassListType RepeatedField`1<PvpUnitStatus> RepeatedField`1<PvpUnitStatus> List<PvpUnitStatus> Pointer
    public partial class PvpRankedUserStatus : DataModel
    {
        public int                                      MstEventId                              { get; set; }
        public string                                   UserId                                  { get; set; }
        public int                                      Rank                                    { get; set; }
        public string                                   Name                                    { get; set; }
        public ProduceIdolStatus?                       FavoriteProduceIdol                     { get; set; }
        public List<int>?                               MstAchievementIdList                    { get; set; }
        public string                                   Comment                                 { get; set; }
        public List<PvpUnitStatus>?                     PvpUnitList                             { get; set; }

        public static PvpRankedUserStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpRankedUserStatus() { Pointer= p0 };

            value.MstEventId                                = GetInt32(new IntPtr(p + 0x018)); // 024660FB0F90 0x18 MstEventId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 024660FB0FD0 0x20 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x028)); // 024660FB1010 0x28 Rank                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x030)); // 024660FB1050 0x30 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.FavoriteProduceIdol                       = GetObject<ProduceIdolStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolStatus.FromPointer); // 024660FB1090 0x38 FavoriteProduceIdol         ( 000186550070 ModelClassType ProduceIdolStatus ProduceIdolStatus ProduceIdolStatus Pointer )
            value.MstAchievementIdList                      = GetInt32List(new IntPtr(p + 0x040)); // 024660FB10F0 0x40 MstAchievementIdList        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.Comment                                   = GetString(new IntPtr(p + 0x048)); // 024660FB1130 0x48 Comment                     ( 000186671910 ModelPrimitiveType string string string String )
            value.PvpUnitList                               = GetObjectList<PvpUnitStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.PvpUnitStatus.FromPointer); // 024660FB1190 0x50 PvpUnitList                 ( 000185CEE2F8 ModelClassListType RepeatedField`1<PvpUnitStatus> RepeatedField`1<PvpUnitStatus> List<PvpUnitStatus> Pointer )

            return value;
        }
    }
}
