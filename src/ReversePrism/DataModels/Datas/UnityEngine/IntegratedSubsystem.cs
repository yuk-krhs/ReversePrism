using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Ptr                                    <int> IL2CPP_TYPE_I
    // 018 M_SubsystemDescriptor                    ModelClassType ISubsystemDescriptor ISubsystemDescriptor ISubsystemDescriptor Pointer
    public partial class IntegratedSubsystem : DataModel
    {
        public ISubsystemDescriptor?                    M_SubsystemDescriptor                   { get; set; }

        public static IntegratedSubsystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntegratedSubsystem() { Pointer= p0 };

            value.M_SubsystemDescriptor                     = GetObject<ISubsystemDescriptor>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISubsystemDescriptor.FromPointer); // 0x18 M_SubsystemDescriptor       ( ModelClassType ISubsystemDescriptor ISubsystemDescriptor ISubsystemDescriptor Pointer )

            return value;
        }
    }
}
