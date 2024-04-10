using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 List                                     000186537C70 ModelClassType ListDictionary ListDictionary ListDictionary Pointer
    // 018 Current                                  0001866907E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer
    // 020 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Start                                    000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.List                                      = GetObject<ListDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListDictionary.FromPointer); // 024667BDA110 0x10 List                        ( 000186537C70 ModelClassType ListDictionary ListDictionary ListDictionary Pointer )
            value.Current                                   = GetObject<DictionaryNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.DictionaryNode.FromPointer); // 024667BDA130 0x18 Current                     ( 0001866907E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 024667BDA150 0x20 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Start                                     = GetBool(new IntPtr(p + 0x024)); // 024667BDA170 0x24 Start                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
