using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActiveObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 InactiveObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 030 IsSwapLock                               ModelPrimitiveType bool bool bool Bool
    // 031 IsInActive                               ModelPrimitiveType bool bool bool Bool
    public partial class UIButtonGroupUnit : DataModel
    {
        public GameObject?                              ActiveObject                            { get; set; }
        public GameObject?                              InactiveObject                          { get; set; }
        public bool                                     IsSwapLock                              { get; set; }
        public bool                                     IsInActive                              { get; set; }

        public static UIButtonGroupUnit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIButtonGroupUnit() { Pointer= p0 };

            value.ActiveObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ActiveObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.InactiveObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 InactiveObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IsSwapLock                                = GetBool(new IntPtr(p + 0x030)); // 0x30 IsSwapLock                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsInActive                                = GetBool(new IntPtr(p + 0x031)); // 0x31 IsInActive                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
