using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitTabGroup                             ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer
    // 028 BaseSelectView                           ModelClassType BaseSelectView BaseSelectView BaseSelectView Pointer
    // 030 onTapPosition                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CharacterBaseSelectView : DataModel
    {
        public UnitTabGroupView?                        UnitTabGroup                            { get; set; }
        public BaseSelectView?                          BaseSelectView                          { get; set; }

        public static CharacterBaseSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectView() { Pointer= p0 };

            value.UnitTabGroup                              = GetObject<UnitTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitTabGroupView.FromPointer); // 0x20 UnitTabGroup                ( ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer )
            value.BaseSelectView                            = GetObject<BaseSelectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.BaseSelectView.FromPointer); // 0x28 BaseSelectView              ( ModelClassType BaseSelectView BaseSelectView BaseSelectView Pointer )

            return value;
        }
    }
}
