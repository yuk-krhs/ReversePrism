using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ScrollView                             ModelClassType ScrollView ScrollView ScrollView Pointer
    public partial class CollectionVirtualizationController : DataModel
    {
        public ScrollView?                              M_ScrollView                            { get; set; }

        public static CollectionVirtualizationController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionVirtualizationController() { Pointer= p0 };

            value.M_ScrollView                              = GetObject<ScrollView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScrollView.FromPointer); // 0x10 M_ScrollView                ( ModelClassType ScrollView ScrollView ScrollView Pointer )

            return value;
        }
    }
}
