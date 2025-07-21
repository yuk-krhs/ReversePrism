using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_callContextType                        Type IL2CPP_TYPE_CLASS
    // 000 s_CorrelationMgrSlotName                 string IL2CPP_TYPE_STRING
    // 010 M_Datastore                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 M_RemotingData                           ModelClassType CallContextRemotingData CallContextRemotingData CallContextRemotingData Pointer
    // 020 M_SecurityData                           ModelClassType CallContextSecurityData CallContextSecurityData CallContextSecurityData Pointer
    // 028 m_HostContext                            <object> IL2CPP_TYPE_OBJECT
    // 030 M_IsCorrelationMgr                       ModelPrimitiveType bool bool bool Bool
    // 038 SendHeaders                              ModelClassListType Header[] Header[] List<Header> Pointer
    // 040 RecvHeaders                              ModelClassListType Header[] Header[] List<Header> Pointer
    public partial class LogicalCallContext : DataModel
    {
        public Hashtable?                               M_Datastore                             { get; set; }
        public CallContextRemotingData?                 M_RemotingData                          { get; set; }
        public CallContextSecurityData?                 M_SecurityData                          { get; set; }
        public bool                                     M_IsCorrelationMgr                      { get; set; }
        public List<Header>?                            SendHeaders                             { get; set; }
        public List<Header>?                            RecvHeaders                             { get; set; }

        public static LogicalCallContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogicalCallContext() { Pointer= p0 };

            value.M_Datastore                               = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 M_Datastore                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.M_RemotingData                            = GetObject<CallContextRemotingData>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallContextRemotingData.FromPointer); // 0x18 M_RemotingData              ( ModelClassType CallContextRemotingData CallContextRemotingData CallContextRemotingData Pointer )
            value.M_SecurityData                            = GetObject<CallContextSecurityData>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallContextSecurityData.FromPointer); // 0x20 M_SecurityData              ( ModelClassType CallContextSecurityData CallContextSecurityData CallContextSecurityData Pointer )
            value.M_IsCorrelationMgr                        = GetBool(new IntPtr(p + 0x030)); // 0x30 M_IsCorrelationMgr          ( ModelPrimitiveType bool bool bool Bool )
            value.SendHeaders                               = GetObjectList<Header>(new IntPtr(p + 0x038), ReversePrism.DataModels.Header.FromPointer); // 0x38 SendHeaders                 ( ModelClassListType Header[] Header[] List<Header> Pointer )
            value.RecvHeaders                               = GetObjectList<Header>(new IntPtr(p + 0x040), ReversePrism.DataModels.Header.FromPointer); // 0x40 RecvHeaders                 ( ModelClassListType Header[] Header[] List<Header> Pointer )

            return value;
        }
    }
}
