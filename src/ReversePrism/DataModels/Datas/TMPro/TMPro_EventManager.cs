using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 COMPUTE_DT_EVENT                         FastAction`2<<object>, Compute_DT_EventArgs> IL2CPP_TYPE_GENERICINST
    // 008 MATERIAL_PROPERTY_EVENT                  FastAction`2<bool, Material> IL2CPP_TYPE_GENERICINST
    // 010 FONT_PROPERTY_EVENT                      FastAction`2<bool, Object> IL2CPP_TYPE_GENERICINST
    // 018 SPRITE_ASSET_PROPERTY_EVENT              FastAction`2<bool, Object> IL2CPP_TYPE_GENERICINST
    // 020 TEXTMESHPRO_PROPERTY_EVENT               FastAction`2<bool, Object> IL2CPP_TYPE_GENERICINST
    // 028 DRAG_AND_DROP_MATERIAL_EVENT             FastAction`3<GameObject, Material, Material> IL2CPP_TYPE_GENERICINST
    // 030 TEXT_STYLE_PROPERTY_EVENT                FastAction`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 COLOR_GRADIENT_PROPERTY_EVENT            FastAction`1<Object> IL2CPP_TYPE_GENERICINST
    // 040 TMP_SETTINGS_PROPERTY_EVENT              000186556EB0 ModelClassType FastAction FastAction FastAction Pointer
    // 048 RESOURCE_LOAD_EVENT                      000186556EB0 ModelClassType FastAction FastAction FastAction Pointer
    // 050 TEXTMESHPRO_UGUI_PROPERTY_EVENT          FastAction`2<bool, Object> IL2CPP_TYPE_GENERICINST
    // 058 TEXT_CHANGED_EVENT                       FastAction`1<Object> IL2CPP_TYPE_GENERICINST
    public partial class TMPro_EventManager : DataModel
    {
        public FastAction?                              TMP_SETTINGS_PROPERTY_EVENT             { get; set; }
        public FastAction?                              RESOURCE_LOAD_EVENT                     { get; set; }

        public static TMPro_EventManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMPro_EventManager() { Pointer= p0 };

            value.TMP_SETTINGS_PROPERTY_EVENT               = GetObject<FastAction>(new IntPtr(p + 0x040), ReversePrism.DataModels.FastAction.FromPointer); // 0245A41A5FF0 0x40 TMP_SETTINGS_PROPERTY_EVENT ( 000186556EB0 ModelClassType FastAction FastAction FastAction Pointer )
            value.RESOURCE_LOAD_EVENT                       = GetObject<FastAction>(new IntPtr(p + 0x048), ReversePrism.DataModels.FastAction.FromPointer); // 0245A41A6010 0x48 RESOURCE_LOAD_EVENT         ( 000186556EB0 ModelClassType FastAction FastAction FastAction Pointer )

            return value;
        }
    }
}
