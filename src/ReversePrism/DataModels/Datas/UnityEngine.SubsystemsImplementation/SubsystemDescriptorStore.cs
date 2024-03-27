using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_IntegratedDescriptors                  List`1<IntegratedSubsystemDescriptor> IL2CPP_TYPE_GENERICINST
    // 008 s_StandaloneDescriptors                  List`1<SubsystemDescriptorWithProvider> IL2CPP_TYPE_GENERICINST
    // 010 S_DeprecatedDescriptors                  000185D0F998 ModelClassListType List`1<SubsystemDescriptor> List`1<SubsystemDescriptor> List<SubsystemDescriptor> Pointer
    public partial class SubsystemDescriptorStore
    {
        public List<SubsystemDescriptor>?               S_DeprecatedDescriptors                 { get; set; }

        public static SubsystemDescriptorStore? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubsystemDescriptorStore();

            value.S_DeprecatedDescriptors                   = GetObjectList<SubsystemDescriptor>(new IntPtr(p + 0x010), ReversePrism.DataModels.SubsystemDescriptor.FromPointer); // 0270022B66C8 0x10 S_DeprecatedDescriptors     ( 000185D0F998 ModelClassListType List`1<SubsystemDescriptor> List`1<SubsystemDescriptor> List<SubsystemDescriptor> Pointer )

            return value;
        }
    }
}
