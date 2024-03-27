using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ctor                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 TypeName                                 000186671910 ModelPrimitiveType string string string String
    // 020 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 028 Param_names                              000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Generic_arg_names                        000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class CADMethodRef
    {
        public bool                                     Ctor                                    { get; set; }
        public string                                   TypeName                                { get; set; }
        public string                                   MethodName                              { get; set; }
        public List<string>?                            Param_names                             { get; set; }
        public List<string>?                            Generic_arg_names                       { get; set; }

        public static CADMethodRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CADMethodRef();

            value.Ctor                                      = GetBool(new IntPtr(p + 0x010)); // 0270D6BE8C50 0x10 Ctor                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0270D6BE8C70 0x18 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x020)); // 0270D6BE8C90 0x20 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Param_names                               = GetStringList(new IntPtr(p + 0x028)); // 0270D6BE8CB0 0x28 Param_names                 ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Generic_arg_names                         = GetStringList(new IntPtr(p + 0x030)); // 0270D6BE8CD0 0x30 Generic_arg_names           ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
