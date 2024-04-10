using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Head                                     0001866913E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer
    // 018 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Head                                      = GetObject<DictionaryNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.DictionaryNode.FromPointer); // 024666D95AB0 0x10 Head                        ( 0001866913E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 024666D95AD0 0x18 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x01C)); // 024666D95AF0 0x1C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
