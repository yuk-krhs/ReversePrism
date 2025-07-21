using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Conditions                               ModelClassListType SwitchObjectCondition[] SwitchObjectCondition[] List<SwitchObjectCondition> Pointer
    // 018 ObjectsRoot                              ModelClassType GameObject GameObject GameObject Pointer
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

            value.Conditions                                = GetObjectList<SwitchObjectCondition>(new IntPtr(p + 0x010), ReversePrism.DataModels.SwitchObjectCondition.FromPointer); // 0x10 Conditions                  ( ModelClassListType SwitchObjectCondition[] SwitchObjectCondition[] List<SwitchObjectCondition> Pointer )
            value.ObjectsRoot                               = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0x18 ObjectsRoot                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
