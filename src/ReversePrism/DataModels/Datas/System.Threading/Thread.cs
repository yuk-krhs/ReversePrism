using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_LocalDataStoreMgr                      LocalDataStoreMgr IL2CPP_TYPE_CLASS
    // FFFFFFFF s_LocalDataStore                         LocalDataStoreHolder IL2CPP_TYPE_CLASS
    // FFFFFFFF m_CurrentCulture                         CultureInfo IL2CPP_TYPE_CLASS
    // FFFFFFFF m_CurrentUICulture                       CultureInfo IL2CPP_TYPE_CLASS
    // 008 s_asyncLocalCurrentCulture               AsyncLocal`1<CultureInfo> IL2CPP_TYPE_GENERICINST
    // 010 s_asyncLocalCurrentUICulture             AsyncLocal`1<CultureInfo> IL2CPP_TYPE_GENERICINST
    // 010 Internal_thread                          00018671F860 ModelClassType InternalThread InternalThread InternalThread Pointer
    // 018 m_ThreadStartArg                         <object> IL2CPP_TYPE_OBJECT
    // 020 pending_exception                        <object> IL2CPP_TYPE_OBJECT
    // FFFFFFFF current_thread                           Thread IL2CPP_TYPE_CLASS
    // 028 M_Delegate                               000186660E80 ModelClassType MulticastDelegate MulticastDelegate MulticastDelegate Pointer
    // 030 M_ExecutionContext                       0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer
    // 038 M_ExecutionContextBelongsToOuterScope    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 Principal                                0001865DDD40 ModelClassType IPrincipal IPrincipal IPrincipal Pointer
    // 048 Principal_version                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Thread
    {
        public InternalThread?                          Internal_thread                         { get; set; }
        public MulticastDelegate?                       M_Delegate                              { get; set; }
        public ExecutionContext?                        M_ExecutionContext                      { get; set; }
        public bool                                     M_ExecutionContextBelongsToOuterScope   { get; set; }
        public IPrincipal?                              Principal                               { get; set; }
        public int                                      Principal_version                       { get; set; }

        public static Thread? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Thread();

            value.Internal_thread                           = GetObject<InternalThread>(new IntPtr(p + 0x010), ReversePrism.DataModels.InternalThread.FromPointer); // 02700028B710 0x10 Internal_thread             ( 00018671F860 ModelClassType InternalThread InternalThread InternalThread Pointer )
            value.M_Delegate                                = GetObject<MulticastDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.MulticastDelegate.FromPointer); // 02700028B790 0x28 M_Delegate                  ( 000186660E80 ModelClassType MulticastDelegate MulticastDelegate MulticastDelegate Pointer )
            value.M_ExecutionContext                        = GetObject<ExecutionContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExecutionContext.FromPointer); // 02700028B7B0 0x30 M_ExecutionContext          ( 0001865CCA80 ModelClassType ExecutionContext ExecutionContext ExecutionContext Pointer )
            value.M_ExecutionContextBelongsToOuterScope     = GetBool(new IntPtr(p + 0x038)); // 02700028B7D0 0x38 M_ExecutionContextBelongsToOuterScope ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Principal                                 = GetObject<IPrincipal>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPrincipal.FromPointer); // 02700028B7F0 0x40 Principal                   ( 0001865DDD40 ModelClassType IPrincipal IPrincipal IPrincipal Pointer )
            value.Principal_version                         = GetInt32(new IntPtr(p + 0x048)); // 02700028B810 0x48 Principal_version           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
