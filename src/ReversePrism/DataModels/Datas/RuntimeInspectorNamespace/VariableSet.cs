using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 INCLUDE_ALL_VARIABLES                    string IL2CPP_TYPE_STRING
    // 010 M_type                                   ModelPrimitiveType string string string String
    // 018 Type                                     ModelClassType Type Type Type Pointer
    // 020 M_variables                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 variables                                HashSet`1<string> IL2CPP_TYPE_GENERICINST
    public partial class VariableSet : DataModel
    {
        public string                                   M_type                                  { get; set; }
        public Type?                                    Type                                    { get; set; }
        public List<string>?                            M_variables                             { get; set; }

        public static VariableSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariableSet() { Pointer= p0 };

            value.M_type                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_type                      ( ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 Type                        ( ModelClassType Type Type Type Pointer )
            value.M_variables                               = GetStringList(new IntPtr(p + 0x020)); // 0x20 M_variables                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
