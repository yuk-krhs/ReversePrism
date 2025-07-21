using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 SelectedCharacterIdList                  IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 098 SCharaIconList                           ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0A0 SelectedIconList                         ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0A8 AllSCharaDataList                        ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 0B0 FriendModel                              ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer
    public partial class ProducePreparationSupportSelectPopupParam : DataModel
    {
        public List<SCharaIcon>?                        SCharaIconList                          { get; set; }
        public List<SCharaIcon>?                        SelectedIconList                        { get; set; }
        public List<ISupportCharacterStatus>?           AllSCharaDataList                       { get; set; }
        public FriendSupportModel?                      FriendModel                             { get; set; }

        public static ProducePreparationSupportSelectPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationSupportSelectPopupParam() { Pointer= p0 };

            value.SCharaIconList                            = GetObjectList<SCharaIcon>(new IntPtr(p + 0x098), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x98 SCharaIconList              ( ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.SelectedIconList                          = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xA0 SelectedIconList            ( ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.AllSCharaDataList                         = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0xA8 AllSCharaDataList           ( ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.FriendModel                               = GetObject<FriendSupportModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.FriendSupportModel.FromPointer); // 0xB0 FriendModel                 ( ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer )

            return value;
        }
    }
}
