using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Doc                                      ModelClassType SecurityDocument SecurityDocument SecurityDocument Pointer
    // 018 T                                        ModelClassType Tokenizer Tokenizer Tokenizer Pointer
    public partial class Parser : DataModel
    {
        public SecurityDocument?                        Doc                                     { get; set; }
        public Tokenizer?                               T                                       { get; set; }

        public static Parser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Parser() { Pointer= p0 };

            value.Doc                                       = GetObject<SecurityDocument>(new IntPtr(p + 0x010), ReversePrism.DataModels.SecurityDocument.FromPointer); // 0x10 Doc                         ( ModelClassType SecurityDocument SecurityDocument SecurityDocument Pointer )
            value.T                                         = GetObject<Tokenizer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Tokenizer.FromPointer); // 0x18 T                           ( ModelClassType Tokenizer Tokenizer Tokenizer Pointer )

            return value;
        }
    }
}
