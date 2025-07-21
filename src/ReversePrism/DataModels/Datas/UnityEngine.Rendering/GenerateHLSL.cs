using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PackingRules                             ModelEnumType PackingRules PackingRules PackingRules Int32
    // 014 ContainsPackedFields                     ModelPrimitiveType bool bool bool Bool
    // 015 NeedAccessors                            ModelPrimitiveType bool bool bool Bool
    // 016 NeedSetters                              ModelPrimitiveType bool bool bool Bool
    // 017 NeedParamDebug                           ModelPrimitiveType bool bool bool Bool
    // 018 ParamDefinesStart                        ModelPrimitiveType int int int Int32
    // 01C OmitStructDeclaration                    ModelPrimitiveType bool bool bool Bool
    // 01D GenerateCBuffer                          ModelPrimitiveType bool bool bool Bool
    // 020 ConstantRegister                         ModelPrimitiveType int int int Int32
    // 028 SourcePath                               ModelPrimitiveType string string string String
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

            value.PackingRules                              = (PackingRules)GetInt32(new IntPtr(p + 0x010)); // 0x10 PackingRules                ( ModelEnumType PackingRules PackingRules PackingRules Int32 )
            value.ContainsPackedFields                      = GetBool(new IntPtr(p + 0x014)); // 0x14 ContainsPackedFields        ( ModelPrimitiveType bool bool bool Bool )
            value.NeedAccessors                             = GetBool(new IntPtr(p + 0x015)); // 0x15 NeedAccessors               ( ModelPrimitiveType bool bool bool Bool )
            value.NeedSetters                               = GetBool(new IntPtr(p + 0x016)); // 0x16 NeedSetters                 ( ModelPrimitiveType bool bool bool Bool )
            value.NeedParamDebug                            = GetBool(new IntPtr(p + 0x017)); // 0x17 NeedParamDebug              ( ModelPrimitiveType bool bool bool Bool )
            value.ParamDefinesStart                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 ParamDefinesStart           ( ModelPrimitiveType int int int Int32 )
            value.OmitStructDeclaration                     = GetBool(new IntPtr(p + 0x01C)); // 0x1C OmitStructDeclaration       ( ModelPrimitiveType bool bool bool Bool )
            value.GenerateCBuffer                           = GetBool(new IntPtr(p + 0x01D)); // 0x1D GenerateCBuffer             ( ModelPrimitiveType bool bool bool Bool )
            value.ConstantRegister                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 ConstantRegister            ( ModelPrimitiveType int int int Int32 )
            value.SourcePath                                = GetString(new IntPtr(p + 0x028)); // 0x28 SourcePath                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
