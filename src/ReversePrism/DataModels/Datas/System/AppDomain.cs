using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 _mono_app_domain                         <int> IL2CPP_TYPE_I
    // 000 _process_guid                            string IL2CPP_TYPE_STRING
    // FFFFFFFF type_resolve_in_progress                 Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // FFFFFFFF assembly_resolve_in_progress             Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // FFFFFFFF assembly_resolve_in_progress_refonly     Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 020 _evidence                                <object> IL2CPP_TYPE_OBJECT
    // 028 _granted                                 <object> IL2CPP_TYPE_OBJECT
    // 030 PrincipalPolicy                          ModelPrimitiveType int int int Int32
    // 038 AssemblyLoad                             ModelClassType AssemblyLoadEventHandler AssemblyLoadEventHandler AssemblyLoadEventHandler Pointer
    // 040 AssemblyResolve                          ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 048 DomainUnload                             ModelClassType EventHandler EventHandler EventHandler Pointer
    // 050 ProcessExit                              ModelClassType EventHandler EventHandler EventHandler Pointer
    // 058 ResourceResolve                          ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 060 TypeResolve                              ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 068 UnhandledException                       ModelClassType UnhandledExceptionEventHandler UnhandledExceptionEventHandler UnhandledExceptionEventHandler Pointer
    // 070 FirstChanceException                     EventHandler`1<FirstChanceExceptionEventArgs> IL2CPP_TYPE_GENERICINST
    // 078 _domain_manager                          <object> IL2CPP_TYPE_OBJECT
    // 080 ReflectionOnlyAssemblyResolve            ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 088 _activation                              <object> IL2CPP_TYPE_OBJECT
    // 090 _applicationIdentity                     <object> IL2CPP_TYPE_OBJECT
    // 098 Compatibility_switch                     ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AppDomain : DataModel
    {
        public int                                      PrincipalPolicy                         { get; set; }
        public AssemblyLoadEventHandler?                AssemblyLoad                            { get; set; }
        public ResolveEventHandler?                     AssemblyResolve                         { get; set; }
        public EventHandler?                            DomainUnload                            { get; set; }
        public EventHandler?                            ProcessExit                             { get; set; }
        public ResolveEventHandler?                     ResourceResolve                         { get; set; }
        public ResolveEventHandler?                     TypeResolve                             { get; set; }
        public UnhandledExceptionEventHandler?          UnhandledException                      { get; set; }
        public ResolveEventHandler?                     ReflectionOnlyAssemblyResolve           { get; set; }
        public List<string>?                            Compatibility_switch                    { get; set; }

        public static AppDomain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppDomain() { Pointer= p0 };

            value.PrincipalPolicy                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 PrincipalPolicy             ( ModelPrimitiveType int int int Int32 )
            value.AssemblyLoad                              = GetObject<AssemblyLoadEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.AssemblyLoadEventHandler.FromPointer); // 0x38 AssemblyLoad                ( ModelClassType AssemblyLoadEventHandler AssemblyLoadEventHandler AssemblyLoadEventHandler Pointer )
            value.AssemblyResolve                           = GetObject<ResolveEventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 0x40 AssemblyResolve             ( ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.DomainUnload                              = GetObject<EventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.EventHandler.FromPointer); // 0x48 DomainUnload                ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ProcessExit                               = GetObject<EventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.EventHandler.FromPointer); // 0x50 ProcessExit                 ( ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ResourceResolve                           = GetObject<ResolveEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 0x58 ResourceResolve             ( ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.TypeResolve                               = GetObject<ResolveEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 0x60 TypeResolve                 ( ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.UnhandledException                        = GetObject<UnhandledExceptionEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.UnhandledExceptionEventHandler.FromPointer); // 0x68 UnhandledException          ( ModelClassType UnhandledExceptionEventHandler UnhandledExceptionEventHandler UnhandledExceptionEventHandler Pointer )
            value.ReflectionOnlyAssemblyResolve             = GetObject<ResolveEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 0x80 ReflectionOnlyAssemblyResolve ( ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.Compatibility_switch                      = GetStringList(new IntPtr(p + 0x098)); // 0x98 Compatibility_switch        ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
