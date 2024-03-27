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
    // 030 PrincipalPolicy                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 AssemblyLoad                             0001866E08B0 ModelClassType AssemblyLoadEventHandler AssemblyLoadEventHandler AssemblyLoadEventHandler Pointer
    // 040 AssemblyResolve                          00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 048 DomainUnload                             000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 050 ProcessExit                              000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer
    // 058 ResourceResolve                          00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 060 TypeResolve                              00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 068 UnhandledException                       0001867032C0 ModelClassType UnhandledExceptionEventHandler UnhandledExceptionEventHandler UnhandledExceptionEventHandler Pointer
    // 070 FirstChanceException                     EventHandler`1<FirstChanceExceptionEventArgs> IL2CPP_TYPE_GENERICINST
    // 078 _domain_manager                          <object> IL2CPP_TYPE_OBJECT
    // 080 ReflectionOnlyAssemblyResolve            00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer
    // 088 _activation                              <object> IL2CPP_TYPE_OBJECT
    // 090 _applicationIdentity                     <object> IL2CPP_TYPE_OBJECT
    // 098 Compatibility_switch                     000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AppDomain
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
            var value   = new AppDomain();

            value.PrincipalPolicy                           = GetInt32(new IntPtr(p + 0x030)); // 02700028D998 0x30 PrincipalPolicy             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AssemblyLoad                              = GetObject<AssemblyLoadEventHandler>(new IntPtr(p + 0x038), ReversePrism.DataModels.AssemblyLoadEventHandler.FromPointer); // 02700028D9B8 0x38 AssemblyLoad                ( 0001866E08B0 ModelClassType AssemblyLoadEventHandler AssemblyLoadEventHandler AssemblyLoadEventHandler Pointer )
            value.AssemblyResolve                           = GetObject<ResolveEventHandler>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 02700028D9D8 0x40 AssemblyResolve             ( 00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.DomainUnload                              = GetObject<EventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.EventHandler.FromPointer); // 02700028D9F8 0x48 DomainUnload                ( 000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ProcessExit                               = GetObject<EventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.EventHandler.FromPointer); // 02700028DA18 0x50 ProcessExit                 ( 000186756FD0 ModelClassType EventHandler EventHandler EventHandler Pointer )
            value.ResourceResolve                           = GetObject<ResolveEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 02700028DA38 0x58 ResourceResolve             ( 00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.TypeResolve                               = GetObject<ResolveEventHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 02700028DA58 0x60 TypeResolve                 ( 00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.UnhandledException                        = GetObject<UnhandledExceptionEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.UnhandledExceptionEventHandler.FromPointer); // 02700028DA78 0x68 UnhandledException          ( 0001867032C0 ModelClassType UnhandledExceptionEventHandler UnhandledExceptionEventHandler UnhandledExceptionEventHandler Pointer )
            value.ReflectionOnlyAssemblyResolve             = GetObject<ResolveEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.ResolveEventHandler.FromPointer); // 02700028DAD8 0x80 ReflectionOnlyAssemblyResolve ( 00018666D4F0 ModelClassType ResolveEventHandler ResolveEventHandler ResolveEventHandler Pointer )
            value.Compatibility_switch                      = GetStringList(new IntPtr(p + 0x098)); // 02700028DB38 0x98 Compatibility_switch        ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
