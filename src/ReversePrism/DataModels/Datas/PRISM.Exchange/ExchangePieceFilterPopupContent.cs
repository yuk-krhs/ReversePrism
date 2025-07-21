using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 AllToggle                                ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 0A8 AllToggleText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 UnitToggleButtons                        ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer
    public partial class ExchangePieceFilterPopupContent : DataModel
    {
        public ToggleButton?                            AllToggle                               { get; set; }
        public UITextMeshProUGUI?                       AllToggleText                           { get; set; }
        public List<ToggleButton>?                      UnitToggleButtons                       { get; set; }

        public static ExchangePieceFilterPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePieceFilterPopupContent() { Pointer= p0 };

            value.AllToggle                                 = GetObject<ToggleButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleButton.FromPointer); // 0xA0 AllToggle                   ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AllToggleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 AllToggleText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitToggleButtons                         = GetObjectList<ToggleButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ToggleButton.FromPointer); // 0xB0 UnitToggleButtons           ( ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer )

            return value;
        }
    }
}
