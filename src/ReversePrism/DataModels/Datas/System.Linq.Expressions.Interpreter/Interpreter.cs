using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NoValue                                  <object> IL2CPP_TYPE_OBJECT
    // 010 Instructions                             00018670EF50 ModelEnumType InstructionArray InstructionArray InstructionArray Int32
    // 038 _objects                                 <object>[] IL2CPP_TYPE_SZARRAY
    // 040 Labels                                   000185CA1E18 ModelEnumListType RuntimeLabel[] RuntimeLabel[] List<RuntimeLabel> Pointer
    // 048 DebugInfos                               000185B79E80 ModelClassListType DebugInfo[] DebugInfo[] List<DebugInfo> Pointer
    // 050 Name                                     000186672F10 ModelPrimitiveType string string string String
    // 058 LocalCount                               0001865F4260 ModelPrimitiveType int int int Int32
    // 060 <ClosureVariables>k__BackingField        Dictionary`2<ParameterExpression, LocalVariable> IL2CPP_TYPE_GENERICINST
    public partial class Interpreter
    {
        public InstructionArray                         Instructions                            { get; set; }
        public List<RuntimeLabel>?                      Labels                                  { get; set; }
        public List<DebugInfo>?                         DebugInfos                              { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      LocalCount                              { get; set; }

        public static Interpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Interpreter();

            value.Instructions                              = (InstructionArray)GetInt32(new IntPtr(p + 0x010)); // 0270D9FD6F58 0x10 Instructions                ( 00018670EF50 ModelEnumType InstructionArray InstructionArray InstructionArray Int32 )
            value.Labels                                    = GetEnumList<RuntimeLabel>(new IntPtr(p + 0x040)); // 0270D9FD6F98 0x40 Labels                      ( 000185CA1E18 ModelEnumListType RuntimeLabel[] RuntimeLabel[] List<RuntimeLabel> Pointer )
            value.DebugInfos                                = GetObjectList<DebugInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.DebugInfo.FromPointer); // 0270D9FD6FB8 0x48 DebugInfos                  ( 000185B79E80 ModelClassListType DebugInfo[] DebugInfo[] List<DebugInfo> Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0270D9FD6FD8 0x50 Name                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.LocalCount                                = GetInt32(new IntPtr(p + 0x058)); // 0270D9FD6FF8 0x58 LocalCount                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
