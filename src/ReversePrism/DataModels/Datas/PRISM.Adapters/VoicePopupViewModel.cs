using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentTabType                           000186533F70 ModelEnumType VoiceCategory VoiceCategory VoiceCategory Int32
    // 018 IdolList                                 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 020 PIdolList                                000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 028 SCharaList                               000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer
    // 030 IsActive                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class VoicePopupViewModel
    {
        public VoiceCategory                            CurrentTabType                          { get; set; }
        public List<ICategoryElementGridCellViewModel>? IdolList                                { get; set; }
        public List<ICategoryElementGridCellViewModel>? PIdolList                               { get; set; }
        public List<ICategoryElementGridCellViewModel>? SCharaList                              { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static VoicePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoicePopupViewModel();

            value.CurrentTabType                            = (VoiceCategory)GetInt32(new IntPtr(p + 0x010)); // 0270D5E73D88 0x10 CurrentTabType              ( 000186533F70 ModelEnumType VoiceCategory VoiceCategory VoiceCategory Int32 )
            value.IdolList                                  = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0270D5E73DA8 0x18 IdolList                    ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.PIdolList                                 = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0270D5E73DC8 0x20 PIdolList                   ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.SCharaList                                = GetObjectList<ICategoryElementGridCellViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICategoryElementGridCellViewModel.FromPointer); // 0270D5E73DE8 0x28 SCharaList                  ( 000185CE1848 ModelClassListType List`1<ICategoryElementGridCellViewModel> List`1<ICategoryElementGridCellViewModel> List<ICategoryElementGridCellViewModel> Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x030)); // 0270D5E73E08 0x30 IsActive                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
