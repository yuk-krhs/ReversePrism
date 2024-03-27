using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FIELD_PATH_SEPARATOR                     char IL2CPP_TYPE_CHAR
    // 010 Root                                     0001866A6450 ModelClassType Node Node Node Pointer
    public partial class FieldMaskTree
    {
        public Node?                                    Root                                    { get; set; }

        public static FieldMaskTree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldMaskTree();

            value.Root                                      = GetObject<Node>(new IntPtr(p + 0x010), ReversePrism.DataModels.Node.FromPointer); // 0270DA3F96E0 0x10 Root                        ( 0001866A6450 ModelClassType Node Node Node Pointer )

            return value;
        }
    }
}
