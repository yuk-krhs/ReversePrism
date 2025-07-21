using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Target                                 ModelClassType Object Object Object Pointer
    // 018 M_TargetAssemblyTypeName                 ModelPrimitiveType string string string String
    // 020 M_MethodName                             ModelPrimitiveType string string string String
    // 028 M_Mode                                   ModelEnumType PersistentListenerMode PersistentListenerMode PersistentListenerMode Int32
    // 030 M_Arguments                              ModelClassType ArgumentCache ArgumentCache ArgumentCache Pointer
    // 038 M_CallState                              ModelEnumType UnityEventCallState UnityEventCallState UnityEventCallState Int32
    public partial class PersistentCall : DataModel
    {
        public Object?                                  M_Target                                { get; set; }
        public string                                   M_TargetAssemblyTypeName                { get; set; }
        public string                                   M_MethodName                            { get; set; }
        public PersistentListenerMode                   M_Mode                                  { get; set; }
        public ArgumentCache?                           M_Arguments                             { get; set; }
        public UnityEventCallState                      M_CallState                             { get; set; }

        public static PersistentCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersistentCall() { Pointer= p0 };

            value.M_Target                                  = GetObject<Object>(new IntPtr(p + 0x010), ReversePrism.DataModels.Object.FromPointer); // 0x10 M_Target                    ( ModelClassType Object Object Object Pointer )
            value.M_TargetAssemblyTypeName                  = GetString(new IntPtr(p + 0x018)); // 0x18 M_TargetAssemblyTypeName    ( ModelPrimitiveType string string string String )
            value.M_MethodName                              = GetString(new IntPtr(p + 0x020)); // 0x20 M_MethodName                ( ModelPrimitiveType string string string String )
            value.M_Mode                                    = (PersistentListenerMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Mode                      ( ModelEnumType PersistentListenerMode PersistentListenerMode PersistentListenerMode Int32 )
            value.M_Arguments                               = GetObject<ArgumentCache>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArgumentCache.FromPointer); // 0x30 M_Arguments                 ( ModelClassType ArgumentCache ArgumentCache ArgumentCache Pointer )
            value.M_CallState                               = (UnityEventCallState)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_CallState                 ( ModelEnumType UnityEventCallState UnityEventCallState UnityEventCallState Int32 )

            return value;
        }
    }
}
