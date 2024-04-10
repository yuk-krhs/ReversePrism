using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseNameField                            000186671E00 ModelPrimitiveType string string string String
    // 018 ResourceSets                             0001865DE820 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 _resourceSets                            Dictionary`2<string, ResourceSet> IL2CPP_TYPE_GENERICINST
    // 028 ModuleDir                                000186671910 ModelPrimitiveType string string string String
    // 030 MainAssembly                             00018658B420 ModelClassType Assembly Assembly Assembly Pointer
    // 038 LocationInfo                             000186692850 ModelClassType Type Type Type Pointer
    // 040 UserResourceSet                          000186692850 ModelClassType Type Type Type Pointer
    // 048 NeutralResourcesCulture                  0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 050 LastUsedResourceCache                    0001866D7520 ModelClassType CultureNameResourceSetPair CultureNameResourceSetPair CultureNameResourceSetPair Pointer
    // 058 IgnoreCase                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 UseManifest                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05A UseSatelliteAssem                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C FallbackLoc                              00018669EF50 ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32
    // 060 SatelliteContractVersion                 0001866B0CC0 ModelClassType Version Version Version Pointer
    // 068 LookedForSatelliteContractVersion        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 CallingAssembly                          00018658AEE0 ModelClassType Assembly Assembly Assembly Pointer
    // 078 M_callingAssembly                        000186696430 ModelClassType RuntimeAssembly RuntimeAssembly RuntimeAssembly Pointer
    // 080 ResourceGroveler                         00018661A400 ModelClassType IResourceGroveler IResourceGroveler IResourceGroveler Pointer
    // 000 MagicNumber                              int IL2CPP_TYPE_I4
    // 004 HeaderVersionNumber                      int IL2CPP_TYPE_I4
    // 008 _minResourceSet                          Type IL2CPP_TYPE_CLASS
    // 010 ResReaderTypeName                        000186673B80 ModelPrimitiveType string string string String
    // 018 ResSetTypeName                           000186673B80 ModelPrimitiveType string string string String
    // 020 MscorlibName                             000186673B80 ModelPrimitiveType string string string String
    // 028 DEBUG                                    0001865F4E00 ModelPrimitiveType int int int Int32
    public partial class ResourceManager : DataModel
    {
        public string                                   BaseNameField                           { get; set; }
        public Hashtable?                               ResourceSets                            { get; set; }
        public string                                   ModuleDir                               { get; set; }
        public Assembly?                                MainAssembly                            { get; set; }
        public Type?                                    LocationInfo                            { get; set; }
        public Type?                                    UserResourceSet                         { get; set; }
        public CultureInfo?                             NeutralResourcesCulture                 { get; set; }
        public CultureNameResourceSetPair?              LastUsedResourceCache                   { get; set; }
        public bool                                     IgnoreCase                              { get; set; }
        public bool                                     UseManifest                             { get; set; }
        public bool                                     UseSatelliteAssem                       { get; set; }
        public UltimateResourceFallbackLocation         FallbackLoc                             { get; set; }
        public Version?                                 SatelliteContractVersion                { get; set; }
        public bool                                     LookedForSatelliteContractVersion       { get; set; }
        public Assembly?                                CallingAssembly                         { get; set; }
        public RuntimeAssembly?                         M_callingAssembly                       { get; set; }
        public IResourceGroveler?                       ResourceGroveler                        { get; set; }
        public string                                   ResReaderTypeName                       { get; set; }
        public string                                   ResSetTypeName                          { get; set; }
        public string                                   MscorlibName                            { get; set; }
        public int                                      DEBUG                                   { get; set; }

        public static ResourceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceManager() { Pointer= p0 };

            value.BaseNameField                             = GetString(new IntPtr(p + 0x010)); // 024666D29FA0 0x10 BaseNameField               ( 000186671E00 ModelPrimitiveType string string string String )
            value.ResourceSets                              = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 024666D29FC0 0x18 ResourceSets                ( 0001865DE820 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ModuleDir                                 = GetString(new IntPtr(p + 0x028)); // 024666D2A000 0x28 ModuleDir                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MainAssembly                              = GetObject<Assembly>(new IntPtr(p + 0x030), ReversePrism.DataModels.Assembly.FromPointer); // 024666D2A020 0x30 MainAssembly                ( 00018658B420 ModelClassType Assembly Assembly Assembly Pointer )
            value.LocationInfo                              = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 024666D2A040 0x38 LocationInfo                ( 000186692850 ModelClassType Type Type Type Pointer )
            value.UserResourceSet                           = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 024666D2A060 0x40 UserResourceSet             ( 000186692850 ModelClassType Type Type Type Pointer )
            value.NeutralResourcesCulture                   = GetObject<CultureInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.CultureInfo.FromPointer); // 024666D2A080 0x48 NeutralResourcesCulture     ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.LastUsedResourceCache                     = GetObject<CultureNameResourceSetPair>(new IntPtr(p + 0x050), ReversePrism.DataModels.CultureNameResourceSetPair.FromPointer); // 024666D2A0A0 0x50 LastUsedResourceCache       ( 0001866D7520 ModelClassType CultureNameResourceSetPair CultureNameResourceSetPair CultureNameResourceSetPair Pointer )
            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x058)); // 024666D2A0C0 0x58 IgnoreCase                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseManifest                               = GetBool(new IntPtr(p + 0x059)); // 024666D2A0E0 0x59 UseManifest                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseSatelliteAssem                         = GetBool(new IntPtr(p + 0x05A)); // 024666D2A100 0x5A UseSatelliteAssem           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FallbackLoc                               = (UltimateResourceFallbackLocation)GetInt32(new IntPtr(p + 0x05C)); // 024666D2A120 0x5C FallbackLoc                 ( 00018669EF50 ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32 )
            value.SatelliteContractVersion                  = GetObject<Version>(new IntPtr(p + 0x060), ReversePrism.DataModels.Version.FromPointer); // 024666D2A140 0x60 SatelliteContractVersion    ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.LookedForSatelliteContractVersion         = GetBool(new IntPtr(p + 0x068)); // 024666D2A160 0x68 LookedForSatelliteContractVersion ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CallingAssembly                           = GetObject<Assembly>(new IntPtr(p + 0x070), ReversePrism.DataModels.Assembly.FromPointer); // 024666D2A180 0x70 CallingAssembly             ( 00018658AEE0 ModelClassType Assembly Assembly Assembly Pointer )
            value.M_callingAssembly                         = GetObject<RuntimeAssembly>(new IntPtr(p + 0x078), ReversePrism.DataModels.RuntimeAssembly.FromPointer); // 024666D2A1A0 0x78 M_callingAssembly           ( 000186696430 ModelClassType RuntimeAssembly RuntimeAssembly RuntimeAssembly Pointer )
            value.ResourceGroveler                          = GetObject<IResourceGroveler>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceGroveler.FromPointer); // 024666D2A1C0 0x80 ResourceGroveler            ( 00018661A400 ModelClassType IResourceGroveler IResourceGroveler IResourceGroveler Pointer )
            value.ResReaderTypeName                         = GetString(new IntPtr(p + 0x010)); // 024666D2A240 0x10 ResReaderTypeName           ( 000186673B80 ModelPrimitiveType string string string String )
            value.ResSetTypeName                            = GetString(new IntPtr(p + 0x018)); // 024666D2A260 0x18 ResSetTypeName              ( 000186673B80 ModelPrimitiveType string string string String )
            value.MscorlibName                              = GetString(new IntPtr(p + 0x020)); // 024666D2A280 0x20 MscorlibName                ( 000186673B80 ModelPrimitiveType string string string String )
            value.DEBUG                                     = GetInt32(new IntPtr(p + 0x028)); // 024666D2A2A0 0x28 DEBUG                       ( 0001865F4E00 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
