using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ActiveObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 InactiveObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 IsSwapLock                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 IsInActive                               000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.ActiveObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024665557238 0x20 ActiveObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InactiveObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665557258 0x28 InactiveObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsSwapLock                                = GetBool(new IntPtr(p + 0x030)); // 024665557278 0x30 IsSwapLock                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsInActive                                = GetBool(new IntPtr(p + 0x031)); // 024665557298 0x31 IsInActive                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
