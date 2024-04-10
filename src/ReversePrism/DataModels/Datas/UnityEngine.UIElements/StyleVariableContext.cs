using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 none                                     StyleVariableContext IL2CPP_TYPE_CLASS
    // 010 M_VariableHash                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_Variables                              000185D0F4F8 ModelEnumListType List`1<StyleVariable> List`1<StyleVariable> List<StyleVariable> Pointer
    // 020 M_SortedHash                             000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class StyleVariableContext : DataModel
    {
        public int                                      M_VariableHash                          { get; set; }
        public List<StyleVariable>?                     M_Variables                             { get; set; }
        public List<int>?                               M_SortedHash                            { get; set; }

        public static StyleVariableContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleVariableContext() { Pointer= p0 };

            value.M_VariableHash                            = GetInt32(new IntPtr(p + 0x010)); // 0245A6805568 0x10 M_VariableHash              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Variables                               = GetEnumList<StyleVariable>(new IntPtr(p + 0x018)); // 0245A6805588 0x18 M_Variables                 ( 000185D0F4F8 ModelEnumListType List`1<StyleVariable> List`1<StyleVariable> List<StyleVariable> Pointer )
            value.M_SortedHash                              = GetInt32List(new IntPtr(p + 0x020)); // 0245A68055A8 0x20 M_SortedHash                ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
