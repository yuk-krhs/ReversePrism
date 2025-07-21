using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 sInstance                                CinemachineImpulseManager IL2CPP_TYPE_CLASS
    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    // 010 M_ExpiredEvents                          ModelClassListType List`1<ImpulseEvent> List`1<ImpulseEvent> List<ImpulseEvent> Pointer
    // 018 M_ActiveEvents                           ModelClassListType List`1<ImpulseEvent> List`1<ImpulseEvent> List<ImpulseEvent> Pointer
    // 020 IgnoreTimeScale                          ModelPrimitiveType bool bool bool Bool
    public partial class CinemachineImpulseManager : DataModel
    {
        public List<ImpulseEvent>?                      M_ExpiredEvents                         { get; set; }
        public List<ImpulseEvent>?                      M_ActiveEvents                          { get; set; }
        public bool                                     IgnoreTimeScale                         { get; set; }

        public static CinemachineImpulseManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineImpulseManager() { Pointer= p0 };

            value.M_ExpiredEvents                           = GetObjectList<ImpulseEvent>(new IntPtr(p + 0x010), ReversePrism.DataModels.ImpulseEvent.FromPointer); // 0x10 M_ExpiredEvents             ( ModelClassListType List`1<ImpulseEvent> List`1<ImpulseEvent> List<ImpulseEvent> Pointer )
            value.M_ActiveEvents                            = GetObjectList<ImpulseEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.ImpulseEvent.FromPointer); // 0x18 M_ActiveEvents              ( ModelClassListType List`1<ImpulseEvent> List`1<ImpulseEvent> List<ImpulseEvent> Pointer )
            value.IgnoreTimeScale                           = GetBool(new IntPtr(p + 0x020)); // 0x20 IgnoreTimeScale             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
