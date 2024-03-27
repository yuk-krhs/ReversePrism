using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MonthDropdown                            00018660B310 ModelClassType TMP_Dropdown TMP_Dropdown TMP_Dropdown Pointer
    // 028 DayDropdown                              00018660B310 ModelClassType TMP_Dropdown TMP_Dropdown TMP_Dropdown Pointer
    // 030 BirthdayPublicToggle                     000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 038 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onChangeMonth                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 onChangeDay                              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onChangeBirthdayPublic                   Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 060 ViewModel                                0001865ACE20 ModelClassType ProfileEditBirthdayViewModel ProfileEditBirthdayViewModel ProfileEditBirthdayViewModel Pointer
    // 068 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileEditBirthdayPopupView
    {
        public TMP_Dropdown?                            MonthDropdown                           { get; set; }
        public TMP_Dropdown?                            DayDropdown                             { get; set; }
        public ToggleButton?                            BirthdayPublicToggle                    { get; set; }
        public ProfileEditBirthdayViewModel?            ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileEditBirthdayPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileEditBirthdayPopupView();

            value.MonthDropdown                             = GetObject<TMP_Dropdown>(new IntPtr(p + 0x020), ReversePrism.DataModels.TMP_Dropdown.FromPointer); // 0270DB703860 0x20 MonthDropdown               ( 00018660B310 ModelClassType TMP_Dropdown TMP_Dropdown TMP_Dropdown Pointer )
            value.DayDropdown                               = GetObject<TMP_Dropdown>(new IntPtr(p + 0x028), ReversePrism.DataModels.TMP_Dropdown.FromPointer); // 0270DB703880 0x28 DayDropdown                 ( 00018660B310 ModelClassType TMP_Dropdown TMP_Dropdown TMP_Dropdown Pointer )
            value.BirthdayPublicToggle                      = GetObject<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DB7038A0 0x30 BirthdayPublicToggle        ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ViewModel                                 = GetObject<ProfileEditBirthdayViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ProfileEditBirthdayViewModel.FromPointer); // 0270DB703960 0x60 ViewModel                   ( 0001865ACE20 ModelClassType ProfileEditBirthdayViewModel ProfileEditBirthdayViewModel ProfileEditBirthdayViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB703980 0x68 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
