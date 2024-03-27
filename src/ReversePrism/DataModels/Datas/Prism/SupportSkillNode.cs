using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Skill                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 Blank                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 Get                                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 Icon                                     0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 Name                                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 Description                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 BaseBtn                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 SelectFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 AcquiredObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class SupportSkillNode
    {
        public GameObject?                              Skill                                   { get; set; }
        public GameObject?                              Blank                                   { get; set; }
        public GameObject?                              Get                                     { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public UIRawImage?                              Icon                                    { get; set; }
        public UITextMeshProUGUI?                       Name                                    { get; set; }
        public UITextMeshProUGUI?                       Description                             { get; set; }
        public GameObject?                              BaseBtn                                 { get; set; }
        public GameObject?                              SelectFrame                             { get; set; }
        public GameObject?                              AcquiredObject                          { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static SupportSkillNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillNode();

            value.Skill                                     = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D1A380 0x20 Skill                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Blank                                     = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D1A3A0 0x28 Blank                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Get                                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D1A3C0 0x30 Get                         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270D4D1A3E0 0x38 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Icon                                      = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D4D1A400 0x40 Icon                        ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.Name                                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4D1A420 0x48 Name                        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Description                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4D1A440 0x50 Description                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseBtn                                   = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D1A460 0x58 BaseBtn                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D1A480 0x60 SelectFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AcquiredObject                            = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D1A4A0 0x68 AcquiredObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x070)); // 0270D4D1A4C0 0x70 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
