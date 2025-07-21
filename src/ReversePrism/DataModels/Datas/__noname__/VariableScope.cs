using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType int int int Int32
    // 014 Stop                                     ModelPrimitiveType int int int Int32
    // 018 Variable                                 ModelClassType LocalVariable LocalVariable LocalVariable Pointer
    // 020 Parent                                   ModelClassType VariableScope VariableScope VariableScope Pointer
    // 028 ChildScopes                              ModelClassListType List`1<VariableScope> List`1<VariableScope> List<VariableScope> Pointer
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

            value.Start                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType int int int Int32 )
            value.Stop                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Stop                        ( ModelPrimitiveType int int int Int32 )
            value.Variable                                  = GetObject<LocalVariable>(new IntPtr(p + 0x018), ReversePrism.DataModels.LocalVariable.FromPointer); // 0x18 Variable                    ( ModelClassType LocalVariable LocalVariable LocalVariable Pointer )
            value.Parent                                    = GetObject<VariableScope>(new IntPtr(p + 0x020), ReversePrism.DataModels.VariableScope.FromPointer); // 0x20 Parent                      ( ModelClassType VariableScope VariableScope VariableScope Pointer )
            value.ChildScopes                               = GetObjectList<VariableScope>(new IntPtr(p + 0x028), ReversePrism.DataModels.VariableScope.FromPointer); // 0x28 ChildScopes                 ( ModelClassListType List`1<VariableScope> List`1<VariableScope> List<VariableScope> Pointer )

            return value;
        }
    }
}
