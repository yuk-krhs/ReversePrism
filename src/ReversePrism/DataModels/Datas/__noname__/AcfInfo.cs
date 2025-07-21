using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Size                                     ModelPrimitiveType uint uint uint UInt32
    // 01C Version                                  ModelPrimitiveType uint uint uint UInt32
    // 020 CharacterEncoding                        ModelEnumType CharacterEncoding CharacterEncoding CharacterEncoding Int32
    // 024 NumDspSettings                           ModelPrimitiveType int int int Int32
    // 028 NumCategories                            ModelPrimitiveType int int int Int32
    // 02C NumCategoriesPerPlayback                 ModelPrimitiveType int int int Int32
    // 030 NumReacts                                ModelPrimitiveType int int int Int32
    // 034 NumAisacControls                         ModelPrimitiveType int int int Int32
    // 038 NumGlobalAisacs                          ModelPrimitiveType int int int Int32
    // 03C NumGameVariables                         ModelPrimitiveType int int int Int32
    // 040 MaxBusesOfDspBusSettings                 ModelPrimitiveType int int int Int32
    // 044 NumBuses                                 ModelPrimitiveType int int int Int32
    // 048 NumVoiceLimitGroups                      ModelPrimitiveType int int int Int32
    // 04C NumOutputPorts                           ModelPrimitiveType int int int Int32
    public partial class AcfInfo : DataModel
    {
        public string                                   Name                                    { get; set; }
        public uint                                     Size                                    { get; set; }
        public uint                                     Version                                 { get; set; }
        public CharacterEncoding                        CharacterEncoding                       { get; set; }
        public int                                      NumDspSettings                          { get; set; }
        public int                                      NumCategories                           { get; set; }
        public int                                      NumCategoriesPerPlayback                { get; set; }
        public int                                      NumReacts                               { get; set; }
        public int                                      NumAisacControls                        { get; set; }
        public int                                      NumGlobalAisacs                         { get; set; }
        public int                                      NumGameVariables                        { get; set; }
        public int                                      MaxBusesOfDspBusSettings                { get; set; }
        public int                                      NumBuses                                { get; set; }
        public int                                      NumVoiceLimitGroups                     { get; set; }
        public int                                      NumOutputPorts                          { get; set; }

        public static AcfInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AcfInfo() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Size                        ( ModelPrimitiveType uint uint uint UInt32 )
            value.Version                                   = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Version                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.CharacterEncoding                         = (CharacterEncoding)GetInt32(new IntPtr(p + 0x020)); // 0x20 CharacterEncoding           ( ModelEnumType CharacterEncoding CharacterEncoding CharacterEncoding Int32 )
            value.NumDspSettings                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 NumDspSettings              ( ModelPrimitiveType int int int Int32 )
            value.NumCategories                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 NumCategories               ( ModelPrimitiveType int int int Int32 )
            value.NumCategoriesPerPlayback                  = GetInt32(new IntPtr(p + 0x02C)); // 0x2C NumCategoriesPerPlayback    ( ModelPrimitiveType int int int Int32 )
            value.NumReacts                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 NumReacts                   ( ModelPrimitiveType int int int Int32 )
            value.NumAisacControls                          = GetInt32(new IntPtr(p + 0x034)); // 0x34 NumAisacControls            ( ModelPrimitiveType int int int Int32 )
            value.NumGlobalAisacs                           = GetInt32(new IntPtr(p + 0x038)); // 0x38 NumGlobalAisacs             ( ModelPrimitiveType int int int Int32 )
            value.NumGameVariables                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C NumGameVariables            ( ModelPrimitiveType int int int Int32 )
            value.MaxBusesOfDspBusSettings                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxBusesOfDspBusSettings    ( ModelPrimitiveType int int int Int32 )
            value.NumBuses                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 NumBuses                    ( ModelPrimitiveType int int int Int32 )
            value.NumVoiceLimitGroups                       = GetInt32(new IntPtr(p + 0x048)); // 0x48 NumVoiceLimitGroups         ( ModelPrimitiveType int int int Int32 )
            value.NumOutputPorts                            = GetInt32(new IntPtr(p + 0x04C)); // 0x4C NumOutputPorts              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
