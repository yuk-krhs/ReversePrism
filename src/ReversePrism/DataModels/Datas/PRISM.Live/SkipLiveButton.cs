using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 028 StatusObjects                            ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 030 EnabledGrayOutController                 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 038 EnabledRemainingCountText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 DisabledRemainingCountText               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 CurrentStatus                            ModelEnumType Status Status Status Int32
    public partial class SkipLiveButton : DataModel
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
            var value   = new SkipLiveButton() { Pointer= p0 };

            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x20 Button                      ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.StatusObjects                             = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 StatusObjects               ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.EnabledGrayOutController                  = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x30 EnabledGrayOutController    ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.EnabledRemainingCountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 EnabledRemainingCountText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DisabledRemainingCountText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 DisabledRemainingCountText  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CurrentStatus                             = (Status)GetInt32(new IntPtr(p + 0x048)); // 0x48 CurrentStatus               ( ModelEnumType Status Status Status Int32 )

            return value;
        }
    }
}
