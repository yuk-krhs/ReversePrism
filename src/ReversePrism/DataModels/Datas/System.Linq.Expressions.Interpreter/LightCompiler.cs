using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Instructions                             ModelClassType InstructionList InstructionList InstructionList Pointer
    // 018 Locals                                   ModelClassType LocalVariables LocalVariables LocalVariables Pointer
    // 020 DebugInfos                               ModelClassListType List`1<DebugInfo> List`1<DebugInfo> List<DebugInfo> Pointer
    // 028 _treeLabels                              HybridReferenceDictionary`2<LabelTarget, LabelInfo> IL2CPP_TYPE_GENERICINST
    // 030 LabelBlock                               ModelClassType LabelScopeInfo LabelScopeInfo LabelScopeInfo Pointer
    // 038 _exceptionForRethrowStack                Stack`1<ParameterExpression> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType LightCompiler LightCompiler LightCompiler Pointer
    // 048 Guard                                    ModelClassType StackGuard StackGuard StackGuard Pointer
    // 000 s_emptyLocals                            LocalDefinition[] IL2CPP_TYPE_SZARRAY
    public partial class LightCompiler : DataModel
    {
        public InstructionList?                         Instructions                            { get; set; }
        public LocalVariables?                          Locals                                  { get; set; }
        public List<DebugInfo>?                         DebugInfos                              { get; set; }
        public LabelScopeInfo?                          LabelBlock                              { get; set; }
        public LightCompiler?                           Parent                                  { get; set; }
        public StackGuard?                              Guard                                   { get; set; }

        public static LightCompiler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightCompiler() { Pointer= p0 };

            value.Instructions                              = GetObject<InstructionList>(new IntPtr(p + 0x010), ReversePrism.DataModels.InstructionList.FromPointer); // 0x10 Instructions                ( ModelClassType InstructionList InstructionList InstructionList Pointer )
            value.Locals                                    = GetObject<LocalVariables>(new IntPtr(p + 0x018), ReversePrism.DataModels.LocalVariables.FromPointer); // 0x18 Locals                      ( ModelClassType LocalVariables LocalVariables LocalVariables Pointer )
            value.DebugInfos                                = GetObjectList<DebugInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.DebugInfo.FromPointer); // 0x20 DebugInfos                  ( ModelClassListType List`1<DebugInfo> List`1<DebugInfo> List<DebugInfo> Pointer )
            value.LabelBlock                                = GetObject<LabelScopeInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.LabelScopeInfo.FromPointer); // 0x30 LabelBlock                  ( ModelClassType LabelScopeInfo LabelScopeInfo LabelScopeInfo Pointer )
            value.Parent                                    = GetObject<LightCompiler>(new IntPtr(p + 0x040), ReversePrism.DataModels.LightCompiler.FromPointer); // 0x40 Parent                      ( ModelClassType LightCompiler LightCompiler LightCompiler Pointer )
            value.Guard                                     = GetObject<StackGuard>(new IntPtr(p + 0x048), ReversePrism.DataModels.StackGuard.FromPointer); // 0x48 Guard                       ( ModelClassType StackGuard StackGuard StackGuard Pointer )

            return value;
        }
    }
}
