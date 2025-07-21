using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType ProduceFriendSupportSelectView ProduceFriendSupportSelectView ProduceFriendSupportSelectView Pointer
    public partial class ProduceFriendSupportSelectBuilder : DataModel
    {
        public ProduceFriendSupportSelectView?          View                                    { get; set; }

        public static ProduceFriendSupportSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportSelectBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceFriendSupportSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceFriendSupportSelectView.FromPointer); // 0x20 View                        ( ModelClassType ProduceFriendSupportSelectView ProduceFriendSupportSelectView ProduceFriendSupportSelectView Pointer )

            return value;
        }
    }
}
