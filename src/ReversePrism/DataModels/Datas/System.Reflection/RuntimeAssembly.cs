using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _mono_assembly                           <int> IL2CPP_TYPE_I
    // 018 _evidence                                <object> IL2CPP_TYPE_OBJECT
    // 020 Resolve_event_holder                     ModelClassType ResolveEventHolder ResolveEventHolder ResolveEventHolder Pointer
    // 028 _minimum                                 <object> IL2CPP_TYPE_OBJECT
    // 030 _optional                                <object> IL2CPP_TYPE_OBJECT
    // 038 _refuse                                  <object> IL2CPP_TYPE_OBJECT
    // 040 _granted                                 <object> IL2CPP_TYPE_OBJECT
    // 048 _denied                                  <object> IL2CPP_TYPE_OBJECT
    // 050 FromByteArray                            ModelPrimitiveType bool bool bool Bool
    // 058 AssemblyName                             ModelPrimitiveType string string string String
    public partial class RuntimeAssembly : DataModel
    {
        public ResolveEventHolder?                      Resolve_event_holder                    { get; set; }
        public bool                                     FromByteArray                           { get; set; }
        public string                                   AssemblyName                            { get; set; }

        public static RuntimeAssembly? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeAssembly() { Pointer= p0 };

            value.Resolve_event_holder                      = GetObject<ResolveEventHolder>(new IntPtr(p + 0x020), ReversePrism.DataModels.ResolveEventHolder.FromPointer); // 0x20 Resolve_event_holder        ( ModelClassType ResolveEventHolder ResolveEventHolder ResolveEventHolder Pointer )
            value.FromByteArray                             = GetBool(new IntPtr(p + 0x050)); // 0x50 FromByteArray               ( ModelPrimitiveType bool bool bool Bool )
            value.AssemblyName                              = GetString(new IntPtr(p + 0x058)); // 0x58 AssemblyName                ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
