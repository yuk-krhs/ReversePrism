using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PersistentCalls                        000185CCED58 ModelClassListType List`1<BaseInvokableCall> List`1<BaseInvokableCall> List<BaseInvokableCall> Pointer
    // 018 M_RuntimeCalls                           000185CCED58 ModelClassListType List`1<BaseInvokableCall> List`1<BaseInvokableCall> List<BaseInvokableCall> Pointer
    // 020 M_ExecutingCalls                         000185CCEC98 ModelClassListType List`1<BaseInvokableCall> List`1<BaseInvokableCall> List<BaseInvokableCall> Pointer
    // 028 M_NeedsUpdate                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InvokableCallList : DataModel
    {
        public List<BaseInvokableCall>?                 M_PersistentCalls                       { get; set; }
        public List<BaseInvokableCall>?                 M_RuntimeCalls                          { get; set; }
        public List<BaseInvokableCall>?                 M_ExecutingCalls                        { get; set; }
        public bool                                     M_NeedsUpdate                           { get; set; }

        public static InvokableCallList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvokableCallList() { Pointer= p0 };

            value.M_PersistentCalls                         = GetObjectList<BaseInvokableCall>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseInvokableCall.FromPointer); // 0245A3F7F040 0x10 M_PersistentCalls           ( 000185CCED58 ModelClassListType List`1<BaseInvokableCall> List`1<BaseInvokableCall> List<BaseInvokableCall> Pointer )
            value.M_RuntimeCalls                            = GetObjectList<BaseInvokableCall>(new IntPtr(p + 0x018), ReversePrism.DataModels.BaseInvokableCall.FromPointer); // 0245A3F7F060 0x18 M_RuntimeCalls              ( 000185CCED58 ModelClassListType List`1<BaseInvokableCall> List`1<BaseInvokableCall> List<BaseInvokableCall> Pointer )
            value.M_ExecutingCalls                          = GetObjectList<BaseInvokableCall>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseInvokableCall.FromPointer); // 0245A3F7F080 0x20 M_ExecutingCalls            ( 000185CCEC98 ModelClassListType List`1<BaseInvokableCall> List`1<BaseInvokableCall> List<BaseInvokableCall> Pointer )
            value.M_NeedsUpdate                             = GetBool(new IntPtr(p + 0x028)); // 0245A3F7F0A0 0x28 M_NeedsUpdate               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
