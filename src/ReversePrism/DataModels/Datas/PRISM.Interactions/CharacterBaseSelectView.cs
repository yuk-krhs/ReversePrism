using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitTabGroup                             000186711840 ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer
    // 028 BaseSelectView                           000186742540 ModelClassType BaseSelectView BaseSelectView BaseSelectView Pointer
    // 030 onTapPosition                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class CharacterBaseSelectView
    {
        public UnitTabGroupView?                        UnitTabGroup                            { get; set; }
        public BaseSelectView?                          BaseSelectView                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static CharacterBaseSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectView();

            value.UnitTabGroup                              = GetObject<UnitTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitTabGroupView.FromPointer); // 0270DA228EA0 0x20 UnitTabGroup                ( 000186711840 ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer )
            value.BaseSelectView                            = GetObject<BaseSelectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.BaseSelectView.FromPointer); // 0270DA228EC0 0x28 BaseSelectView              ( 000186742540 ModelClassType BaseSelectView BaseSelectView BaseSelectView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA228F00 0x38 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
