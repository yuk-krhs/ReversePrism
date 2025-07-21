using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF t_ThreadContext                          ThreadContext IL2CPP_TYPE_CLASS
    // 010 m_AsyncObject                            <object> IL2CPP_TYPE_OBJECT
    // 018 m_AsyncState                             <object> IL2CPP_TYPE_OBJECT
    // 020 M_AsyncCallback                          ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 028 m_Result                                 <object> IL2CPP_TYPE_OBJECT
    // 030 M_IntCompleted                           ModelPrimitiveType int int int Int32
    // 034 M_EndCalled                              ModelPrimitiveType bool bool bool Bool
    // 035 M_UserEvent                              ModelPrimitiveType bool bool bool Bool
    // 038 m_Event                                  <object> IL2CPP_TYPE_OBJECT
    public partial class LazyAsyncResult : DataModel
    {
        public AsyncCallback?                           M_AsyncCallback                         { get; set; }
        public int                                      M_IntCompleted                          { get; set; }
        public bool                                     M_EndCalled                             { get; set; }
        public bool                                     M_UserEvent                             { get; set; }

        public static LazyAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LazyAsyncResult() { Pointer= p0 };

            value.M_AsyncCallback                           = GetObject<AsyncCallback>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0x20 M_AsyncCallback             ( ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.M_IntCompleted                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_IntCompleted              ( ModelPrimitiveType int int int Int32 )
            value.M_EndCalled                               = GetBool(new IntPtr(p + 0x034)); // 0x34 M_EndCalled                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_UserEvent                               = GetBool(new IntPtr(p + 0x035)); // 0x35 M_UserEvent                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
