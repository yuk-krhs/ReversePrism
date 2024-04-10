using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Head                                     0001866907E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer
    // 018 Version                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Comparer                                 000186735840 ModelClassType IComparer IComparer IComparer Pointer
    // 028 _syncRoot                                <object> IL2CPP_TYPE_OBJECT
    public partial class ListDictionary : DataModel
    {
        public DictionaryNode?                          Head                                    { get; set; }
        public int                                      Version                                 { get; set; }
        public int                                      Count                                   { get; set; }
        public IComparer?                               Comparer                                { get; set; }

        public static ListDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListDictionary() { Pointer= p0 };

            value.Head                                      = GetObject<DictionaryNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.DictionaryNode.FromPointer); // 024667A8D6F8 0x10 Head                        ( 0001866907E0 ModelClassType DictionaryNode DictionaryNode DictionaryNode Pointer )
            value.Version                                   = GetInt32(new IntPtr(p + 0x018)); // 024667A8D718 0x18 Version                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x01C)); // 024667A8D738 0x1C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IComparer.FromPointer); // 024667A8D758 0x20 Comparer                    ( 000186735840 ModelClassType IComparer IComparer IComparer Pointer )

            return value;
        }
    }
}
