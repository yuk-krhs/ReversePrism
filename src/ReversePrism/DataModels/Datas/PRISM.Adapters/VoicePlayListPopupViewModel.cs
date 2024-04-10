using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 0001866CA0D0 ModelEnumType IdolVoicePlayListCategory IdolVoicePlayListCategory IdolVoicePlayListCategory Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstProduceIdolId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 020 VoiceList                                000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
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

            value.Category                                  = (IdolVoicePlayListCategory)GetInt32(new IntPtr(p + 0x010)); // 024665EDCC80 0x10 Category                    ( 0001866CA0D0 ModelEnumType IdolVoicePlayListCategory IdolVoicePlayListCategory IdolVoicePlayListCategory Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 024665EDCCA0 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 024665EDCCC0 0x18 MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x01C)); // 024665EDCCE0 0x1C MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.VoiceList                                 = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 024665EDCD00 0x20 VoiceList                   ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )

            return value;
        }
    }
}
