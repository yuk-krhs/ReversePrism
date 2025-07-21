using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 CostumeIcons                             ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer
    // 048 PresetNumber                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PresetName                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ApplyButton                              ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    // 060 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
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

            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0x40 CostumeIcons                ( ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.PresetNumber                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 PresetNumber                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PresetName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 PresetName                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ApplyButton                               = GetObject<ButtonToggleBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 0x58 ApplyButton                 ( ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x060)); // 0x60 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
