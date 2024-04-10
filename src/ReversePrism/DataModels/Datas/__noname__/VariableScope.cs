using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001865F4940 ModelPrimitiveType int int int Int32
    // 014 Stop                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Variable                                 000186609C80 ModelClassType LocalVariable LocalVariable LocalVariable Pointer
    // 020 Parent                                   0001866E5470 ModelClassType VariableScope VariableScope VariableScope Pointer
    // 028 ChildScopes                              000185D26738 ModelClassListType List`1<VariableScope> List`1<VariableScope> List<VariableScope> Pointer
    public partial class VariableScope : DataModel
    {
        public int                                      Start                                   { get; set; }
        public int                                      Stop                                    { get; set; }
        public LocalVariable?                           Variable                                { get; set; }
        public VariableScope?                           Parent                                  { get; set; }
        public List<VariableScope>?                     ChildScopes                             { get; set; }

        public static VariableScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariableScope() { Pointer= p0 };

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 02466A074F20 0x10 Start                       ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Stop                                      = GetInt32(new IntPtr(p + 0x014)); // 02466A074F40 0x14 Stop                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Variable                                  = GetObject<LocalVariable>(new IntPtr(p + 0x018), ReversePrism.DataModels.LocalVariable.FromPointer); // 02466A074F60 0x18 Variable                    ( 000186609C80 ModelClassType LocalVariable LocalVariable LocalVariable Pointer )
            value.Parent                                    = GetObject<VariableScope>(new IntPtr(p + 0x020), ReversePrism.DataModels.VariableScope.FromPointer); // 02466A074F80 0x20 Parent                      ( 0001866E5470 ModelClassType VariableScope VariableScope VariableScope Pointer )
            value.ChildScopes                               = GetObjectList<VariableScope>(new IntPtr(p + 0x028), ReversePrism.DataModels.VariableScope.FromPointer); // 02466A074FA0 0x28 ChildScopes                 ( 000185D26738 ModelClassListType List`1<VariableScope> List`1<VariableScope> List<VariableScope> Pointer )

            return value;
        }
    }
}
