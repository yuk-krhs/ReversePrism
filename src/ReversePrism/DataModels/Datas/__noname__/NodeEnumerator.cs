using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     ModelClassType ListDictionary ListDictionary ListDictionary Pointer
    // 018 Current                                  ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer
    // 020 Version                                  ModelPrimitiveType int int int Int32
    // 024 Start                                    ModelPrimitiveType bool bool bool Bool
    public partial class NodeEnumerator : DataModel
    {
        public ListDictionary?                          List                                    { get; set; }
        public DictionaryNode?                          Current                                 { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     Start                                   { get; set; }

        public static NodeEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NodeEnumerator() { Pointer= p0 };

            value.List                                      = GetObject<ListDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListDictionary.FromPointer); // 0x10 List                        ( ModelClassType ListDictionary ListDictionary ListDictionary Pointer )
            value.Current                                   = GetObject<DictionaryNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.DictionaryNode.FromPointer); // 0x18 Current                     ( ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Start                                     = GetBool(new IntPtr(p + 0x024)); // 0x24 Start                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
