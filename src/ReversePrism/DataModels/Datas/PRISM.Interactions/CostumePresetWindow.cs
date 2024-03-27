using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 List                                     00018662FBE0 ModelClassType CostumePresetListView CostumePresetListView CostumePresetListView Pointer
    // 050 HideButton                               000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 OnApplyPreset                            Action`1<ICostumePresetStatus> IL2CPP_TYPE_GENERICINST
    public partial class CostumePresetWindow
    {
        public CostumePresetListView?                   List                                    { get; set; }
        public ButtonBase?                              HideButton                              { get; set; }

        public static CostumePresetWindow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePresetWindow();

            value.List                                      = GetObject<CostumePresetListView>(new IntPtr(p + 0x048), ReversePrism.DataModels.CostumePresetListView.FromPointer); // 0270DBC09158 0x48 List                        ( 00018662FBE0 ModelClassType CostumePresetListView CostumePresetListView CostumePresetListView Pointer )
            value.HideButton                                = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270DBC09178 0x50 HideButton                  ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
