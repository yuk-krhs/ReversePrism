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
    // 050 PresetNameInputField                     0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 058 TextCount                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 RenameButton                             000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    // 068 ApplyButton                              000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    // 070 SaveButton                               000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    // 078 DeleteButton                             000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer
    // 080 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 000 MaxTextCount                             int IL2CPP_TYPE_I4
    public partial class LiveCostumePresetListCell
    {
        public List<CostumeIcon>?                       CostumeIcons                            { get; set; }
        public UITextMeshProUGUI?                       PresetNumber                            { get; set; }
        public CommonInputFieldTMP?                     PresetNameInputField                    { get; set; }
        public UITextMeshProUGUI?                       TextCount                               { get; set; }
        public ButtonToggleBase?                        RenameButton                            { get; set; }
        public ButtonToggleBase?                        ApplyButton                             { get; set; }
        public ButtonToggleBase?                        SaveButton                              { get; set; }
        public ButtonToggleBase?                        DeleteButton                            { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static LiveCostumePresetListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumePresetListCell();

            value.CostumeIcons                              = GetObjectList<CostumeIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeIcon.FromPointer); // 0270DB3C28A8 0x40 CostumeIcons                ( 000185B77810 ModelClassListType CostumeIcon[] CostumeIcon[] List<CostumeIcon> Pointer )
            value.PresetNumber                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3C28C8 0x48 PresetNumber                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PresetNameInputField                      = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0270DB3C28E8 0x50 PresetNameInputField        ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.TextCount                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB3C2908 0x58 TextCount                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RenameButton                              = GetObject<ButtonToggleBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 0270DB3C2928 0x60 RenameButton                ( 000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )
            value.ApplyButton                               = GetObject<ButtonToggleBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 0270DB3C2948 0x68 ApplyButton                 ( 000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )
            value.SaveButton                                = GetObject<ButtonToggleBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 0270DB3C2968 0x70 SaveButton                  ( 000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )
            value.DeleteButton                              = GetObject<ButtonToggleBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.ButtonToggleBase.FromPointer); // 0270DB3C2988 0x78 DeleteButton                ( 000186518FC0 ModelClassType ButtonToggleBase ButtonToggleBase ButtonToggleBase Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x080)); // 0270DB3C29A8 0x80 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
