using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NotificationRarity                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 NotificationNum                          ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 TapEffectSR                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 TapEffectSSR                             ModelClassType GameObject GameObject GameObject Pointer
    public partial class GashaHandup : DataModel
    {
        public List<GameObject>?                        NotificationRarity                      { get; set; }
        public List<UITextMeshProUGUI>?                 NotificationNum                         { get; set; }
        public GameObject?                              TapEffectSR                             { get; set; }
        public GameObject?                              TapEffectSSR                            { get; set; }

        public static GashaHandup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaHandup() { Pointer= p0 };

            value.NotificationRarity                        = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 NotificationRarity          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.NotificationNum                           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 NotificationNum             ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TapEffectSR                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 TapEffectSR                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TapEffectSSR                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 TapEffectSSR                ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
