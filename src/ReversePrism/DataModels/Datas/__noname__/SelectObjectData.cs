using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Condition                                000186755450 ModelClassType Condition Condition Condition Pointer
    // 018 ObjectsRoot                              0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SelectObjectData
    {
        public Condition?                               Condition                               { get; set; }
        public GameObject?                              ObjectsRoot                             { get; set; }

        public static SelectObjectData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectObjectData();

            value.Condition                                 = GetObject<Condition>(new IntPtr(p + 0x010), ReversePrism.DataModels.Condition.FromPointer); // 0270D4D61680 0x10 Condition                   ( 000186755450 ModelClassType Condition Condition Condition Pointer )
            value.ObjectsRoot                               = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4D616A0 0x18 ObjectsRoot                 ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
