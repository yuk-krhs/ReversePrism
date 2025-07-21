using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GenericTypeArguments                     ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 RequiredUnityDefine                      ModelPrimitiveType string string string String
    // 020 CompileTarget                            ModelEnumType BurstCompatibleCompileTarget BurstCompatibleCompileTarget BurstCompatibleCompileTarget Int32
    public partial class GenerateTestsForBurstCompatibilityAttribute : DataModel
    {
        public List<Type>?                              GenericTypeArguments                    { get; set; }
        public string                                   RequiredUnityDefine                     { get; set; }
        public BurstCompatibleCompileTarget             CompileTarget                           { get; set; }

        public static GenerateTestsForBurstCompatibilityAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenerateTestsForBurstCompatibilityAttribute() { Pointer= p0 };

            value.GenericTypeArguments                      = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 GenericTypeArguments        ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.RequiredUnityDefine                       = GetString(new IntPtr(p + 0x018)); // 0x18 RequiredUnityDefine         ( ModelPrimitiveType string string string String )
            value.CompileTarget                             = (BurstCompatibleCompileTarget)GetInt32(new IntPtr(p + 0x020)); // 0x20 CompileTarget               ( ModelEnumType BurstCompatibleCompileTarget BurstCompatibleCompileTarget BurstCompatibleCompileTarget Int32 )

            return value;
        }
    }
}
