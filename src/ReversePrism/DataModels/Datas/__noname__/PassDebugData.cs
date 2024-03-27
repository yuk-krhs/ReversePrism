using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 resourceReadLists                        List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 020 resourceWriteLists                       List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 028 Culled                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 029 Async                                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 02C SyncToPassIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 SyncFromPassIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 GenerateDebugData                        000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class PassDebugData
    {
        public string                                   Name                                    { get; set; }
        public bool                                     Culled                                  { get; set; }
        public bool                                     Async                                   { get; set; }
        public int                                      SyncToPassIndex                         { get; set; }
        public int                                      SyncFromPassIndex                       { get; set; }
        public bool                                     GenerateDebugData                       { get; set; }

        public static PassDebugData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PassDebugData();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D907B9B0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Culled                                    = GetBool(new IntPtr(p + 0x028)); // 0270D907BA10 0x28 Culled                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Async                                     = GetBool(new IntPtr(p + 0x029)); // 0270D907BA30 0x29 Async                       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SyncToPassIndex                           = GetInt32(new IntPtr(p + 0x02C)); // 0270D907BA50 0x2C SyncToPassIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SyncFromPassIndex                         = GetInt32(new IntPtr(p + 0x030)); // 0270D907BA70 0x30 SyncFromPassIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.GenerateDebugData                         = GetBool(new IntPtr(p + 0x034)); // 0270D907BA90 0x34 GenerateDebugData           ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
