using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Codebase                                 ModelPrimitiveType string string string String
    // 020 Major                                    ModelPrimitiveType int int int Int32
    // 024 Minor                                    ModelPrimitiveType int int int Int32
    // 028 Build                                    ModelPrimitiveType int int int Int32
    // 02C Revision                                 ModelPrimitiveType int int int Int32
    // 030 Cultureinfo                              ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 038 Flags                                    ModelEnumType AssemblyNameFlags AssemblyNameFlags AssemblyNameFlags Int32
    // 03C Hashalg                                  ModelEnumType AssemblyHashAlgorithm AssemblyHashAlgorithm AssemblyHashAlgorithm Int32
    // 040 Keypair                                  ModelClassType StrongNameKeyPair StrongNameKeyPair StrongNameKeyPair Pointer
    // 048 PublicKey                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 050 KeyToken                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 Versioncompat                            ModelEnumType AssemblyVersionCompatibility AssemblyVersionCompatibility AssemblyVersionCompatibility Int32
    // 060 Version                                  ModelClassType Version Version Version Pointer
    // 068 Processor_architecture                   ModelEnumType ProcessorArchitecture ProcessorArchitecture ProcessorArchitecture Int32
    // 06C ContentType                              ModelEnumType AssemblyContentType AssemblyContentType AssemblyContentType Int32
    public partial class AssemblyName : DataModel
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
            var value   = new AssemblyName() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Codebase                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Codebase                    ( ModelPrimitiveType string string string String )
            value.Major                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Major                       ( ModelPrimitiveType int int int Int32 )
            value.Minor                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Minor                       ( ModelPrimitiveType int int int Int32 )
            value.Build                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Build                       ( ModelPrimitiveType int int int Int32 )
            value.Revision                                  = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Revision                    ( ModelPrimitiveType int int int Int32 )
            value.Cultureinfo                               = GetObject<CultureInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x30 Cultureinfo                 ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Flags                                     = (AssemblyNameFlags)GetInt32(new IntPtr(p + 0x038)); // 0x38 Flags                       ( ModelEnumType AssemblyNameFlags AssemblyNameFlags AssemblyNameFlags Int32 )
            value.Hashalg                                   = (AssemblyHashAlgorithm)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Hashalg                     ( ModelEnumType AssemblyHashAlgorithm AssemblyHashAlgorithm AssemblyHashAlgorithm Int32 )
            value.Keypair                                   = GetObject<StrongNameKeyPair>(new IntPtr(p + 0x040), ReversePrism.DataModels.StrongNameKeyPair.FromPointer); // 0x40 Keypair                     ( ModelClassType StrongNameKeyPair StrongNameKeyPair StrongNameKeyPair Pointer )
            value.PublicKey                                 = GetSByteList(new IntPtr(p + 0x048)); // 0x48 PublicKey                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.KeyToken                                  = GetSByteList(new IntPtr(p + 0x050)); // 0x50 KeyToken                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Versioncompat                             = (AssemblyVersionCompatibility)GetInt32(new IntPtr(p + 0x058)); // 0x58 Versioncompat               ( ModelEnumType AssemblyVersionCompatibility AssemblyVersionCompatibility AssemblyVersionCompatibility Int32 )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x060), ReversePrism.DataModels.Version.FromPointer); // 0x60 Version                     ( ModelClassType Version Version Version Pointer )
            value.Processor_architecture                    = (ProcessorArchitecture)GetInt32(new IntPtr(p + 0x068)); // 0x68 Processor_architecture      ( ModelEnumType ProcessorArchitecture ProcessorArchitecture ProcessorArchitecture Int32 )
            value.ContentType                               = (AssemblyContentType)GetInt32(new IntPtr(p + 0x06C)); // 0x6C ContentType                 ( ModelEnumType AssemblyContentType AssemblyContentType AssemblyContentType Int32 )

            return value;
        }
    }
}
