using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rand                                     000186609880 ModelClassType Random Random Random Pointer
    // 018 srcDressUpRoomCostumeDictionary          Dictionary`2<int, ValueTuple`2<IDressUpRoomCostumeStatus, IDressUpRoomCostumeStatus>> IL2CPP_TYPE_GENERICINST
    // 020 Idol                                     000186700EF0 ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer
    // 028 CostumeChangeViewIdol                    000186700EF0 ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer
    // 030 DressCostume                             00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 038 DefaultDressCostumeId                    0001866ADC00 ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32
    // 050 CasualCostume                            00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 058 DefaultCasualCostumeId                   0001866ADC00 ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32
    // 070 saveData                                 SavableJsonObject`1<DressUpRoomSaveData> IL2CPP_TYPE_GENERICINST
    // 078 SrcCostumeList                           000185CF4218 ModelClassListType IReadOnlyList`1<ICostumeStatus> IReadOnlyList`1<ICostumeStatus> List<ICostumeStatus> Pointer
    // 080 SrcHairstyleList                         000185CFBF78 ModelClassListType IReadOnlyList`1<IHairstyleStatus> IReadOnlyList`1<IHairstyleStatus> List<IHairstyleStatus> Pointer
    // 088 SrcAccessoryList                         000185CF0F88 ModelClassListType IReadOnlyList`1<IAccessoryStatus> IReadOnlyList`1<IAccessoryStatus> List<IAccessoryStatus> Pointer
    // 090 ArcCostumeSetList                        000185CF3D68 ModelClassListType IReadOnlyList`1<ICostumeSetStatus> IReadOnlyList`1<ICostumeSetStatus> List<ICostumeSetStatus> Pointer
    // 098 dCostumeSetDic                           Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 0A0 dDressDic                                Dictionary`2<int, ICostumeStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 dHairstyleDic                            Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 0B0 dAccessoryDic                            Dictionary`2<int, IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 0B8 cCostumeSetDic                           Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 0C0 cDressDic                                Dictionary`2<int, ICostumeStatus> IL2CPP_TYPE_GENERICINST
    // 0C8 cHairstyleDic                            Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 0D0 cAccessoryDic                            Dictionary`2<int, IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 0D8 selectedIndexDic                         Dictionary`2<CostumeType, Dictionary`2<CostumeCategory, int>> IL2CPP_TYPE_GENERICINST
    // 0E0 DressCostumeSetDataList                  000185CD48E8 ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer
    // 0E8 dressCostumeListDic                      Dictionary`2<CostumeCategory, IList`1<CostumeGridViewCellData>> IL2CPP_TYPE_GENERICINST
    // 0F0 CasualCostumeSetDataList                 000185CD48E8 ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer
    // 0F8 casualCostumeListDic                     Dictionary`2<CostumeCategory, IList`1<CostumeGridViewCellData>> IL2CPP_TYPE_GENERICINST
    // 100 voiceResources                           Dictionary`2<int, List`1<MstVoiceResource>> IL2CPP_TYPE_GENERICINST
    // 108 UseOtherCharacterCostume                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 10C CostumeType                              0001865EEA20 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 110 CostumeTypeInCostumeChangeView           0001865EEA20 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 114 IsTryOnMode                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 118 CurrentSelectedTab                       0001866293F0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
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

            value.Rand                                      = GetObject<Random>(new IntPtr(p + 0x010), ReversePrism.DataModels.Random.FromPointer); // 024666289D90 0x10 Rand                        ( 000186609880 ModelClassType Random Random Random Pointer )
            value.Idol                                      = GetObject<DressUpRoomIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.DressUpRoomIdol.FromPointer); // 024666289DD0 0x20 Idol                        ( 000186700EF0 ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer )
            value.CostumeChangeViewIdol                     = GetObject<DressUpRoomIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomIdol.FromPointer); // 024666289DF0 0x28 CostumeChangeViewIdol       ( 000186700EF0 ModelClassType DressUpRoomIdol DressUpRoomIdol DressUpRoomIdol Pointer )
            value.DressCostume                              = GetObject<CharacterCostume>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterCostume.FromPointer); // 024666289E10 0x30 DressCostume                ( 00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.DefaultDressCostumeId                     = (IdolCostumeId)GetInt32(new IntPtr(p + 0x038)); // 024666289E30 0x38 DefaultDressCostumeId       ( 0001866ADC00 ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32 )
            value.CasualCostume                             = GetObject<CharacterCostume>(new IntPtr(p + 0x050), ReversePrism.DataModels.CharacterCostume.FromPointer); // 024666289E50 0x50 CasualCostume               ( 00018659D660 ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.DefaultCasualCostumeId                    = (IdolCostumeId)GetInt32(new IntPtr(p + 0x058)); // 024666289E70 0x58 DefaultCasualCostumeId      ( 0001866ADC00 ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32 )
            value.SrcCostumeList                            = GetObjectList<ICostumeStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.ICostumeStatus.FromPointer); // 024666289EB0 0x78 SrcCostumeList              ( 000185CF4218 ModelClassListType IReadOnlyList`1<ICostumeStatus> IReadOnlyList`1<ICostumeStatus> List<ICostumeStatus> Pointer )
            value.SrcHairstyleList                          = GetObjectList<IHairstyleStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IHairstyleStatus.FromPointer); // 024666289ED0 0x80 SrcHairstyleList            ( 000185CFBF78 ModelClassListType IReadOnlyList`1<IHairstyleStatus> IReadOnlyList`1<IHairstyleStatus> List<IHairstyleStatus> Pointer )
            value.SrcAccessoryList                          = GetObjectList<IAccessoryStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IAccessoryStatus.FromPointer); // 024666289EF0 0x88 SrcAccessoryList            ( 000185CF0F88 ModelClassListType IReadOnlyList`1<IAccessoryStatus> IReadOnlyList`1<IAccessoryStatus> List<IAccessoryStatus> Pointer )
            value.ArcCostumeSetList                         = GetObjectList<ICostumeSetStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.ICostumeSetStatus.FromPointer); // 024666289F10 0x90 ArcCostumeSetList           ( 000185CF3D68 ModelClassListType IReadOnlyList`1<ICostumeSetStatus> IReadOnlyList`1<ICostumeSetStatus> List<ICostumeSetStatus> Pointer )
            value.DressCostumeSetDataList                   = GetObjectList<CostumeSetListViewCellData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CostumeSetListViewCellData.FromPointer); // 02466628A050 0xE0 DressCostumeSetDataList     ( 000185CD48E8 ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer )
            value.CasualCostumeSetDataList                  = GetObjectList<CostumeSetListViewCellData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CostumeSetListViewCellData.FromPointer); // 02466628A090 0xF0 CasualCostumeSetDataList    ( 000185CD48E8 ModelClassListType List`1<CostumeSetListViewCellData> List`1<CostumeSetListViewCellData> List<CostumeSetListViewCellData> Pointer )
            value.UseOtherCharacterCostume                  = GetBool(new IntPtr(p + 0x108)); // 02466628A0F0 0x108 UseOtherCharacterCostume    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x10C)); // 02466628A110 0x10C CostumeType                 ( 0001865EEA20 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.CostumeTypeInCostumeChangeView            = (CostumeType)GetInt32(new IntPtr(p + 0x110)); // 02466628A130 0x110 CostumeTypeInCostumeChangeView ( 0001865EEA20 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.IsTryOnMode                               = GetBool(new IntPtr(p + 0x114)); // 02466628A150 0x114 IsTryOnMode                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentSelectedTab                        = (CostumeCategory)GetInt32(new IntPtr(p + 0x118)); // 02466628A170 0x118 CurrentSelectedTab          ( 0001866293F0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )

            return value;
        }
    }
}
