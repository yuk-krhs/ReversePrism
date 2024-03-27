using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 beforeReloadSubsystems                   Action IL2CPP_TYPE_CLASS
    // 008 afterReloadSubsystems                    Action IL2CPP_TYPE_CLASS
    // 010 S_IntegratedSubsystems                   000185CEDA58 ModelClassListType List`1<IntegratedSubsystem> List`1<IntegratedSubsystem> List<IntegratedSubsystem> Pointer
    // 018 S_StandaloneSubsystems                   000185D0FE48 ModelClassListType List`1<SubsystemWithProvider> List`1<SubsystemWithProvider> List<SubsystemWithProvider> Pointer
    // 020 S_DeprecatedSubsystems                   000185D0F758 ModelClassListType List`1<Subsystem> List`1<Subsystem> List<Subsystem> Pointer
    // 028 ReloadSubsytemsStarted                   000186679C50 ModelClassType Action Action Action Pointer
    // 030 ReloadSubsytemsCompleted                 000186679C50 ModelClassType Action Action Action Pointer
    public partial class SubsystemManager
    {
        public List<IntegratedSubsystem>?               S_IntegratedSubsystems                  { get; set; }
        public List<SubsystemWithProvider>?             S_StandaloneSubsystems                  { get; set; }
        public List<Subsystem>?                         S_DeprecatedSubsystems                  { get; set; }
        public Action?                                  ReloadSubsytemsStarted                  { get; set; }
        public Action?                                  ReloadSubsytemsCompleted                { get; set; }

        public static SubsystemManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubsystemManager();

            value.S_IntegratedSubsystems                    = GetObjectList<IntegratedSubsystem>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntegratedSubsystem.FromPointer); // 0270022B48E8 0x10 S_IntegratedSubsystems      ( 000185CEDA58 ModelClassListType List`1<IntegratedSubsystem> List`1<IntegratedSubsystem> List<IntegratedSubsystem> Pointer )
            value.S_StandaloneSubsystems                    = GetObjectList<SubsystemWithProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.SubsystemWithProvider.FromPointer); // 0270022B4908 0x18 S_StandaloneSubsystems      ( 000185D0FE48 ModelClassListType List`1<SubsystemWithProvider> List`1<SubsystemWithProvider> List<SubsystemWithProvider> Pointer )
            value.S_DeprecatedSubsystems                    = GetObjectList<Subsystem>(new IntPtr(p + 0x020), ReversePrism.DataModels.Subsystem.FromPointer); // 0270022B4928 0x20 S_DeprecatedSubsystems      ( 000185D0F758 ModelClassListType List`1<Subsystem> List`1<Subsystem> List<Subsystem> Pointer )
            value.ReloadSubsytemsStarted                    = GetObject<Action>(new IntPtr(p + 0x028), ReversePrism.DataModels.Action.FromPointer); // 0270022B4948 0x28 ReloadSubsytemsStarted      ( 000186679C50 ModelClassType Action Action Action Pointer )
            value.ReloadSubsytemsCompleted                  = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 0270022B4968 0x30 ReloadSubsytemsCompleted    ( 000186679C50 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
