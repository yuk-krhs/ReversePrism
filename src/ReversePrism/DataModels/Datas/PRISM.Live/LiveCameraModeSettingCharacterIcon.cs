using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 028 IconView                                 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 030 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 038 EmptyViewPositionMarks                   ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 FocusMark                                ModelClassType GameObject GameObject GameObject Pointer
    // 048 DuplicatedMark                           ModelClassType GameObject GameObject GameObject Pointer
    // 050 SelectedMark                             ModelClassType GameObject GameObject GameObject Pointer
    // 058 Button                                   ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class LiveCameraModeSettingCharacterIcon : DataModel
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
            var value   = new LiveCameraModeSettingCharacterIcon() { Pointer= p0 };

            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x20 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.IconView                                  = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x28 IconView                    ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyViewPositionMarks                    = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EmptyViewPositionMarks      ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FocusMark                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 FocusMark                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DuplicatedMark                            = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 DuplicatedMark              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedMark                              = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 SelectedMark                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Button                                    = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 Button                      ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
