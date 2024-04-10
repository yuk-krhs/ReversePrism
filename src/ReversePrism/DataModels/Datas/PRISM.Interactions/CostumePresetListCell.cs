using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CostumeIcons                             000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 048 PresetNumber                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PresetName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ApplyButton                              000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    // 060 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class CostumePresetListCell : DataModel
    {
        public List<CostumeIcon>?                       CostumeIcons                            { get; set; }
        public UITextMeshProUGUI?                       PresetNumber                            { get; set; }
        public UITextMeshProUGUI?                       PresetName                              { get; set; }
        public ButtonToggleBase?                        ApplyButton                             { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static CostumePresetListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePresetListCell() { Pointer= p0 };

            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeIcon.FromPointer); // 02466BC8FD90 0x40 CostumeIcons                ( 000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.PresetNumber                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BC8FDB0 0x48 PresetNumber                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PresetName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BC8FDD0 0x50 PresetName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ApplyButton                               = GetObject<ButtonToggleBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 02466BC8FDF0 0x58 ApplyButton                 ( 000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 02466BC8FE10 0x60 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
