using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType ListDictionary ListDictionary ListDictionary Pointer
    // 018 IsKeys                                   ModelPrimitiveType bool bool bool Bool
    public partial class NodeKeyValueCollection : DataModel
    {
        public ListDictionary?                          List                                    { get; set; }
        public bool                                     IsKeys                                  { get; set; }

        public static NodeKeyValueCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NodeKeyValueCollection() { Pointer= p0 };

            value.List                                      = GetObject<ListDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListDictionary.FromPointer); // 0x10 List                        ( ModelClassType ListDictionary ListDictionary ListDictionary Pointer )
            value.IsKeys                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 IsKeys                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
