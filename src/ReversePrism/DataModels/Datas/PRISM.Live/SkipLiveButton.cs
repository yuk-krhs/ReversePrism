using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 StatusObjects                            000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 EnabledGrayOutController                 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 038 EnabledRemainingCountText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 DisabledRemainingCountText               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CurrentStatus                            00018653B930 ModelEnumType Status Status Status Int32
    public partial class SkipLiveButton
    {
        public ButtonBase?                              Button                                  { get; set; }
        public List<GameObject>?                        StatusObjects                           { get; set; }
        public UIGrayOutController?                     EnabledGrayOutController                { get; set; }
        public UITextMeshProUGUI?                       EnabledRemainingCountText               { get; set; }
        public UITextMeshProUGUI?                       DisabledRemainingCountText              { get; set; }
        public Status                                   CurrentStatus                           { get; set; }

        public static SkipLiveButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkipLiveButton();

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D52A6250 0x20 Button                      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StatusObjects                             = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D52A6270 0x28 StatusObjects               ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EnabledGrayOutController                  = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D52A6290 0x30 EnabledGrayOutController    ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.EnabledRemainingCountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52A62B0 0x38 EnabledRemainingCountText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DisabledRemainingCountText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D52A62D0 0x40 DisabledRemainingCountText  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentStatus                             = (Status)GetInt32(new IntPtr(p + 0x048)); // 0270D52A62F0 0x48 CurrentStatus               ( 00018653B930 ModelEnumType Status Status Status Int32 )

            return value;
        }
    }
}
