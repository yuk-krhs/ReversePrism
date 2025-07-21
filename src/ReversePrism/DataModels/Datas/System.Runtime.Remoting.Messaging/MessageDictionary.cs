using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InternalProperties                       ModelClassType IDictionary IDictionary IDictionary Pointer
    // 018 Message                                  ModelClassType IMethodMessage IMethodMessage IMethodMessage Pointer
    // 020 MethodKeys                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 OwnProperties                            ModelPrimitiveType bool bool bool Bool
    public partial class MessageDictionary : DataModel
    {
        public IDictionary?                             InternalProperties                      { get; set; }
        public IMethodMessage?                          Message                                 { get; set; }
        public List<string>?                            MethodKeys                              { get; set; }
        public bool                                     OwnProperties                           { get; set; }

        public static MessageDictionary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageDictionary() { Pointer= p0 };

            value.InternalProperties                        = GetObject<IDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDictionary.FromPointer); // 0x10 InternalProperties          ( ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.Message                                   = GetObject<IMethodMessage>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMethodMessage.FromPointer); // 0x18 Message                     ( ModelClassType IMethodMessage IMethodMessage IMethodMessage Pointer )
            value.MethodKeys                                = GetStringList(new IntPtr(p + 0x020)); // 0x20 MethodKeys                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OwnProperties                             = GetBool(new IntPtr(p + 0x028)); // 0x28 OwnProperties               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
