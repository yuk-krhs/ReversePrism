using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentTabType                           000186536D10 ModelEnumType VoicePlayTab VoicePlayTab VoicePlayTab Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 HomeList                                 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 020 ProduceList                              000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 028 LiveList                                 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 030 OtherList                                000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    public partial class VoicePlayTabListPopupViewModel : DataModel
    {
        public VoicePlayTab                             CurrentTabType                          { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public List<ICategoryElementGridCellViewModel>? HomeList                                { get; set; }
        public List<ICategoryElementGridCellViewModel>? ProduceList                             { get; set; }
        public List<ICategoryElementGridCellViewModel>? LiveList                                { get; set; }
        public List<ICategoryElementGridCellViewModel>? OtherList                               { get; set; }

        public static VoicePlayTabListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePlayTabListPopupViewModel() { Pointer= p0 };

            value.CurrentTabType                            = (VoicePlayTab)GetInt32(new IntPtr(p + 0x010)); // 024665EE4518 0x10 CurrentTabType              ( 000186536D10 ModelEnumType VoicePlayTab VoicePlayTab VoicePlayTab Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 024665EE4538 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HomeList                                  = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 024665EE4558 0x18 HomeList                    ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.ProduceList                               = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 024665EE4578 0x20 ProduceList                 ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.LiveList                                  = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 024665EE4598 0x28 LiveList                    ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.OtherList                                 = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 024665EE45B8 0x30 OtherList                   ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )

            return value;
        }
    }
}
