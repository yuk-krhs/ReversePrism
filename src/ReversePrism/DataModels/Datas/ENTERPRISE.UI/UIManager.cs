using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DisplayGroup                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 TutorialGroup                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 PauseReturnBackDisableTween              0001866BEFF0 ModelClassType Tween Tween Tween Pointer
    // 038 UnlockClickEvent                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 UICamera                                 0001865A2380 ModelClassType Camera Camera Camera Pointer
    // 048 ClickedButton                            00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer
    public partial class UIManager
    {
        public GameObject?                              DisplayGroup                            { get; set; }
        public Transform?                               TutorialGroup                           { get; set; }
        public Tween?                                   PauseReturnBackDisableTween             { get; set; }
        public bool                                     UnlockClickEvent                        { get; set; }
        public Camera?                                  UICamera                                { get; set; }
        public MonoBehaviour?                           ClickedButton                           { get; set; }

        public static UIManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIManager();

            value.DisplayGroup                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D0A63EA8 0x20 DisplayGroup                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TutorialGroup                             = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270D0A63EC8 0x28 TutorialGroup               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.PauseReturnBackDisableTween               = GetObject<Tween>(new IntPtr(p + 0x030), ReversePrism.DataModels.Tween.FromPointer); // 0270D0A63EE8 0x30 PauseReturnBackDisableTween ( 0001866BEFF0 ModelClassType Tween Tween Tween Pointer )
            value.UnlockClickEvent                          = GetBool(new IntPtr(p + 0x038)); // 0270D0A63F08 0x38 UnlockClickEvent            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UICamera                                  = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 0270D0A63F28 0x40 UICamera                    ( 0001865A2380 ModelClassType Camera Camera Camera Pointer )
            value.ClickedButton                             = GetObject<MonoBehaviour>(new IntPtr(p + 0x048), ReversePrism.DataModels.MonoBehaviour.FromPointer); // 0270D0A63F48 0x48 ClickedButton               ( 00018663D7E0 ModelClassType MonoBehaviour MonoBehaviour MonoBehaviour Pointer )

            return value;
        }
    }
}
