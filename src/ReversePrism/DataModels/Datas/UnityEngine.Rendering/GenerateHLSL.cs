using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PackingRules                             000186712490 ModelEnumType PackingRules PackingRules PackingRules Int32
    // 014 ContainsPackedFields                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 015 NeedAccessors                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 016 NeedSetters                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 017 NeedParamDebug                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ParamDefinesStart                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C OmitStructDeclaration                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 01D GenerateCBuffer                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 ConstantRegister                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 SourcePath                               0001866722E0 ModelPrimitiveType string string string String
    public partial class GenerateHLSL
    {
        public PackingRules                             PackingRules                            { get; set; }
        public bool                                     ContainsPackedFields                    { get; set; }
        public bool                                     NeedAccessors                           { get; set; }
        public bool                                     NeedSetters                             { get; set; }
        public bool                                     NeedParamDebug                          { get; set; }
        public int                                      ParamDefinesStart                       { get; set; }
        public bool                                     OmitStructDeclaration                   { get; set; }
        public bool                                     GenerateCBuffer                         { get; set; }
        public int                                      ConstantRegister                        { get; set; }
        public string                                   SourcePath                              { get; set; }

        public static GenerateHLSL? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GenerateHLSL();

            value.PackingRules                              = (PackingRules)GetInt32(new IntPtr(p + 0x010)); // 0270D925BE48 0x10 PackingRules                ( 000186712490 ModelEnumType PackingRules PackingRules PackingRules Int32 )
            value.ContainsPackedFields                      = GetBool(new IntPtr(p + 0x014)); // 0270D925BE68 0x14 ContainsPackedFields        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedAccessors                             = GetBool(new IntPtr(p + 0x015)); // 0270D925BE88 0x15 NeedAccessors               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedSetters                               = GetBool(new IntPtr(p + 0x016)); // 0270D925BEA8 0x16 NeedSetters                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedParamDebug                            = GetBool(new IntPtr(p + 0x017)); // 0270D925BEC8 0x17 NeedParamDebug              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ParamDefinesStart                         = GetInt32(new IntPtr(p + 0x018)); // 0270D925BEE8 0x18 ParamDefinesStart           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OmitStructDeclaration                     = GetBool(new IntPtr(p + 0x01C)); // 0270D925BF08 0x1C OmitStructDeclaration       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GenerateCBuffer                           = GetBool(new IntPtr(p + 0x01D)); // 0270D925BF28 0x1D GenerateCBuffer             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ConstantRegister                          = GetInt32(new IntPtr(p + 0x020)); // 0270D925BF48 0x20 ConstantRegister            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SourcePath                                = GetString(new IntPtr(p + 0x028)); // 0270D925BF68 0x28 SourcePath                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
