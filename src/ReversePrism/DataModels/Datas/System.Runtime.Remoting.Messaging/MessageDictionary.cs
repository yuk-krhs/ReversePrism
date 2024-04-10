using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InternalProperties                       000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer
    // 018 Message                                  0001865B2810 ModelClassType IMethodMessage IMethodMessage IMethodMessage Pointer
    // 020 MethodKeys                               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 OwnProperties                            000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.InternalProperties                        = GetObject<IDictionary>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDictionary.FromPointer); // 024666C61108 0x10 InternalProperties          ( 000186750200 ModelClassType IDictionary IDictionary IDictionary Pointer )
            value.Message                                   = GetObject<IMethodMessage>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMethodMessage.FromPointer); // 024666C61128 0x18 Message                     ( 0001865B2810 ModelClassType IMethodMessage IMethodMessage IMethodMessage Pointer )
            value.MethodKeys                                = GetStringList(new IntPtr(p + 0x020)); // 024666C61148 0x20 MethodKeys                  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.OwnProperties                             = GetBool(new IntPtr(p + 0x028)); // 024666C61168 0x28 OwnProperties               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
