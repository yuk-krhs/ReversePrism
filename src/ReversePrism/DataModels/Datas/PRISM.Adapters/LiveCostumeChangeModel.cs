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
    // 028 SaveData                                 ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer
    // 030 InitialCostumeId                         ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32
    // 048 DefaultCostumeSet                        ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 050 costumeSetDic                            Dictionary`2<int, ICostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 058 dressDic                                 Dictionary`2<int, ICostumeStatus> IL2CPP_TYPE_GENERICINST
    // 060 hairstyleDic                             Dictionary`2<int, IHairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 068 accessoryDic                             Dictionary`2<int, IAccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 070 CostumeType                              ModelEnumType CostumeType CostumeType CostumeType Int32
    // 078 Idol                                     ModelClassType IIdol IIdol IIdol Pointer
    // 080 CurrentSelectedTab                       ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    // 084 IsTryOnMode                              ModelPrimitiveType bool bool bool Bool
    public partial class LiveCostumeChangeModel : DataModel
    {
        public LiveCostumeChangeSaveData?               SaveData                                { get; set; }
        public IdolCostumeId                            InitialCostumeId                        { get; set; }
        public MstCostumeSet?                           DefaultCostumeSet                       { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public IIdol?                                   Idol                                    { get; set; }
        public CostumeCategory                          CurrentSelectedTab                      { get; set; }
        public bool                                     IsTryOnMode                             { get; set; }

        public static LiveCostumeChangeModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeModel() { Pointer= p0 };

            value.SaveData                                  = GetObject<LiveCostumeChangeSaveData>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveCostumeChangeSaveData.FromPointer); // 0x28 SaveData                    ( ModelClassType LiveCostumeChangeSaveData LiveCostumeChangeSaveData LiveCostumeChangeSaveData Pointer )
            value.InitialCostumeId                          = (IdolCostumeId)GetInt32(new IntPtr(p + 0x030)); // 0x30 InitialCostumeId            ( ModelEnumType IdolCostumeId IdolCostumeId IdolCostumeId Int32 )
            value.DefaultCostumeSet                         = GetObject<MstCostumeSet>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0x48 DefaultCostumeSet           ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x070)); // 0x70 CostumeType                 ( ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.Idol                                      = GetObject<IIdol>(new IntPtr(p + 0x078), ReversePrism.DataModels.IIdol.FromPointer); // 0x78 Idol                        ( ModelClassType IIdol IIdol IIdol Pointer )
            value.CurrentSelectedTab                        = (CostumeCategory)GetInt32(new IntPtr(p + 0x080)); // 0x80 CurrentSelectedTab          ( ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.IsTryOnMode                               = GetBool(new IntPtr(p + 0x084)); // 0x84 IsTryOnMode                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
