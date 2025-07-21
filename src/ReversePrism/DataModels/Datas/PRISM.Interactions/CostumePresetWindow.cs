using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 List                                     ModelClassType CostumePresetListView CostumePresetListView CostumePresetListView Pointer
    // 050 HideButton                               ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 OnApplyPreset                            Action`1<ICostumePresetStatus> IL2CPP_TYPE_GENERICINST
    public partial class CostumePresetWindow : DataModel
    {
        public CostumePresetListView?                   List                                    { get; set; }
        public ButtonBase?                              HideButton                              { get; set; }

        public static CostumePresetWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePresetWindow() { Pointer= p0 };

            value.List                                      = GetObject<CostumePresetListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumePresetListView.FromPointer); // 0x48 List                        ( ModelClassType CostumePresetListView CostumePresetListView CostumePresetListView Pointer )
            value.HideButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x50 HideButton                  ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
