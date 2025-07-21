using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumType IdolVoicePlayListCategory IdolVoicePlayListCategory IdolVoicePlayListCategory Int32
    // 014 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 01C MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 020 VoiceList                                ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    public partial class VoicePlayListPopupViewModel : DataModel
    {
        public IdolVoicePlayListCategory                Category                                { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public List<ICategoryElementGridCellViewModel>? VoiceList                               { get; set; }

        public static VoicePlayListPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePlayListPopupViewModel() { Pointer= p0 };

            value.Category                                  = (IdolVoicePlayListCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelEnumType IdolVoicePlayListCategory IdolVoicePlayListCategory IdolVoicePlayListCategory Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.VoiceList                                 = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0x20 VoiceList                   ( ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )

            return value;
        }
    }
}
