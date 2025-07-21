using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Txt                                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtBefore                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 GoAfter                                  ModelClassType GameObject GameObject GameObject Pointer
    // 038 TxtAfter                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 GoNewDress                               ModelClassType GameObject GameObject GameObject Pointer
    // 048 GoNewDressOrange                         ModelClassType GameObject GameObject GameObject Pointer
    // 050 GoNewDressRainbow                        ModelClassType GameObject GameObject GameObject Pointer
    // 058 TxtNewDressBlack                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class OtherBonusContentView : DataModel
    {
        public UITextMeshProUGUI?                       Txt                                     { get; set; }
        public UITextMeshProUGUI?                       TxtBefore                               { get; set; }
        public GameObject?                              GoAfter                                 { get; set; }
        public UITextMeshProUGUI?                       TxtAfter                                { get; set; }
        public GameObject?                              GoNewDress                              { get; set; }
        public GameObject?                              GoNewDressOrange                        { get; set; }
        public GameObject?                              GoNewDressRainbow                       { get; set; }
        public UITextMeshProUGUI?                       TxtNewDressBlack                        { get; set; }

        public static OtherBonusContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusContentView() { Pointer= p0 };

            value.Txt                                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 Txt                         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBefore                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtBefore                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoAfter                                   = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoAfter                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtAfter                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtAfter                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoNewDress                                = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 GoNewDress                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoNewDressOrange                          = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GoNewDressOrange            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.GoNewDressRainbow                         = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 GoNewDressRainbow           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtNewDressBlack                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TxtNewDressBlack            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
