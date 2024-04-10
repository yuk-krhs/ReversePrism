using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Variables                                000185B93120 ModelClassListType MemberInfo[] MemberInfo[] List<MemberInfo> Pointer
    // 020 HiddenVariables                          000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer
    // 028 ExposedVariables                         000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer
    // 030 FieldVisibility                          0001866EE0C0 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32
    // 034 PropertyVisibility                       0001866EE0C0 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32
    public partial class ExposedVariablesEnumerator : DataModel
    {
        public int                                      Index                                   { get; set; }
        public List<MemberInfo>?                        Variables                               { get; set; }
        public List<VariableSet>?                       HiddenVariables                         { get; set; }
        public List<VariableSet>?                       ExposedVariables                        { get; set; }
        public VariableVisibility                       FieldVisibility                         { get; set; }
        public VariableVisibility                       PropertyVisibility                      { get; set; }

        public static ExposedVariablesEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExposedVariablesEnumerator() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 02466B235A08 0x10 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Variables                                 = GetObjectList<MemberInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MemberInfo.FromPointer); // 02466B235A28 0x18 Variables                   ( 000185B93120 ModelClassListType MemberInfo[] MemberInfo[] List<MemberInfo> Pointer )
            value.HiddenVariables                           = GetObjectList<VariableSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.VariableSet.FromPointer); // 02466B235A48 0x20 HiddenVariables             ( 000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer )
            value.ExposedVariables                          = GetObjectList<VariableSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.VariableSet.FromPointer); // 02466B235A68 0x28 ExposedVariables            ( 000185D1A9D8 ModelClassListType List`1<VariableSet> List`1<VariableSet> List<VariableSet> Pointer )
            value.FieldVisibility                           = (VariableVisibility)GetInt32(new IntPtr(p + 0x030)); // 02466B235A88 0x30 FieldVisibility             ( 0001866EE0C0 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32 )
            value.PropertyVisibility                        = (VariableVisibility)GetInt32(new IntPtr(p + 0x034)); // 02466B235AA8 0x34 PropertyVisibility          ( 0001866EE0C0 ModelEnumType VariableVisibility VariableVisibility VariableVisibility Int32 )

            return value;
        }
    }
}
