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
    public partial class GenerateHLSL : DataModel
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
            var value   = new GenerateHLSL() { Pointer= p0 };

            value.PackingRules                              = (PackingRules)GetInt32(new IntPtr(p + 0x010)); // 0246692BDBC8 0x10 PackingRules                ( 000186712490 ModelEnumType PackingRules PackingRules PackingRules Int32 )
            value.ContainsPackedFields                      = GetBool(new IntPtr(p + 0x014)); // 0246692BDBE8 0x14 ContainsPackedFields        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedAccessors                             = GetBool(new IntPtr(p + 0x015)); // 0246692BDC08 0x15 NeedAccessors               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedSetters                               = GetBool(new IntPtr(p + 0x016)); // 0246692BDC28 0x16 NeedSetters                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedParamDebug                            = GetBool(new IntPtr(p + 0x017)); // 0246692BDC48 0x17 NeedParamDebug              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ParamDefinesStart                         = GetInt32(new IntPtr(p + 0x018)); // 0246692BDC68 0x18 ParamDefinesStart           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OmitStructDeclaration                     = GetBool(new IntPtr(p + 0x01C)); // 0246692BDC88 0x1C OmitStructDeclaration       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GenerateCBuffer                           = GetBool(new IntPtr(p + 0x01D)); // 0246692BDCA8 0x1D GenerateCBuffer             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ConstantRegister                          = GetInt32(new IntPtr(p + 0x020)); // 0246692BDCC8 0x20 ConstantRegister            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SourcePath                                = GetString(new IntPtr(p + 0x028)); // 0246692BDCE8 0x28 SourcePath                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
