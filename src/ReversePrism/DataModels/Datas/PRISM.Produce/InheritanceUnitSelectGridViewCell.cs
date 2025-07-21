using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 FUnitIconView                            ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 038 NonSelectButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 040 NonSelectButtonSelectCursor              ModelClassType GameObject GameObject GameObject Pointer
    // 048 SelectedLabel                            ModelClassType GameObject GameObject GameObject Pointer
    // 050 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
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

            value.FUnitIconView                             = GetObject<FUnitIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x30 FUnitIconView               ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.NonSelectButton                           = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 NonSelectButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NonSelectButtonSelectCursor               = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 NonSelectButtonSelectCursor ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SelectedLabel                             = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 SelectedLabel               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
