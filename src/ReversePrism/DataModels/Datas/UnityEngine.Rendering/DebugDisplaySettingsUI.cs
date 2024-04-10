using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_DisposablePanels                       IEnumerable`1<IDebugDisplaySettingsPanelDisposable> IL2CPP_TYPE_GENERICINST
    // 018 M_Settings                               00018674C0C0 ModelClassType IDebugDisplaySettings IDebugDisplaySettings IDebugDisplaySettings Pointer
    public partial class DebugDisplaySettingsUI : DataModel
    {
        public IDebugDisplaySettings?                   M_Settings                              { get; set; }

        public static DebugDisplaySettingsUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplaySettingsUI() { Pointer= p0 };

            value.M_Settings                                = GetObject<IDebugDisplaySettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDebugDisplaySettings.FromPointer); // 0246691B8A08 0x18 M_Settings                  ( 00018674C0C0 ModelClassType IDebugDisplaySettings IDebugDisplaySettings IDebugDisplaySettings Pointer )

            return value;
        }
    }
}
