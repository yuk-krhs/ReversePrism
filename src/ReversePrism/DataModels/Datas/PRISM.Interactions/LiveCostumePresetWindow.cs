using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 List                                     ModelClassType LiveCostumePresetListView LiveCostumePresetListView LiveCostumePresetListView Pointer
    // 050 HideButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 OnApplyPreset                            Action`1<ICostumePresetStatus> IL2CPP_TYPE_GENERICINST
    // 060 OnEditEndDisposable                      ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class LiveCostumePresetWindow : DataModel
    {
        public LiveCostumePresetListView?               List                                    { get; set; }
        public ButtonBase?                              HideButton                              { get; set; }
        public IDisposable?                             OnEditEndDisposable                     { get; set; }

        public static LiveCostumePresetWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumePresetWindow() { Pointer= p0 };

            value.List                                      = GetObject<LiveCostumePresetListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveCostumePresetListView.FromPointer); // 0x48 List                        ( ModelClassType LiveCostumePresetListView LiveCostumePresetListView LiveCostumePresetListView Pointer )
            value.HideButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 HideButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OnEditEndDisposable                       = GetObject<IDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.IDisposable.FromPointer); // 0x60 OnEditEndDisposable         ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
