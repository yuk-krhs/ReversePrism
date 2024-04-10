using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_MaximumResolution                      int IL2CPP_TYPE_I4
    // 004 k_MinimumDetailResolutionPerPatch        int IL2CPP_TYPE_I4
    // 008 k_MaximumDetailResolutionPerPatch        int IL2CPP_TYPE_I4
    // 00C k_MaximumDetailPatchCount                int IL2CPP_TYPE_I4
    // 010 K_MinimumAlphamapResolution              0001865F4E00 ModelPrimitiveType int int int Int32
    // 014 K_MaximumAlphamapResolution              0001865F4E00 ModelPrimitiveType int int int Int32
    // 018 K_MinimumBaseMapResolution               0001865F4E00 ModelPrimitiveType int int int Int32
    // 01C K_MaximumBaseMapResolution               0001865F4E00 ModelPrimitiveType int int int Int32
    public partial class TerrainData : DataModel
    {
        public int                                      K_MinimumAlphamapResolution             { get; set; }
        public int                                      K_MaximumAlphamapResolution             { get; set; }
        public int                                      K_MinimumBaseMapResolution              { get; set; }
        public int                                      K_MaximumBaseMapResolution              { get; set; }

        public static TerrainData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TerrainData() { Pointer= p0 };

            value.K_MinimumAlphamapResolution               = GetInt32(new IntPtr(p + 0x010)); // 0245A2207448 0x10 K_MinimumAlphamapResolution ( 0001865F4E00 ModelPrimitiveType int int int Int32 )
            value.K_MaximumAlphamapResolution               = GetInt32(new IntPtr(p + 0x014)); // 0245A2207468 0x14 K_MaximumAlphamapResolution ( 0001865F4E00 ModelPrimitiveType int int int Int32 )
            value.K_MinimumBaseMapResolution                = GetInt32(new IntPtr(p + 0x018)); // 0245A2207488 0x18 K_MinimumBaseMapResolution  ( 0001865F4E00 ModelPrimitiveType int int int Int32 )
            value.K_MaximumBaseMapResolution                = GetInt32(new IntPtr(p + 0x01C)); // 0245A22074A8 0x1C K_MaximumBaseMapResolution  ( 0001865F4E00 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
