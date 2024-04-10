using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Conditions                               000185CC3D18 ModelClassListType SwitchObjectCondition[] SwitchObjectCondition[] List<SwitchObjectCondition> Pointer
    // 018 ObjectsRoot                              0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SwitchObjectData : DataModel
    {
        public List<SwitchObjectCondition>?             Conditions                              { get; set; }
        public GameObject?                              ObjectsRoot                             { get; set; }

        public static SwitchObjectData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchObjectData() { Pointer= p0 };

            value.Conditions                                = GetObjectList<SwitchObjectCondition>(new IntPtr(p + 0x010), ReversePrism.DataModels.SwitchObjectCondition.FromPointer); // 0245A6B02188 0x10 Conditions                  ( 000185CC3D18 ModelClassListType SwitchObjectCondition[] SwitchObjectCondition[] List<SwitchObjectCondition> Pointer )
            value.ObjectsRoot                               = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0245A6B021A8 0x18 ObjectsRoot                 ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
