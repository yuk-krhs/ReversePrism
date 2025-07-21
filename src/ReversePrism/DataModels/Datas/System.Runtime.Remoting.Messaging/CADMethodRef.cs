using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ctor                                     ModelPrimitiveType bool bool bool Bool
    // 018 TypeName                                 ModelPrimitiveType string string string String
    // 020 MethodName                               ModelPrimitiveType string string string String
    // 028 Param_names                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Generic_arg_names                        ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class CADMethodRef : DataModel
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
            var value   = new CADMethodRef() { Pointer= p0 };

            value.Ctor                                      = GetBool(new IntPtr(p + 0x010)); // 0x10 Ctor                        ( ModelPrimitiveType bool bool bool Bool )
            value.TypeName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 TypeName                    ( ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x020)); // 0x20 MethodName                  ( ModelPrimitiveType string string string String )
            value.Param_names                               = GetStringList(new IntPtr(p + 0x028)); // 0x28 Param_names                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Generic_arg_names                         = GetStringList(new IntPtr(p + 0x030)); // 0x30 Generic_arg_names           ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
