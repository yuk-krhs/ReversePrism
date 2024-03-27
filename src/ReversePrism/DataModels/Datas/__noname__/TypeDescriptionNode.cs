using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Next                                     000186650FC0 ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer
    // 028 Provider                                 0001866D3680 ModelClassType TypeDescriptionProvider TypeDescriptionProvider TypeDescriptionProvider Pointer
    public partial class TypeDescriptionNode
    {
        public TypeDescriptionNode?                     Next                                    { get; set; }
        public TypeDescriptionProvider?                 Provider                                { get; set; }

        public static TypeDescriptionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeDescriptionNode();

            value.Next                                      = GetObject<TypeDescriptionNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.TypeDescriptionNode.FromPointer); // 0270060281C8 0x20 Next                        ( 000186650FC0 ModelClassType TypeDescriptionNode TypeDescriptionNode TypeDescriptionNode Pointer )
            value.Provider                                  = GetObject<TypeDescriptionProvider>(new IntPtr(p + 0x028), ReversePrism.DataModels.TypeDescriptionProvider.FromPointer); // 0270060281E8 0x28 Provider                    ( 0001866D3680 ModelClassType TypeDescriptionProvider TypeDescriptionProvider TypeDescriptionProvider Pointer )

            return value;
        }
    }
}
