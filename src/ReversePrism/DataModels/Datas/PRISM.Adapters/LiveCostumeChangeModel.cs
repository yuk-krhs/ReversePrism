using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 selectedIndexDic                         Dictionary`2<CostumeCategory, int> IL2CPP_TYPE_GENERICINST
    // 018 costumeSetDataList                       IList`1<CostumeSetListViewCellData> IL2CPP_TYPE_GENERICINST
    // 020 costumeListDic                           Dictionary`2<CostumeCategory, IList`1<CostumeGridViewCellData>> IL2CPP_TYPE_GENERICINST
    // 028 SaveData                                 000186549350 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer
    // 030 InitialCostumeId                         0001866AE0B0 ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32
    // 048 DefaultCostumeIdArray                    000185B8A810 ModelEnumListType IdolCostumeId[] IdolCostumeId[] List<IdolCostumeId> Pointer
    // 050 costumeSetDic                            Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 058 dressDic                                 Dictionary`2<int, ICostumeStatus> IL2CPP_TYPE_GENERICINST
    // 060 hairstyleDic                             Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 068 accessoryDic                             Dictionary`2<int, IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 070 CostumeType                              0001865EEEA0 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 078 Idol                                     00018656E740 ModelClassType IIdol IIdol IIdol Pointer
    // 080 CurrentSelectedTab                       0001866293F0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    // 084 IsTryOnMode                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveCostumeChangeModel
    {
        public LiveCostumeChangeSaveData?               SaveData                                { get; set; }
        public IdolCostumeId                            InitialCostumeId                        { get; set; }
        public List<IdolCostumeId>?                     DefaultCostumeIdArray                   { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public IIdol?                                   Idol                                    { get; set; }
        public CostumeCategory                          CurrentSelectedTab                      { get; set; }
        public bool                                     IsTryOnMode                             { get; set; }

        public static LiveCostumeChangeModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeModel();

            value.SaveData                                  = GetObject<LiveCostumeChangeSaveData>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveCostumeChangeSaveData.FromPointer); // 0270D63EB9F8 0x28 SaveData                    ( 000186549350 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer )
            value.InitialCostumeId                          = (IdolCostumeId)GetInt32(new IntPtr(p + 0x030)); // 0270D63EBA18 0x30 InitialCostumeId            ( 0001866AE0B0 ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32 )
            value.DefaultCostumeIdArray                     = GetEnumList<IdolCostumeId>(new IntPtr(p + 0x048)); // 0270D63EBA38 0x48 DefaultCostumeIdArray       ( 000185B8A810 ModelEnumListType IdolCostumeId[] IdolCostumeId[] List<IdolCostumeId> Pointer )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x070)); // 0270D63EBAD8 0x70 CostumeType                 ( 0001865EEEA0 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.Idol                                      = GetObject<IIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.IIdol.FromPointer); // 0270D63EBAF8 0x78 Idol                        ( 00018656E740 ModelClassType IIdol IIdol IIdol Pointer )
            value.CurrentSelectedTab                        = (CostumeCategory)GetInt32(new IntPtr(p + 0x080)); // 0270D63EBB18 0x80 CurrentSelectedTab          ( 0001866293F0 ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.IsTryOnMode                               = GetBool(new IntPtr(p + 0x084)); // 0270D63EBB38 0x84 IsTryOnMode                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
