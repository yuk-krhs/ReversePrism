using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 GoFilterBadge                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class UISortFilterTabGroup : DataModel
    {
        public GameObject?                              GoFilterBadge                           { get; set; }

        public static UISortFilterTabGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UISortFilterTabGroup() { Pointer= p0 };

            value.GoFilterBadge                             = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246655153E0 0x38 GoFilterBadge               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
