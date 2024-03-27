using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultPanelTextSettings               PanelTextSettings IL2CPP_TYPE_CLASS
    // 008 EditorGUIUtilityLoad                     Func`2<string, Object> IL2CPP_TYPE_GENERICINST
    // 010 GetCurrentLanguage                       Func`1<SystemLanguage> IL2CPP_TYPE_GENERICINST
    // 018 S_DefaultEditorPanelTextSettingPath      000186673B80 ModelPrimitiveType string string string String
    public partial class PanelTextSettings
    {
        public string                                   S_DefaultEditorPanelTextSettingPath     { get; set; }

        public static PanelTextSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PanelTextSettings();

            value.S_DefaultEditorPanelTextSettingPath       = GetString(new IntPtr(p + 0x018)); // 027006845338 0x18 S_DefaultEditorPanelTextSettingPath ( 000186673B80 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
