using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1E0 NormalObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 1E8 PositiveObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 1F0 WarningObject                            ModelClassType GameObject GameObject GameObject Pointer
    // 1F8 PurchaseObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 200 BlackCover                               ModelClassType GameObject GameObject GameObject Pointer
    public partial class PopupButton : DataModel
    {
        public GameObject?                              NormalObject                            { get; set; }
        public GameObject?                              PositiveObject                          { get; set; }
        public GameObject?                              WarningObject                           { get; set; }
        public GameObject?                              PurchaseObject                          { get; set; }
        public GameObject?                              BlackCover                              { get; set; }

        public static PopupButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PopupButton() { Pointer= p0 };

            value.NormalObject                              = GetObject<GameObject>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.GameObject.FromPointer); // 0x1E0 NormalObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PositiveObject                            = GetObject<GameObject>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.GameObject.FromPointer); // 0x1E8 PositiveObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.WarningObject                             = GetObject<GameObject>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.GameObject.FromPointer); // 0x1F0 WarningObject               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PurchaseObject                            = GetObject<GameObject>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.GameObject.FromPointer); // 0x1F8 PurchaseObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BlackCover                                = GetObject<GameObject>(new IntPtr(p + 0x200), ReversePrism.DataModels.GameObject.FromPointer); // 0x200 BlackCover                  ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
