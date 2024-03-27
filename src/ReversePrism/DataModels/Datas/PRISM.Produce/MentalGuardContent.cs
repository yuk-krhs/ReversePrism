using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParentObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 GuardValueText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class MentalGuardContent
    {
        public GameObject?                              ParentObject                            { get; set; }
        public UITextMeshProUGUI?                       GuardValueText                          { get; set; }

        public static MentalGuardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MentalGuardContent();

            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5BAFF30 0x20 ParentObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.GuardValueText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5BAFF50 0x28 GuardValueText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
