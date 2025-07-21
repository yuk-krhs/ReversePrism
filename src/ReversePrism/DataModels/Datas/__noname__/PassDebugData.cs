using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 resourceReadLists                        List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 020 resourceWriteLists                       List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 028 Culled                                   ModelPrimitiveType bool bool bool Bool
    // 029 Async                                    ModelPrimitiveType bool bool bool Bool
    // 02C SyncToPassIndex                          ModelPrimitiveType int int int Int32
    // 030 SyncFromPassIndex                        ModelPrimitiveType int int int Int32
    // 034 GenerateDebugData                        ModelPrimitiveType bool bool bool Bool
    public partial class PassDebugData : DataModel
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
            var value   = new PassDebugData() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Culled                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 Culled                      ( ModelPrimitiveType bool bool bool Bool )
            value.Async                                     = GetBool(new IntPtr(p + 0x029)); // 0x29 Async                       ( ModelPrimitiveType bool bool bool Bool )
            value.SyncToPassIndex                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C SyncToPassIndex             ( ModelPrimitiveType int int int Int32 )
            value.SyncFromPassIndex                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 SyncFromPassIndex           ( ModelPrimitiveType int int int Int32 )
            value.GenerateDebugData                         = GetBool(new IntPtr(p + 0x034)); // 0x34 GenerateDebugData           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
