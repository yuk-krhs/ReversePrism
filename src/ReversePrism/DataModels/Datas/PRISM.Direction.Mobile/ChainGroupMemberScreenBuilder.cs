using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ViewPrefab                               000186557FA0 ModelClassType ChainGroupMemberScreenView ChainGroupMemberScreenView ChainGroupMemberScreenView Pointer
    // 028 ViewParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class ChainGroupMemberScreenBuilder
    {
        public ChainGroupMemberScreenView?              ViewPrefab                              { get; set; }
        public Transform?                               ViewParent                              { get; set; }

        public static ChainGroupMemberScreenBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainGroupMemberScreenBuilder();

            value.ViewPrefab                                = GetObject<ChainGroupMemberScreenView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainGroupMemberScreenView.FromPointer); // 0270DB647608 0x20 ViewPrefab                  ( 000186557FA0 ModelClassType ChainGroupMemberScreenView ChainGroupMemberScreenView ChainGroupMemberScreenView Pointer )
            value.ViewParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DB647628 0x28 ViewParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
