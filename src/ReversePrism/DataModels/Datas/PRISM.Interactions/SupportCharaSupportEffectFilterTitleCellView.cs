using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CellHeight                               ModelPrimitiveType float float float Single
    // 040 CheckBtn                                 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 048 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class SupportCharaSupportEffectFilterTitleCellView : DataModel
    {
        public float                                    CellHeight                              { get; set; }
        public ToggleButton?                            CheckBtn                                { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static SupportCharaSupportEffectFilterTitleCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaSupportEffectFilterTitleCellView() { Pointer= p0 };

            value.CellHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 CellHeight                  ( ModelPrimitiveType float float float Single )
            value.CheckBtn                                  = GetObject<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x40 CheckBtn                    ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x48 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
