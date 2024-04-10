using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Application_base                         000186671910 ModelPrimitiveType string string string String
    // 018 Application_name                         000186671910 ModelPrimitiveType string string string String
    // 020 Cache_path                               000186671910 ModelPrimitiveType string string string String
    // 028 Configuration_file                       000186671910 ModelPrimitiveType string string string String
    // 030 Dynamic_base                             000186671910 ModelPrimitiveType string string string String
    // 038 License_file                             000186671910 ModelPrimitiveType string string string String
    // 040 Private_bin_path                         000186671910 ModelPrimitiveType string string string String
    // 048 Private_bin_path_probe                   000186671910 ModelPrimitiveType string string string String
    // 050 Shadow_copy_directories                  000186671910 ModelPrimitiveType string string string String
    // 058 Shadow_copy_files                        000186671910 ModelPrimitiveType string string string String
    // 060 Publisher_policy                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 Path_changed                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 064 Loader_optimization                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 Disallow_binding_redirects               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 Disallow_code_downloads                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 _activationArguments                     <object> IL2CPP_TYPE_OBJECT
    // 078 domain_initializer                       <object> IL2CPP_TYPE_OBJECT
    // 080 application_trust                        <object> IL2CPP_TYPE_OBJECT
    // 088 Domain_initializer_args                  000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 090 Disallow_appbase_probe                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 Configuration_bytes                      000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0A0 Serialized_non_primitives                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0A8 Manager_assembly                         000186671910 ModelPrimitiveType string string string String
    // 0B0 Manager_type                             000186671910 ModelPrimitiveType string string string String
    // 0B8 Partial_visible_assemblies               000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0C0 TargetFrameworkName                      000186671910 ModelPrimitiveType string string string String
    public partial class AppDomainSetup : DataModel
    {
        public string                                   Application_base                        { get; set; }
        public string                                   Application_name                        { get; set; }
        public string                                   Cache_path                              { get; set; }
        public string                                   Configuration_file                      { get; set; }
        public string                                   Dynamic_base                            { get; set; }
        public string                                   License_file                            { get; set; }
        public string                                   Private_bin_path                        { get; set; }
        public string                                   Private_bin_path_probe                  { get; set; }
        public string                                   Shadow_copy_directories                 { get; set; }
        public string                                   Shadow_copy_files                       { get; set; }
        public bool                                     Publisher_policy                        { get; set; }
        public bool                                     Path_changed                            { get; set; }
        public int                                      Loader_optimization                     { get; set; }
        public bool                                     Disallow_binding_redirects              { get; set; }
        public bool                                     Disallow_code_downloads                 { get; set; }
        public List<string>?                            Domain_initializer_args                 { get; set; }
        public bool                                     Disallow_appbase_probe                  { get; set; }
        public List<sbyte>?                             Configuration_bytes                     { get; set; }
        public List<sbyte>?                             Serialized_non_primitives               { get; set; }
        public string                                   Manager_assembly                        { get; set; }
        public string                                   Manager_type                            { get; set; }
        public List<string>?                            Partial_visible_assemblies              { get; set; }
        public string                                   TargetFrameworkName                     { get; set; }

        public static AppDomainSetup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppDomainSetup() { Pointer= p0 };

            value.Application_base                          = GetString(new IntPtr(p + 0x010)); // 0245A028C0E0 0x10 Application_base            ( 000186671910 ModelPrimitiveType string string string String )
            value.Application_name                          = GetString(new IntPtr(p + 0x018)); // 0245A028C100 0x18 Application_name            ( 000186671910 ModelPrimitiveType string string string String )
            value.Cache_path                                = GetString(new IntPtr(p + 0x020)); // 0245A028C120 0x20 Cache_path                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Configuration_file                        = GetString(new IntPtr(p + 0x028)); // 0245A028C140 0x28 Configuration_file          ( 000186671910 ModelPrimitiveType string string string String )
            value.Dynamic_base                              = GetString(new IntPtr(p + 0x030)); // 0245A028C160 0x30 Dynamic_base                ( 000186671910 ModelPrimitiveType string string string String )
            value.License_file                              = GetString(new IntPtr(p + 0x038)); // 0245A028C180 0x38 License_file                ( 000186671910 ModelPrimitiveType string string string String )
            value.Private_bin_path                          = GetString(new IntPtr(p + 0x040)); // 0245A028C1A0 0x40 Private_bin_path            ( 000186671910 ModelPrimitiveType string string string String )
            value.Private_bin_path_probe                    = GetString(new IntPtr(p + 0x048)); // 0245A028C1C0 0x48 Private_bin_path_probe      ( 000186671910 ModelPrimitiveType string string string String )
            value.Shadow_copy_directories                   = GetString(new IntPtr(p + 0x050)); // 0245A028C1E0 0x50 Shadow_copy_directories     ( 000186671910 ModelPrimitiveType string string string String )
            value.Shadow_copy_files                         = GetString(new IntPtr(p + 0x058)); // 0245A028C200 0x58 Shadow_copy_files           ( 000186671910 ModelPrimitiveType string string string String )
            value.Publisher_policy                          = GetBool(new IntPtr(p + 0x060)); // 0245A028C220 0x60 Publisher_policy            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Path_changed                              = GetBool(new IntPtr(p + 0x061)); // 0245A028C240 0x61 Path_changed                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Loader_optimization                       = GetInt32(new IntPtr(p + 0x064)); // 0245A028C260 0x64 Loader_optimization         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disallow_binding_redirects                = GetBool(new IntPtr(p + 0x068)); // 0245A028C280 0x68 Disallow_binding_redirects  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disallow_code_downloads                   = GetBool(new IntPtr(p + 0x069)); // 0245A028C2A0 0x69 Disallow_code_downloads     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Domain_initializer_args                   = GetStringList(new IntPtr(p + 0x088)); // 0245A028C320 0x88 Domain_initializer_args     ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Disallow_appbase_probe                    = GetBool(new IntPtr(p + 0x090)); // 0245A028C340 0x90 Disallow_appbase_probe      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Configuration_bytes                       = GetSByteList(new IntPtr(p + 0x098)); // 0245A028C360 0x98 Configuration_bytes         ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Serialized_non_primitives                 = GetSByteList(new IntPtr(p + 0x0A0)); // 0245A028C380 0xA0 Serialized_non_primitives   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Manager_assembly                          = GetString(new IntPtr(p + 0x0A8)); // 0245A028C3A0 0xA8 Manager_assembly            ( 000186671910 ModelPrimitiveType string string string String )
            value.Manager_type                              = GetString(new IntPtr(p + 0x0B0)); // 0245A028C3C0 0xB0 Manager_type                ( 000186671910 ModelPrimitiveType string string string String )
            value.Partial_visible_assemblies                = GetStringList(new IntPtr(p + 0x0B8)); // 0245A028C3E0 0xB8 Partial_visible_assemblies  ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TargetFrameworkName                       = GetString(new IntPtr(p + 0x0C0)); // 0245A028C400 0xC0 TargetFrameworkName         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
