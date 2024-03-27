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
    // 010 M_Datastore                              0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 M_RemotingData                           000186525690 ModelClassType CallContextRemotingData CallContextRemotingData CallContextRemotingData Pointer
    // 020 M_SecurityData                           000186525B70 ModelClassType CallContextSecurityData CallContextSecurityData CallContextSecurityData Pointer
    // 028 m_HostContext                            <object> IL2CPP_TYPE_OBJECT
    // 030 M_IsCorrelationMgr                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 SendHeaders                              000185B83DE0 ModelClassListType Header[] Header[] List<Header> Pointer
    // 040 RecvHeaders                              000185B83DE0 ModelClassListType Header[] Header[] List<Header> Pointer
    public partial class LogicalCallContext
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
            var value   = new LogicalCallContext();

            value.M_Datastore                               = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 027003E52ED8 0x10 M_Datastore                 ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.M_RemotingData                            = GetObject<CallContextRemotingData>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallContextRemotingData.FromPointer); // 027003E52EF8 0x18 M_RemotingData              ( 000186525690 ModelClassType CallContextRemotingData CallContextRemotingData CallContextRemotingData Pointer )
            value.M_SecurityData                            = GetObject<CallContextSecurityData>(new IntPtr(p + 0x020), ReversePrism.DataModels.CallContextSecurityData.FromPointer); // 027003E52F18 0x20 M_SecurityData              ( 000186525B70 ModelClassType CallContextSecurityData CallContextSecurityData CallContextSecurityData Pointer )
            value.M_IsCorrelationMgr                        = GetBool(new IntPtr(p + 0x030)); // 027003E52F58 0x30 M_IsCorrelationMgr          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SendHeaders                               = GetObjectList<Header>(new IntPtr(p + 0x038), ReversePrism.DataModels.Header.FromPointer); // 027003E52F78 0x38 SendHeaders                 ( 000185B83DE0 ModelClassListType Header[] Header[] List<Header> Pointer )
            value.RecvHeaders                               = GetObjectList<Header>(new IntPtr(p + 0x040), ReversePrism.DataModels.Header.FromPointer); // 027003E52F98 0x40 RecvHeaders                 ( 000185B83DE0 ModelClassListType Header[] Header[] List<Header> Pointer )

            return value;
        }
    }
}
