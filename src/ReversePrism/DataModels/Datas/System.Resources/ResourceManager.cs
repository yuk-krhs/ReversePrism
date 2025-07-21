using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseNameField                            ModelPrimitiveType string string string String
    // 018 ResourceSets                             ModelClassType Hashtable Hashtable Hashtable Pointer
    // 020 _resourceSets                            Dictionary`2<string, ResourceSet> IL2CPP_TYPE_GENERICINST
    // 028 ModuleDir                                ModelPrimitiveType string string string String
    // 030 MainAssembly                             ModelClassType Assembly Assembly Assembly Pointer
    // 038 LocationInfo                             ModelClassType Type Type Type Pointer
    // 040 UserResourceSet                          ModelClassType Type Type Type Pointer
    // 048 NeutralResourcesCulture                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 050 LastUsedResourceCache                    ModelClassType CultureNameResourceSetPair CultureNameResourceSetPair CultureNameResourceSetPair Pointer
    // 058 IgnoreCase                               ModelPrimitiveType bool bool bool Bool
    // 059 UseManifest                              ModelPrimitiveType bool bool bool Bool
    // 05A UseSatelliteAssem                        ModelPrimitiveType bool bool bool Bool
    // 05C FallbackLoc                              ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32
    // 060 SatelliteContractVersion                 ModelClassType Version Version Version Pointer
    // 068 LookedForSatelliteContractVersion        ModelPrimitiveType bool bool bool Bool
    // 070 CallingAssembly                          ModelClassType Assembly Assembly Assembly Pointer
    // 078 M_callingAssembly                        ModelClassType RuntimeAssembly RuntimeAssembly RuntimeAssembly Pointer
    // 080 ResourceGroveler                         ModelClassType IResourceGroveler IResourceGroveler IResourceGroveler Pointer
    // 000 MagicNumber                              int IL2CPP_TYPE_I4
    // 004 HeaderVersionNumber                      int IL2CPP_TYPE_I4
    // 008 _minResourceSet                          Type IL2CPP_TYPE_CLASS
    // 010 ResReaderTypeName                        ModelPrimitiveType string string string String
    // 018 ResSetTypeName                           ModelPrimitiveType string string string String
    // 020 MscorlibName                             ModelPrimitiveType string string string String
    // 028 DEBUG                                    ModelPrimitiveType int int int Int32
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

            value.BaseNameField                             = GetString(new IntPtr(p + 0x010)); // 0x10 BaseNameField               ( ModelPrimitiveType string string string String )
            value.ResourceSets                              = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0x18 ResourceSets                ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ModuleDir                                 = GetString(new IntPtr(p + 0x028)); // 0x28 ModuleDir                   ( ModelPrimitiveType string string string String )
            value.MainAssembly                              = GetObject<Assembly>(new IntPtr(p + 0x030), ReversePrism.DataModels.Assembly.FromPointer); // 0x30 MainAssembly                ( ModelClassType Assembly Assembly Assembly Pointer )
            value.LocationInfo                              = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 LocationInfo                ( ModelClassType Type Type Type Pointer )
            value.UserResourceSet                           = GetObject<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 UserResourceSet             ( ModelClassType Type Type Type Pointer )
            value.NeutralResourcesCulture                   = GetObject<CultureInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x48 NeutralResourcesCulture     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.LastUsedResourceCache                     = GetObject<CultureNameResourceSetPair>(new IntPtr(p + 0x050), ReversePrism.DataModels.CultureNameResourceSetPair.FromPointer); // 0x50 LastUsedResourceCache       ( ModelClassType CultureNameResourceSetPair CultureNameResourceSetPair CultureNameResourceSetPair Pointer )
            value.IgnoreCase                                = GetBool(new IntPtr(p + 0x058)); // 0x58 IgnoreCase                  ( ModelPrimitiveType bool bool bool Bool )
            value.UseManifest                               = GetBool(new IntPtr(p + 0x059)); // 0x59 UseManifest                 ( ModelPrimitiveType bool bool bool Bool )
            value.UseSatelliteAssem                         = GetBool(new IntPtr(p + 0x05A)); // 0x5A UseSatelliteAssem           ( ModelPrimitiveType bool bool bool Bool )
            value.FallbackLoc                               = (UltimateResourceFallbackLocation)GetInt32(new IntPtr(p + 0x05C)); // 0x5C FallbackLoc                 ( ModelEnumType UltimateResourceFallbackLocation UltimateResourceFallbackLocation UltimateResourceFallbackLocation Int32 )
            value.SatelliteContractVersion                  = GetObject<Version>(new IntPtr(p + 0x060), ReversePrism.DataModels.Version.FromPointer); // 0x60 SatelliteContractVersion    ( ModelClassType Version Version Version Pointer )
            value.LookedForSatelliteContractVersion         = GetBool(new IntPtr(p + 0x068)); // 0x68 LookedForSatelliteContractVersion ( ModelPrimitiveType bool bool bool Bool )
            value.CallingAssembly                           = GetObject<Assembly>(new IntPtr(p + 0x070), ReversePrism.DataModels.Assembly.FromPointer); // 0x70 CallingAssembly             ( ModelClassType Assembly Assembly Assembly Pointer )
            value.M_callingAssembly                         = GetObject<RuntimeAssembly>(new IntPtr(p + 0x078), ReversePrism.DataModels.RuntimeAssembly.FromPointer); // 0x78 M_callingAssembly           ( ModelClassType RuntimeAssembly RuntimeAssembly RuntimeAssembly Pointer )
            value.ResourceGroveler                          = GetObject<IResourceGroveler>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceGroveler.FromPointer); // 0x80 ResourceGroveler            ( ModelClassType IResourceGroveler IResourceGroveler IResourceGroveler Pointer )
            value.ResReaderTypeName                         = GetString(new IntPtr(p + 0x010)); // 0x10 ResReaderTypeName           ( ModelPrimitiveType string string string String )
            value.ResSetTypeName                            = GetString(new IntPtr(p + 0x018)); // 0x18 ResSetTypeName              ( ModelPrimitiveType string string string String )
            value.MscorlibName                              = GetString(new IntPtr(p + 0x020)); // 0x20 MscorlibName                ( ModelPrimitiveType string string string String )
            value.DEBUG                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 DEBUG                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
