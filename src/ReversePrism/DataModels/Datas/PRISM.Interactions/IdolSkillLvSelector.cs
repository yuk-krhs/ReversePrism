using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtBeforeLv                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtAfterLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtMaxLv                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 GoBeforeAfter                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 GoMax                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 BtnUp                                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnDown                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 onUp                                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDown                                   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillLvSelector
    {
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public UITextMeshProUGUI?                       TxtMaxLv                                { get; set; }
        public GameObject?                              GoBeforeAfter                           { get; set; }
        public GameObject?                              GoMax                                   { get; set; }
        public UIButton?                                BtnUp                                   { get; set; }
        public UIButton?                                BtnDown                                 { get; set; }

        public static IdolSkillLvSelector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvSelector();

            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA345DF0 0x20 TxtBeforeLv                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA345E10 0x28 TxtAfterLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtMaxLv                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA345E30 0x30 TxtMaxLv                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoBeforeAfter                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA345E50 0x38 GoBeforeAfter               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GoMax                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA345E70 0x40 GoMax                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA345E90 0x48 BtnUp                       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA345EB0 0x50 BtnDown                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
