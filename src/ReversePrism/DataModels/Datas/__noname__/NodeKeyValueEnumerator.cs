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
    // 024 IsKeys                                   ModelPrimitiveType bool bool bool Bool
    // 025 Start                                    ModelPrimitiveType bool bool bool Bool
    public partial class NodeKeyValueEnumerator : DataModel
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
            var value   = new NodeKeyValueEnumerator() { Pointer= p0 };

            value.List                                      = GetObject<ListDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListDictionary.FromPointer); // 0x10 List                        ( ModelClassType ListDictionary ListDictionary ListDictionary Pointer )
            value.Current                                   = GetObject<DictionaryNode>(new IntPtr(p + 0x018), ReversePrism.DataModels.DictionaryNode.FromPointer); // 0x18 Current                     ( ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 Version                     ( ModelPrimitiveType int int int Int32 )
            value.IsKeys                                    = GetBool(new IntPtr(p + 0x024)); // 0x24 IsKeys                      ( ModelPrimitiveType bool bool bool Bool )
            value.Start                                     = GetBool(new IntPtr(p + 0x025)); // 0x25 Start                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
