using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 EndPanelObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TimeText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class HomeLimitedSalePanelView
    {
        public GameObject?                              PanelObject                             { get; set; }
        public GameObject?                              EndPanelObject                          { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
        public Animator?                                Animator                                { get; set; }

        public static HomeLimitedSalePanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeLimitedSalePanelView();

            value.PanelObject                               = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 027004F483D0 0x20 PanelObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EndPanelObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 027004F483F0 0x28 EndPanelObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004F48410 0x30 TimeText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x038), ReversePrism.DataModels.Animator.FromPointer); // 027004F48430 0x38 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}
