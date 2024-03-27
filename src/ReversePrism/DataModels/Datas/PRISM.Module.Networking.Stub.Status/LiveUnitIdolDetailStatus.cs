using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<LiveUnitIdolDetailStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitIdolTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 028 UnitIdolType                             000186593720 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 030 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 038 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstFavoriteMarkIdFieldNumber             int IL2CPP_TYPE_I4
    // 03C MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 RankFieldNumber                          int IL2CPP_TYPE_I4
    // 040 Rank                                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 044 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 InitialStarFieldNumber                   int IL2CPP_TYPE_I4
    // 048 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CardIdFieldNumber                        int IL2CPP_TYPE_I4
    // 04C CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PotentialLiveSkillFieldNumber            int IL2CPP_TYPE_I4
    // 050 PotentialLiveSkill                       000186568ED0 ModelClassType LivePotentialLiveSkillStatus LivePotentialLiveSkillStatus LivePotentialLiveSkillStatus Pointer
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 058 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 060 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 064 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 068 MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 06C MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 070 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 StarIdolParameterFieldNumber             int IL2CPP_TYPE_I4
    // 078 StarIdolParameter                        00018656E480 ModelClassType StarIdolParameterStatus StarIdolParameterStatus StarIdolParameterStatus Pointer
    // 000 DefaultCostumeSetListFieldNumber         int IL2CPP_TYPE_I4
    // 010 _repeated_defaultCostumeSetList_codec    FieldCodec`1<LiveUnitIdolCostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 080 DefaultCostumeSetList                    000185CE42E8 ModelClassListType RepeatedField`1<LiveUnitIdolCostumeSetStatus> RepeatedField`1<LiveUnitIdolCostumeSetStatus> List<LiveUnitIdolCostumeSetStatus> Pointer
    public partial class LiveUnitIdolDetailStatus
    {
        public DateTime                                 CreateDate                              { get; set; }
        public LiveUnitIdolType                         UnitIdolType                            { get; set; }
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }
        public LivePotentialLiveSkillStatus?            PotentialLiveSkill                      { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public StarIdolParameterStatus?                 StarIdolParameter                       { get; set; }
        public List<LiveUnitIdolCostumeSetStatus>?      DefaultCostumeSetList                   { get; set; }

        public static LiveUnitIdolDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitIdolDetailStatus();

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0270D1363878 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.UnitIdolType                              = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x028)); // 0270D13638F8 0x28 UnitIdolType                ( 000186593720 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x030)); // 0270D1363938 0x30 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x038)); // 0270D1363978 0x38 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x03C)); // 0270D13639B8 0x3C MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x040)); // 0270D13639F8 0x40 Rank                        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x044)); // 0270D1363A38 0x44 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x048)); // 0270D1363A78 0x48 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x04C)); // 0270D1363AB8 0x4C CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialLiveSkill                        = GetObject<LivePotentialLiveSkillStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.LivePotentialLiveSkillStatus.FromPointer); // 0270D1363AF8 0x50 PotentialLiveSkill          ( 000186568ED0 ModelClassType LivePotentialLiveSkillStatus LivePotentialLiveSkillStatus LivePotentialLiveSkillStatus Pointer )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x058), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1363B38 0x58 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x060)); // 0270D1363B78 0x60 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x064)); // 0270D1363BB8 0x64 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x068)); // 0270D1363BF8 0x68 MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x06C)); // 0270D1363C38 0x6C MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x070)); // 0270D1363C98 0x70 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.StarIdolParameter                         = GetObject<StarIdolParameterStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.StarIdolParameterStatus.FromPointer); // 0270D1363CD8 0x78 StarIdolParameter           ( 00018656E480 ModelClassType StarIdolParameterStatus StarIdolParameterStatus StarIdolParameterStatus Pointer )
            value.DefaultCostumeSetList                     = GetObjectList<LiveUnitIdolCostumeSetStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveUnitIdolCostumeSetStatus.FromPointer); // 0270D1363D38 0x80 DefaultCostumeSetList       ( 000185CE42E8 ModelClassListType RepeatedField`1<LiveUnitIdolCostumeSetStatus> RepeatedField`1<LiveUnitIdolCostumeSetStatus> List<LiveUnitIdolCostumeSetStatus> Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
