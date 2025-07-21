using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 clothSet                                 HashSet`1<ClothProcess> IL2CPP_TYPE_GENERICINST
    // 018 boneClothSet                             HashSet`1<ClothProcess> IL2CPP_TYPE_GENERICINST
    // 020 meshClothSet                             HashSet`1<ClothProcess> IL2CPP_TYPE_GENERICINST
    // 028 animatorVisibleDict                      Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 030 rendererVisibleDict                      Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 038 MasterJob                                ModelEnumType JobHandle JobHandle JobHandle Int32
    // 048 IsValid                                  ModelPrimitiveType bool bool bool Bool
    // 000 startClothUpdateMainProfiler             ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 startClothUpdateScheduleProfiler         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    public partial class ClothManager : DataModel
    {
        public JobHandle                                MasterJob                               { get; set; }
        public bool                                     IsValid                                 { get; set; }

        public static ClothManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClothManager() { Pointer= p0 };

            value.MasterJob                                 = (JobHandle)GetInt32(new IntPtr(p + 0x038)); // 0x38 MasterJob                   ( ModelEnumType JobHandle JobHandle JobHandle Int32 )
            value.IsValid                                   = GetBool(new IntPtr(p + 0x048)); // 0x48 IsValid                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
