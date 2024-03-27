using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Next                                     00018657BFF0 ModelClassType XNode XNode XNode Pointer
    public partial class XNode
    {
        public XNode?                                   Next                                    { get; set; }

        public static XNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XNode();

            value.Next                                      = GetObject<XNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XNode.FromPointer); // 0270D8672B20 0x20 Next                        ( 00018657BFF0 ModelClassType XNode XNode XNode Pointer )

            return value;
        }
    }
}
