using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 FUnitIconView                            00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 038 NonSelectButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 NonSelectButtonSelectCursor              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 SelectedLabel                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class InheritanceUnitSelectGridViewCell : DataModel
    {
        public FUnitIconView?                           FUnitIconView                           { get; set; }
        public UIButton?                                NonSelectButton                         { get; set; }
        public GameObject?                              NonSelectButtonSelectCursor             { get; set; }
        public GameObject?                              SelectedLabel                           { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static InheritanceUnitSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceUnitSelectGridViewCell() { Pointer= p0 };

            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIconView.FromPointer); // 024665A08BE8 0x30 FUnitIconView               ( 00018654D050 ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.NonSelectButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 024665A08C08 0x38 NonSelectButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NonSelectButtonSelectCursor               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 024665A08C28 0x40 NonSelectButtonSelectCursor ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedLabel                             = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024665A08C48 0x48 SelectedLabel               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 024665A08C68 0x50 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
