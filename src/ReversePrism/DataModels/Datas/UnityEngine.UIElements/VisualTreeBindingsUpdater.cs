using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_BindingRequestObjectVEPropertyName     PropertyName IL2CPP_TYPE_VALUETYPE
    // 004 s_AdditionalBindingObjectVEPropertyName  PropertyName IL2CPP_TYPE_VALUETYPE
    // 008 s_Description                            string IL2CPP_TYPE_STRING
    // 010 S_ProfilerMarker                         0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 S_ProfilerBindingRequestsMarker          0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 S_MarkerUpdate                           0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 S_MarkerPoll                             0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 DisableBindingsThrottling                000186595C30 ModelPrimitiveType bool bool bool Bool
    // 038 m_ElementsWithBindings                   HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 040 m_ElementsToAdd                          HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 048 m_ElementsToRemove                       HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 050 M_LastUpdateTime                         0001865F7700 ModelPrimitiveType long long long Int64
    // 058 m_ElementsToBind                         HashSet`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 060 <temporaryObjectCache>k__BackingField    Dictionary`2<<object>, <object>> IL2CPP_TYPE_GENERICINST
    // 068 UpdatedBindings                          000185CE12F8 ModelClassListType List`1<IBinding> List`1<IBinding> List<IBinding> Pointer
    public partial class VisualTreeBindingsUpdater
    {
        public ProfilerMarker                           S_ProfilerMarker                        { get; set; }
        public ProfilerMarker                           S_ProfilerBindingRequestsMarker         { get; set; }
        public ProfilerMarker                           S_MarkerUpdate                          { get; set; }
        public ProfilerMarker                           S_MarkerPoll                            { get; set; }
        public bool                                     DisableBindingsThrottling               { get; set; }
        public long                                     M_LastUpdateTime                        { get; set; }
        public List<IBinding>?                          UpdatedBindings                         { get; set; }

        public static VisualTreeBindingsUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualTreeBindingsUpdater();

            value.S_ProfilerMarker                          = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0270066E26F8 0x10 S_ProfilerMarker            ( 0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_ProfilerBindingRequestsMarker           = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0270066E2718 0x18 S_ProfilerBindingRequestsMarker ( 0001865C9C30 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerUpdate                            = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0270066E2738 0x20 S_MarkerUpdate              ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerPoll                              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0270066E2758 0x28 S_MarkerPoll                ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.DisableBindingsThrottling                 = GetBool(new IntPtr(p + 0x030)); // 0270066E2778 0x30 DisableBindingsThrottling   ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.M_LastUpdateTime                          = GetInt64(new IntPtr(p + 0x050)); // 0270066E27F8 0x50 M_LastUpdateTime            ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.UpdatedBindings                           = GetObjectList<IBinding>(new IntPtr(p + 0x068), ReversePrism.DataModels.IBinding.FromPointer); // 0270066E2858 0x68 UpdatedBindings             ( 000185CE12F8 ModelClassListType List`1<IBinding> List`1<IBinding> List<IBinding> Pointer )

            return value;
        }
    }
}
