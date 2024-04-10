using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Next                                     00018657BFF0 ModelClassType XNode XNode XNode Pointer
    public partial class XNode : DataModel
    {
        public XNode?                                   Next                                    { get; set; }

        public static XNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XNode() { Pointer= p0 };

            value.Next                                      = GetObject<XNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.XNode.FromPointer); // 0246686DB350 0x20 Next                        ( 00018657BFF0 ModelClassType XNode XNode XNode Pointer )

            return value;
        }
    }
}
