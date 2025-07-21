using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Calls                                  ModelClassType InvokableCallList InvokableCallList InvokableCallList Pointer
    // 018 M_PersistentCalls                        ModelClassType PersistentCallGroup PersistentCallGroup PersistentCallGroup Pointer
    // 020 M_CallsDirty                             ModelPrimitiveType bool bool bool Bool
    public partial class UnityEventBase : DataModel
    {
        public InvokableCallList?                       M_Calls                                 { get; set; }
        public PersistentCallGroup?                     M_PersistentCalls                       { get; set; }
        public bool                                     M_CallsDirty                            { get; set; }

        public static UnityEventBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityEventBase() { Pointer= p0 };

            value.M_Calls                                   = GetObject<InvokableCallList>(new IntPtr(p + 0x010), ReversePrism.DataModels.InvokableCallList.FromPointer); // 0x10 M_Calls                     ( ModelClassType InvokableCallList InvokableCallList InvokableCallList Pointer )
            value.M_PersistentCalls                         = GetObject<PersistentCallGroup>(new IntPtr(p + 0x018), ReversePrism.DataModels.PersistentCallGroup.FromPointer); // 0x18 M_PersistentCalls           ( ModelClassType PersistentCallGroup PersistentCallGroup PersistentCallGroup Pointer )
            value.M_CallsDirty                              = GetBool(new IntPtr(p + 0x020)); // 0x20 M_CallsDirty                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
