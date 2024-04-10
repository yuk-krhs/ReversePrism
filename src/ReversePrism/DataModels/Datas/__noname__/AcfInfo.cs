using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186674C50 ModelPrimitiveType string string string String
    // 018 Size                                     0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C Version                                  0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 CharacterEncoding                        000186547730 ModelEnumType CharacterEncoding CharacterEncoding CharacterEncoding Int32
    // 024 NumDspSettings                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 NumCategories                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C NumCategoriesPerPlayback                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 NumReacts                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 NumAisacControls                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 NumGlobalAisacs                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C NumGameVariables                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 MaxBusesOfDspBusSettings                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 NumBuses                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 NumVoiceLimitGroups                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C NumOutputPorts                           0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 02466ACDAB48 0x10 Name                        ( 000186674C50 ModelPrimitiveType string string string String )
            value.Size                                      = GetUInt32(new IntPtr(p + 0x018)); // 02466ACDAB68 0x18 Size                        ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Version                                   = GetUInt32(new IntPtr(p + 0x01C)); // 02466ACDAB88 0x1C Version                     ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CharacterEncoding                         = (CharacterEncoding)GetInt32(new IntPtr(p + 0x020)); // 02466ACDABA8 0x20 CharacterEncoding           ( 000186547730 ModelEnumType CharacterEncoding CharacterEncoding CharacterEncoding Int32 )
            value.NumDspSettings                            = GetInt32(new IntPtr(p + 0x024)); // 02466ACDABC8 0x24 NumDspSettings              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumCategories                             = GetInt32(new IntPtr(p + 0x028)); // 02466ACDABE8 0x28 NumCategories               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumCategoriesPerPlayback                  = GetInt32(new IntPtr(p + 0x02C)); // 02466ACDAC08 0x2C NumCategoriesPerPlayback    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumReacts                                 = GetInt32(new IntPtr(p + 0x030)); // 02466ACDAC28 0x30 NumReacts                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumAisacControls                          = GetInt32(new IntPtr(p + 0x034)); // 02466ACDAC48 0x34 NumAisacControls            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumGlobalAisacs                           = GetInt32(new IntPtr(p + 0x038)); // 02466ACDAC68 0x38 NumGlobalAisacs             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumGameVariables                          = GetInt32(new IntPtr(p + 0x03C)); // 02466ACDAC88 0x3C NumGameVariables            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxBusesOfDspBusSettings                  = GetInt32(new IntPtr(p + 0x040)); // 02466ACDACA8 0x40 MaxBusesOfDspBusSettings    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumBuses                                  = GetInt32(new IntPtr(p + 0x044)); // 02466ACDACC8 0x44 NumBuses                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumVoiceLimitGroups                       = GetInt32(new IntPtr(p + 0x048)); // 02466ACDACE8 0x48 NumVoiceLimitGroups         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumOutputPorts                            = GetInt32(new IntPtr(p + 0x04C)); // 02466ACDAD08 0x4C NumOutputPorts              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
