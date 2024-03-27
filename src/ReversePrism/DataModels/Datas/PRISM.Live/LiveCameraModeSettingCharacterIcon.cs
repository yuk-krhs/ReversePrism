using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 028 IconView                                 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 030 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 EmptyViewPositionMarks                   000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 FocusMark                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 DuplicatedMark                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 SelectedMark                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 Button                                   000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class LiveCameraModeSettingCharacterIcon
    {
        public UIGrayOutController?                     GrayOutController                       { get; set; }
        public PFIdolIconRectView?                      IconView                                { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public List<GameObject>?                        EmptyViewPositionMarks                  { get; set; }
        public GameObject?                              FocusMark                               { get; set; }
        public GameObject?                              DuplicatedMark                          { get; set; }
        public GameObject?                              SelectedMark                            { get; set; }
        public ButtonBase?                              Button                                  { get; set; }

        public static LiveCameraModeSettingCharacterIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCameraModeSettingCharacterIcon();

            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270D50D6290 0x20 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0270D50D62B0 0x28 IconView                    ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D62D0 0x30 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewPositionMarks                    = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D62F0 0x38 EmptyViewPositionMarks      ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FocusMark                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D6310 0x40 FocusMark                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DuplicatedMark                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D6330 0x48 DuplicatedMark              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedMark                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D50D6350 0x50 SelectedMark                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D50D6370 0x58 Button                      ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
