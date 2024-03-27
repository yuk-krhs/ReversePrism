using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _cache_GetTypeMethod                     MethodInfo IL2CPP_TYPE_CLASS
    // 008 _cache_GetHashCodeMethod                 MethodInfo IL2CPP_TYPE_CLASS
    // 050 Sink                                     0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 058 HasEnvoySink                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 CtorCall                                 00018660E150 ModelClassType ConstructionCall ConstructionCall ConstructionCall Pointer
    public partial class RemotingProxy
    {
        public IMessageSink?                            Sink                                    { get; set; }
        public bool                                     HasEnvoySink                            { get; set; }
        public ConstructionCall?                        CtorCall                                { get; set; }

        public static RemotingProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RemotingProxy();

            value.Sink                                      = GetObject<IMessageSink>(new IntPtr(p + 0x050), ReversePrism.DataModels.IMessageSink.FromPointer); // 0270D6BBB950 0x50 Sink                        ( 0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.HasEnvoySink                              = GetBool(new IntPtr(p + 0x058)); // 0270D6BBB970 0x58 HasEnvoySink                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CtorCall                                  = GetObject<ConstructionCall>(new IntPtr(p + 0x060), ReversePrism.DataModels.ConstructionCall.FromPointer); // 0270D6BBB990 0x60 CtorCall                    ( 00018660E150 ModelClassType ConstructionCall ConstructionCall ConstructionCall Pointer )

            return value;
        }
    }
}
