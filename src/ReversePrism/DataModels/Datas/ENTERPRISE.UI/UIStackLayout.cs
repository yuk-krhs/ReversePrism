using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 Generator                                00018664D700 ModelClassType IStackLayoutItemGenerator IStackLayoutItemGenerator IStackLayoutItemGenerator Pointer
    // 0B0 StackItems                               000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    public partial class UIStackLayout : DataModel
    {
        public IStackLayoutItemGenerator?               Generator                               { get; set; }
        public List<GameObject>?                        StackItems                              { get; set; }

        public static UIStackLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIStackLayout() { Pointer= p0 };

            value.Generator                                 = GetObject<IStackLayoutItemGenerator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.IStackLayoutItemGenerator.FromPointer); // 02466B0A6D28 0xA8 Generator                   ( 00018664D700 ModelClassType IStackLayoutItemGenerator IStackLayoutItemGenerator IStackLayoutItemGenerator Pointer )
            value.StackItems                                = GetObjectList<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 02466B0A6D48 0xB0 StackItems                  ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )

            return value;
        }
    }
}
