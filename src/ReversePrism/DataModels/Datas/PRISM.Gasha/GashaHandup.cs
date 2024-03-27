using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NotificationRarity                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 NotificationNum                          000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 030 TapEffectSR                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 TapEffectSSR                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class GashaHandup
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
            var value   = new GashaHandup();

            value.NotificationRarity                        = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC2FE0 0x20 NotificationRarity          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.NotificationNum                           = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D4DC3000 0x28 NotificationNum             ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.TapEffectSR                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC3020 0x30 TapEffectSR                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TapEffectSSR                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4DC3040 0x38 TapEffectSSR                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
