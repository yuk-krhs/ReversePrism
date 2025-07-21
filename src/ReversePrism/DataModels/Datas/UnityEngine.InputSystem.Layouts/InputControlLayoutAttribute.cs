using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StateType                                ModelClassType Type Type Type Pointer
    // 018 StateFormat                              ModelPrimitiveType string string string String
    // 020 CommonUsages                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Variants                                 ModelPrimitiveType string string string String
    // 030 IsNoisy                                  ModelPrimitiveType bool bool bool Bool
    // 031 canRunInBackgroundInternal               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 033 updateBeforeRenderInternal               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 035 IsGenericTypeOfDevice                    ModelPrimitiveType bool bool bool Bool
    // 038 DisplayName                              ModelPrimitiveType string string string String
    // 040 Description                              ModelPrimitiveType string string string String
    // 048 HideInUI                                 ModelPrimitiveType bool bool bool Bool
    public partial class InputControlLayoutAttribute : DataModel
    {
        public Type?                                    StateType                               { get; set; }
        public string                                   StateFormat                             { get; set; }
        public List<string>?                            CommonUsages                            { get; set; }
        public string                                   Variants                                { get; set; }
        public bool                                     IsNoisy                                 { get; set; }
        public bool                                     IsGenericTypeOfDevice                   { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   Description                             { get; set; }
        public bool                                     HideInUI                                { get; set; }

        public static InputControlLayoutAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputControlLayoutAttribute() { Pointer= p0 };

            value.StateType                                 = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 StateType                   ( ModelClassType Type Type Type Pointer )
            value.StateFormat                               = GetString(new IntPtr(p + 0x018)); // 0x18 StateFormat                 ( ModelPrimitiveType string string string String )
            value.CommonUsages                              = GetStringList(new IntPtr(p + 0x020)); // 0x20 CommonUsages                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Variants                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Variants                    ( ModelPrimitiveType string string string String )
            value.IsNoisy                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 IsNoisy                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsGenericTypeOfDevice                     = GetBool(new IntPtr(p + 0x035)); // 0x35 IsGenericTypeOfDevice       ( ModelPrimitiveType bool bool bool Bool )
            value.DisplayName                               = GetString(new IntPtr(p + 0x038)); // 0x38 DisplayName                 ( ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x040)); // 0x40 Description                 ( ModelPrimitiveType string string string String )
            value.HideInUI                                  = GetBool(new IntPtr(p + 0x048)); // 0x48 HideInUI                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
