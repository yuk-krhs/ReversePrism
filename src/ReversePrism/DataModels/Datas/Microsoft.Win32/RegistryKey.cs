using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HKEY_CLASSES_ROOT                        <int> IL2CPP_TYPE_I
    // 008 HKEY_CURRENT_USER                        <int> IL2CPP_TYPE_I
    // 010 HKEY_LOCAL_MACHINE                       <int> IL2CPP_TYPE_I
    // 018 HKEY_USERS                               <int> IL2CPP_TYPE_I
    // 020 HKEY_PERFORMANCE_DATA                    <int> IL2CPP_TYPE_I
    // 028 HKEY_CURRENT_CONFIG                      <int> IL2CPP_TYPE_I
    // 030 HKEY_DYN_DATA                            <int> IL2CPP_TYPE_I
    // 038 S_hkeyNames                              000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 Hkey                                     00018665F020 ModelClassType SafeRegistryHandle SafeRegistryHandle SafeRegistryHandle Pointer
    // 020 KeyName                                  000186671910 ModelPrimitiveType string string string String
    // 028 RemoteKey                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C State                                    0001866C5310 ModelEnumType StateFlags StateFlags StateFlags Int32
    // 030 CheckMode                                000186646390 ModelEnumType RegistryKeyPermissionCheck RegistryKeyPermissionCheck RegistryKeyPermissionCheck Int32
    // 034 RegView                                  000186646FC0 ModelEnumType RegistryView RegistryView RegistryView Int32
    public partial class RegistryKey : DataModel
    {
        public List<string>?                            S_hkeyNames                             { get; set; }
        public SafeRegistryHandle?                      Hkey                                    { get; set; }
        public string                                   KeyName                                 { get; set; }
        public bool                                     RemoteKey                               { get; set; }
        public StateFlags                               State                                   { get; set; }
        public RegistryKeyPermissionCheck               CheckMode                               { get; set; }
        public RegistryView                             RegView                                 { get; set; }

        public static RegistryKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegistryKey() { Pointer= p0 };

            value.S_hkeyNames                               = GetStringList(new IntPtr(p + 0x038)); // 024662FD8B98 0x38 S_hkeyNames                 ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Hkey                                      = GetObject<SafeRegistryHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.SafeRegistryHandle.FromPointer); // 024662FD8BB8 0x18 Hkey                        ( 00018665F020 ModelClassType SafeRegistryHandle SafeRegistryHandle SafeRegistryHandle Pointer )
            value.KeyName                                   = GetString(new IntPtr(p + 0x020)); // 024662FD8BD8 0x20 KeyName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.RemoteKey                                 = GetBool(new IntPtr(p + 0x028)); // 024662FD8BF8 0x28 RemoteKey                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.State                                     = (StateFlags)GetInt32(new IntPtr(p + 0x02C)); // 024662FD8C18 0x2C State                       ( 0001866C5310 ModelEnumType StateFlags StateFlags StateFlags Int32 )
            value.CheckMode                                 = (RegistryKeyPermissionCheck)GetInt32(new IntPtr(p + 0x030)); // 024662FD8C38 0x30 CheckMode                   ( 000186646390 ModelEnumType RegistryKeyPermissionCheck RegistryKeyPermissionCheck RegistryKeyPermissionCheck Int32 )
            value.RegView                                   = (RegistryView)GetInt32(new IntPtr(p + 0x034)); // 024662FD8C58 0x34 RegView                     ( 000186646FC0 ModelEnumType RegistryView RegistryView RegistryView Int32 )

            return value;
        }
    }
}
