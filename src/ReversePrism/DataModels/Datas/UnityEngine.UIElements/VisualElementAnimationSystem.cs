using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 m_Animations                             HashSet`1<IValueAnimationUpdate> IL2CPP_TYPE_GENERICINST
    // 028 M_IterationList                          000185CE9F28 ModelClassListType List`1<IValueAnimationUpdate> List`1<IValueAnimationUpdate> List<IValueAnimationUpdate> Pointer
    // 030 M_HasNewAnimations                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 M_IterationListDirty                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 s_Description                            string IL2CPP_TYPE_STRING
    // 008 s_ProfilerMarker                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 S_StylePropertyAnimationDescription      0001866738F0 ModelPrimitiveType string string string String
    // 018 S_StylePropertyAnimationProfilerMarker   0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 LastUpdate                               0001865F7700 ModelPrimitiveType long long long Int64
    public partial class VisualElementAnimationSystem : DataModel
    {
        public List<IValueAnimationUpdate>?             M_IterationList                         { get; set; }
        public bool                                     M_HasNewAnimations                      { get; set; }
        public bool                                     M_IterationListDirty                    { get; set; }
        public string                                   S_StylePropertyAnimationDescription     { get; set; }
        public ProfilerMarker                           S_StylePropertyAnimationProfilerMarker  { get; set; }
        public long                                     LastUpdate                              { get; set; }

        public static VisualElementAnimationSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementAnimationSystem() { Pointer= p0 };

            value.M_IterationList                           = GetObjectList<IValueAnimationUpdate>(new IntPtr(p + 0x028), ReversePrism.DataModels.IValueAnimationUpdate.FromPointer); // 0245A681ED98 0x28 M_IterationList             ( 000185CE9F28 ModelClassListType List`1<IValueAnimationUpdate> List`1<IValueAnimationUpdate> List<IValueAnimationUpdate> Pointer )
            value.M_HasNewAnimations                        = GetBool(new IntPtr(p + 0x030)); // 0245A681EDB8 0x30 M_HasNewAnimations          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IterationListDirty                      = GetBool(new IntPtr(p + 0x031)); // 0245A681EDD8 0x31 M_IterationListDirty        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.S_StylePropertyAnimationDescription       = GetString(new IntPtr(p + 0x010)); // 0245A681EE38 0x10 S_StylePropertyAnimationDescription ( 0001866738F0 ModelPrimitiveType string string string String )
            value.S_StylePropertyAnimationProfilerMarker    = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0245A681EE58 0x18 S_StylePropertyAnimationProfilerMarker ( 0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.LastUpdate                                = GetInt64(new IntPtr(p + 0x038)); // 0245A681EE78 0x38 LastUpdate                  ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
