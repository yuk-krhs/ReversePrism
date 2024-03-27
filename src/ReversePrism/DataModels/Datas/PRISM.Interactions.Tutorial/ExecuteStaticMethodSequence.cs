using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 018 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 020 Arguments                                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ExecuteStaticMethodSequence
    {
        public string                                   TypeName                                { get; set; }
        public string                                   MethodName                              { get; set; }
        public List<string>?                            Arguments                               { get; set; }

        public static ExecuteStaticMethodSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteStaticMethodSequence();

            value.TypeName                                  = GetString(new IntPtr(p + 0x010)); // 0270DBC10A48 0x10 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x018)); // 0270DBC10A68 0x18 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Arguments                                 = GetStringList(new IntPtr(p + 0x020)); // 0270DBC10A88 0x20 Arguments                   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
