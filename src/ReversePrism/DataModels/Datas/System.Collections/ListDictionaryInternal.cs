using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Head                                     ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer
    // 018 Version                                  ModelPrimitiveType int int int Int32
    // 01C Count                                    ModelPrimitiveType int int int Int32
    // 020 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class ListDictionaryInternal : DataModel
    {
        public DictionaryNode?                          Head                                    { get; set; }
        public int                                      Version                                 { get; set; }
        public int                                      Count                                   { get; set; }

        public static ListDictionaryInternal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListDictionaryInternal() { Pointer= p0 };

            value.Head                                      = GetObject<DictionaryNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.DictionaryNode.FromPointer); // 0x10 Head                        ( ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 Version                     ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
