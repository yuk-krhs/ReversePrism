using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rand                                     ModelClassType Random Random Random Pointer
    // 018 srcDressUpRoomCostumeDictionary          Dictionary`2<int, ValueTuple`2<IDressUpRoomCostumeStatus, IDressUpRoomCostumeStatus>> IL2CPP_TYPE_GENERICINST
    // 020 Idol                                     ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer
    // 028 CostumeChangeViewIdol                    ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer
    // 030 DressCostume                             ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 038 DefaultDressCostumeId                    ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32
    // 050 CasualCostume                            ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 058 DefaultCasualCostumeId                   ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32
    // 070 saveData                                 SavableJsonObject`1<DressUpRoomSaveData> IL2CPP_TYPE_GENERICINST
    // 078 SrcCostumeList                           ModelClassListType IReadOnlyList`1<ICostumeStatus> IReadOnlyList`1<ICostumeStatus> List<ICostumeStatus> Pointer
    // 080 SrcHairstyleList                         ModelClassListType IReadOnlyList`1<IHairstyleStatus> IReadOnlyList`1<IHairstyleStatus> List<IHairstyleStatus> Pointer
    // 088 SrcAccessoryList                         ModelClassListType IReadOnlyList`1<IAccessoryStatus> IReadOnlyList`1<IAccessoryStatus> List<IAccessoryStatus> Pointer
    // 090 ArcCostumeSetList                        ModelClassListType IReadOnlyList`1<ICostumeSetStatus> IReadOnlyList`1<ICostumeSetStatus> List<ICostumeSetStatus> Pointer
    // 098 dCostumeSetDic                           Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 0A0 dDressDic                                Dictionary`2<int, ICostumeStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 dHairstyleDic                            Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 0B0 dAccessoryDic                            Dictionary`2<int, IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 0B8 cCostumeSetDic                           Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 0C0 cDressDic                                Dictionary`2<int, ICostumeStatus> IL2CPP_TYPE_GENERICINST
    // 0C8 cHairstyleDic                            Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 0D0 cAccessoryDic                            Dictionary`2<int, IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 0D8 selectedIndexDic                         Dictionary`2<CostumeType, Dictionary`2<CostumeCategory, int>> IL2CPP_TYPE_GENERICINST
    // 0E0 DressCostumeSetDataList                  ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer
    // 0E8 dressCostumeListDic                      Dictionary`2<CostumeCategory, IList`1<CostumeGridViewCellData>> IL2CPP_TYPE_GENERICINST
    // 0F0 CasualCostumeSetDataList                 ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer
    // 0F8 casualCostumeListDic                     Dictionary`2<CostumeCategory, IList`1<CostumeGridViewCellData>> IL2CPP_TYPE_GENERICINST
    // 100 voiceResources                           Dictionary`2<int, List`1<MstVoiceResource>> IL2CPP_TYPE_GENERICINST
    // 108 UseOtherCharacterCostume                 ModelPrimitiveType bool bool bool Bool
    // 10C CostumeType                              ModelEnumType CostumeType CostumeType CostumeType Int32
    // 110 CostumeTypeInCostumeChangeView           ModelEnumType CostumeType CostumeType CostumeType Int32
    // 114 IsTryOnMode                              ModelPrimitiveType bool bool bool Bool
    // 118 CurrentSelectedTab                       ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    public partial class DressUpRoomViewModel : DataModel
    {
        public Random?                                  Rand                                    { get; set; }
        public DressUpRoomIdol?                         Idol                                    { get; set; }
        public DressUpRoomIdol?                         CostumeChangeViewIdol                   { get; set; }
        public CharacterCostume?                        DressCostume                            { get; set; }
        public IdolCostumeId                            DefaultDressCostumeId                   { get; set; }
        public CharacterCostume?                        CasualCostume                           { get; set; }
        public IdolCostumeId                            DefaultCasualCostumeId                  { get; set; }
        public List<ICostumeStatus>?                    SrcCostumeList                          { get; set; }
        public List<IHairstyleStatus>?                  SrcHairstyleList                        { get; set; }
        public List<IAccessoryStatus>?                  SrcAccessoryList                        { get; set; }
        public List<ICostumeSetStatus>?                 ArcCostumeSetList                       { get; set; }
        public List<CostumeSetListViewCellData>?        DressCostumeSetDataList                 { get; set; }
        public List<CostumeSetListViewCellData>?        CasualCostumeSetDataList                { get; set; }
        public bool                                     UseOtherCharacterCostume                { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public CostumeType                              CostumeTypeInCostumeChangeView          { get; set; }
        public bool                                     IsTryOnMode                             { get; set; }
        public CostumeCategory                          CurrentSelectedTab                      { get; set; }

        public static DressUpRoomViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomViewModel() { Pointer= p0 };

            value.Rand                                      = GetObject<Random>(new IntPtr(p + 0x010), ReversePrism.DataModels.Random.FromPointer); // 0x10 Rand                        ( ModelClassType Random Random Random Pointer )
            value.Idol                                      = GetObject<DressUpRoomIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.DressUpRoomIdol.FromPointer); // 0x20 Idol                        ( ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer )
            value.CostumeChangeViewIdol                     = GetObject<DressUpRoomIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomIdol.FromPointer); // 0x28 CostumeChangeViewIdol       ( ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer )
            value.DressCostume                              = GetObject<CharacterCostume>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0x30 DressCostume                ( ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.DefaultDressCostumeId                     = (IdolCostumeId)GetInt32(new IntPtr(p + 0x038)); // 0x38 DefaultDressCostumeId       ( ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32 )
            value.CasualCostume                             = GetObject<CharacterCostume>(new IntPtr(p + 0x050), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0x50 CasualCostume               ( ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.DefaultCasualCostumeId                    = (IdolCostumeId)GetInt32(new IntPtr(p + 0x058)); // 0x58 DefaultCasualCostumeId      ( ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32 )
            value.SrcCostumeList                            = GetObjectList<ICostumeStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ICostumeStatus.FromPointer); // 0x78 SrcCostumeList              ( ModelClassListType IReadOnlyList`1<ICostumeStatus> IReadOnlyList`1<ICostumeStatus> List<ICostumeStatus> Pointer )
            value.SrcHairstyleList                          = GetObjectList<IHairstyleStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IHairstyleStatus.FromPointer); // 0x80 SrcHairstyleList            ( ModelClassListType IReadOnlyList`1<IHairstyleStatus> IReadOnlyList`1<IHairstyleStatus> List<IHairstyleStatus> Pointer )
            value.SrcAccessoryList                          = GetObjectList<IAccessoryStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IAccessoryStatus.FromPointer); // 0x88 SrcAccessoryList            ( ModelClassListType IReadOnlyList`1<IAccessoryStatus> IReadOnlyList`1<IAccessoryStatus> List<IAccessoryStatus> Pointer )
            value.ArcCostumeSetList                         = GetObjectList<ICostumeSetStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.ICostumeSetStatus.FromPointer); // 0x90 ArcCostumeSetList           ( ModelClassListType IReadOnlyList`1<ICostumeSetStatus> IReadOnlyList`1<ICostumeSetStatus> List<ICostumeSetStatus> Pointer )
            value.DressCostumeSetDataList                   = GetObjectList<CostumeSetListViewCellData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CostumeSetListViewCellData.FromPointer); // 0xE0 DressCostumeSetDataList     ( ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer )
            value.CasualCostumeSetDataList                  = GetObjectList<CostumeSetListViewCellData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CostumeSetListViewCellData.FromPointer); // 0xF0 CasualCostumeSetDataList    ( ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer )
            value.UseOtherCharacterCostume                  = GetBool(new IntPtr(p + 0x108)); // 0x108 UseOtherCharacterCostume    ( ModelPrimitiveType bool bool bool Bool )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x10C)); // 0x10C CostumeType                 ( ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.CostumeTypeInCostumeChangeView            = (CostumeType)GetInt32(new IntPtr(p + 0x110)); // 0x110 CostumeTypeInCostumeChangeView ( ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.IsTryOnMode                               = GetBool(new IntPtr(p + 0x114)); // 0x114 IsTryOnMode                 ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentSelectedTab                        = (CostumeCategory)GetInt32(new IntPtr(p + 0x118)); // 0x118 CurrentSelectedTab          ( ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )

            return value;
        }
    }
}
