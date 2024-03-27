using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Codebase                                 000186671910 ModelPrimitiveType string string string String
    // 020 Major                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Minor                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Build                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C Revision                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Cultureinfo                              0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 038 Flags                                    0001866E12B0 ModelEnumType AssemblyNameFlags AssemblyNameFlags AssemblyNameFlags Int32
    // 03C Hashalg                                  0001866DF770 ModelEnumType AssemblyHashAlgorithm AssemblyHashAlgorithm AssemblyHashAlgorithm Int32
    // 040 Keypair                                  0001865C4A50 ModelClassType StrongNameKeyPair StrongNameKeyPair StrongNameKeyPair Pointer
    // 048 PublicKey                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 KeyToken                                 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Versioncompat                            0001866E2610 ModelEnumType AssemblyVersionCompatibility AssemblyVersionCompatibility AssemblyVersionCompatibility Int32
    // 060 Version                                  0001866B0CC0 ModelClassType Version Version Version Pointer
    // 068 Processor_architecture                   000186525F00 ModelEnumType ProcessorArchitecture ProcessorArchitecture ProcessorArchitecture Int32
    // 06C ContentType                              0001866DE1C0 ModelEnumType AssemblyContentType AssemblyContentType AssemblyContentType Int32
    public partial class AssemblyName
    {
        public string                                   Name                                    { get; set; }
        public string                                   Codebase                                { get; set; }
        public int                                      Major                                   { get; set; }
        public int                                      Minor                                   { get; set; }
        public int                                      Build                                   { get; set; }
        public int                                      Revision                                { get; set; }
        public CultureInfo?                             Cultureinfo                             { get; set; }
        public AssemblyNameFlags                        Flags                                   { get; set; }
        public AssemblyHashAlgorithm                    Hashalg                                 { get; set; }
        public StrongNameKeyPair?                       Keypair                                 { get; set; }
        public List<sbyte>?                             PublicKey                               { get; set; }
        public List<sbyte>?                             KeyToken                                { get; set; }
        public AssemblyVersionCompatibility             Versioncompat                           { get; set; }
        public Version?                                 Version                                 { get; set; }
        public ProcessorArchitecture                    Processor_architecture                  { get; set; }
        public AssemblyContentType                      ContentType                             { get; set; }

        public static AssemblyName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyName();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270040912E0 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Codebase                                  = GetString(new IntPtr(p + 0x018)); // 027004091300 0x18 Codebase                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Major                                     = GetInt32(new IntPtr(p + 0x020)); // 027004091320 0x20 Major                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x024)); // 027004091340 0x24 Minor                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Build                                     = GetInt32(new IntPtr(p + 0x028)); // 027004091360 0x28 Build                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Revision                                  = GetInt32(new IntPtr(p + 0x02C)); // 027004091380 0x2C Revision                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Cultureinfo                               = GetObject<CultureInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.CultureInfo.FromPointer); // 0270040913A0 0x30 Cultureinfo                 ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Flags                                     = (AssemblyNameFlags)GetInt32(new IntPtr(p + 0x038)); // 0270040913C0 0x38 Flags                       ( 0001866E12B0 ModelEnumType AssemblyNameFlags AssemblyNameFlags AssemblyNameFlags Int32 )
            value.Hashalg                                   = (AssemblyHashAlgorithm)GetInt32(new IntPtr(p + 0x03C)); // 0270040913E0 0x3C Hashalg                     ( 0001866DF770 ModelEnumType AssemblyHashAlgorithm AssemblyHashAlgorithm AssemblyHashAlgorithm Int32 )
            value.Keypair                                   = GetObject<StrongNameKeyPair>(new IntPtr(p + 0x040), ReversePrism.DataModels.StrongNameKeyPair.FromPointer); // 027004091400 0x40 Keypair                     ( 0001865C4A50 ModelClassType StrongNameKeyPair StrongNameKeyPair StrongNameKeyPair Pointer )
            value.PublicKey                                 = GetSByteList(new IntPtr(p + 0x048)); // 027004091420 0x48 PublicKey                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyToken                                  = GetSByteList(new IntPtr(p + 0x050)); // 027004091440 0x50 KeyToken                    ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Versioncompat                             = (AssemblyVersionCompatibility)GetInt32(new IntPtr(p + 0x058)); // 027004091460 0x58 Versioncompat               ( 0001866E2610 ModelEnumType AssemblyVersionCompatibility AssemblyVersionCompatibility AssemblyVersionCompatibility Int32 )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x060), ReversePrism.DataModels.Version.FromPointer); // 027004091480 0x60 Version                     ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.Processor_architecture                    = (ProcessorArchitecture)GetInt32(new IntPtr(p + 0x068)); // 0270040914A0 0x68 Processor_architecture      ( 000186525F00 ModelEnumType ProcessorArchitecture ProcessorArchitecture ProcessorArchitecture Int32 )
            value.ContentType                               = (AssemblyContentType)GetInt32(new IntPtr(p + 0x06C)); // 0270040914C0 0x6C ContentType                 ( 0001866DE1C0 ModelEnumType AssemblyContentType AssemblyContentType AssemblyContentType Int32 )

            return value;
        }
    }
}
