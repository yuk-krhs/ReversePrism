using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StateType                                000186692850 ModelClassType Type Type Type Pointer
    // 018 StateFormat                              000186671910 ModelPrimitiveType string string string String
    // 020 CommonUsages                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Variants                                 000186671910 ModelPrimitiveType string string string String
    // 030 IsNoisy                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 canRunInBackgroundInternal               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 033 updateBeforeRenderInternal               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 035 IsGenericTypeOfDevice                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 040 Description                              000186671910 ModelPrimitiveType string string string String
    // 048 HideInUI                                 000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.StateType                                 = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0246678E1080 0x10 StateType                   ( 000186692850 ModelClassType Type Type Type Pointer )
            value.StateFormat                               = GetString(new IntPtr(p + 0x018)); // 0246678E10A0 0x18 StateFormat                 ( 000186671910 ModelPrimitiveType string string string String )
            value.CommonUsages                              = GetStringList(new IntPtr(p + 0x020)); // 0246678E10C0 0x20 CommonUsages                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Variants                                  = GetString(new IntPtr(p + 0x028)); // 0246678E10E0 0x28 Variants                    ( 000186671910 ModelPrimitiveType string string string String )
            value.IsNoisy                                   = GetBool(new IntPtr(p + 0x030)); // 0246678E1100 0x30 IsNoisy                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsGenericTypeOfDevice                     = GetBool(new IntPtr(p + 0x035)); // 0246678E1160 0x35 IsGenericTypeOfDevice       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DisplayName                               = GetString(new IntPtr(p + 0x038)); // 0246678E1180 0x38 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x040)); // 0246678E11A0 0x40 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.HideInUI                                  = GetBool(new IntPtr(p + 0x048)); // 0246678E11C0 0x48 HideInUI                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
