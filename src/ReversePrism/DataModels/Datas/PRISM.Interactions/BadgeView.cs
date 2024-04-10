using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CircleObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 CircleBlueObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 AmountObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 AmountText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class BadgeView : DataModel
    {
        public GameObject?                              CircleObject                            { get; set; }
        public GameObject?                              CircleBlueObject                        { get; set; }
        public GameObject?                              AmountObject                            { get; set; }
        public UITextMeshProUGUI?                       AmountText                              { get; set; }

        public static BadgeView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BadgeView() { Pointer= p0 };

            value.CircleObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F63708 0x20 CircleObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CircleBlueObject                          = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F63728 0x28 CircleBlueObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AmountObject                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0245A4F63748 0x30 AmountObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AmountText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0245A4F63768 0x38 AmountText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
