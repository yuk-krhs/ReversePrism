using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866731A0 ModelPrimitiveType string string string String
    // 018 Id                                       0001865D65C0 ModelEnumType FunctionId FunctionId FunctionId Int32
    // 020 Result                                   000186693960 ModelClassType Type Type Type Pointer
    // 028 IsValidateArguments                      000186596860 ModelPrimitiveType bool bool bool Bool
    // 029 IsVariantArgumentList                    000186596860 ModelPrimitiveType bool bool bool Bool
    // 02C ArgumentCount                            0001865F44E0 ModelPrimitiveType int int int Int32
    // 030 Parameters                               000185B83130 ModelClassListType Type[] Type[] List<Type> Pointer
    // 000 s_functionName                           string[] IL2CPP_TYPE_SZARRAY
    public partial class Function
    {
        public string                                   Name                                    { get; set; }
        public FunctionId                               Id                                      { get; set; }
        public Type?                                    Result                                  { get; set; }
        public bool                                     IsValidateArguments                     { get; set; }
        public bool                                     IsVariantArgumentList                   { get; set; }
        public int                                      ArgumentCount                           { get; set; }
        public List<Type>?                              Parameters                              { get; set; }

        public static Function? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Function();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D892C798 0x10 Name                        ( 0001866731A0 ModelPrimitiveType string string string String )
            value.Id                                        = (FunctionId)GetInt32(new IntPtr(p + 0x018)); // 0270D892C7B8 0x18 Id                          ( 0001865D65C0 ModelEnumType FunctionId FunctionId FunctionId Int32 )
            value.Result                                    = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D892C7D8 0x20 Result                      ( 000186693960 ModelClassType Type Type Type Pointer )
            value.IsValidateArguments                       = GetBool(new IntPtr(p + 0x028)); // 0270D892C7F8 0x28 IsValidateArguments         ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.IsVariantArgumentList                     = GetBool(new IntPtr(p + 0x029)); // 0270D892C818 0x29 IsVariantArgumentList       ( 000186596860 ModelPrimitiveType bool bool bool Bool )
            value.ArgumentCount                             = GetInt32(new IntPtr(p + 0x02C)); // 0270D892C838 0x2C ArgumentCount               ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.Parameters                                = GetObjectList<Type>(new IntPtr(p + 0x030), ReversePrism.DataModels.Type.FromPointer); // 0270D892C858 0x30 Parameters                  ( 000185B83130 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
