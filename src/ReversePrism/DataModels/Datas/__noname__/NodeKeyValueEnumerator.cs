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
    // 024 IsKeys                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 025 Start                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class NodeKeyValueEnumerator
    {
        public ListDictionary?                          List                                    { get; set; }
        public DictionaryNode?                          Current                                 { get; set; }
        public int                                      Version                                 { get; set; }
        public bool                                     IsKeys                                  { get; set; }
        public bool                                     Start                                   { get; set; }

        public static NodeKeyValueEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NodeKeyValueEnumerator();

            value.List                                      = GetObject<ListDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListDictionary.FromPointer); // 0270D7B6A598 0x10 List                        ( 000186537C70 ModelClassType ListDictionary ListDictionary ListDictionary Pointer )
            value.Current                                   = GetObject<DictionaryNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.DictionaryNode.FromPointer); // 0270D7B6A5B8 0x18 Current                     ( 0001866907E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0270D7B6A5D8 0x20 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsKeys                                    = GetBool(new IntPtr(p + 0x024)); // 0270D7B6A5F8 0x24 IsKeys                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Start                                     = GetBool(new IntPtr(p + 0x025)); // 0270D7B6A618 0x25 Start                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
