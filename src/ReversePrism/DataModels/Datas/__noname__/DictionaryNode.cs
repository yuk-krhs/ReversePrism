using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 key                                      <object> IL2CPP_TYPE_OBJECT
    // 018 value                                    <object> IL2CPP_TYPE_OBJECT
    // 020 Next                                     000186690A20 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer
    public partial class DictionaryNode : DataModel
    {
        public DictionaryNode?                          Next                                    { get; set; }

        public static DictionaryNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DictionaryNode() { Pointer= p0 };

            value.Next                                      = GetObject<DictionaryNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.DictionaryNode.FromPointer); // 024667BDA230 0x20 Next                        ( 000186690A20 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )

            return value;
        }
    }
}
