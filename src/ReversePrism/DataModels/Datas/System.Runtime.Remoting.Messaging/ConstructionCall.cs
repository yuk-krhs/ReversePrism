using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Activator                                ModelClassType IActivator IActivator IActivator Pointer
    // 070 _activationAttributes                    <object>[] IL2CPP_TYPE_SZARRAY
    // 078 ContextProperties                        ModelClassType IList IList IList Pointer
    // 080 ActivationType                           ModelClassType Type Type Type Pointer
    // 088 ActivationTypeName                       ModelPrimitiveType string string string String
    // 090 IsContextOk                              ModelPrimitiveType bool bool bool Bool
    // 098 SourceProxy                              ModelClassType RemotingProxy RemotingProxy RemotingProxy Pointer
    public partial class ConstructionCall : DataModel
    {
        public IActivator?                              Activator                               { get; set; }
        public IList?                                   ContextProperties                       { get; set; }
        public Type?                                    ActivationType                          { get; set; }
        public string                                   ActivationTypeName                      { get; set; }
        public bool                                     IsContextOk                             { get; set; }
        public RemotingProxy?                           SourceProxy                             { get; set; }

        public static ConstructionCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstructionCall() { Pointer= p0 };

            value.Activator                                 = GetObject<IActivator>(new IntPtr(p + 0x068), ReversePrism.DataModels.IActivator.FromPointer); // 0x68 Activator                   ( ModelClassType IActivator IActivator IActivator Pointer )
            value.ContextProperties                         = GetObject<IList>(new IntPtr(p + 0x078), ReversePrism.DataModels.IList.FromPointer); // 0x78 ContextProperties           ( ModelClassType IList IList IList Pointer )
            value.ActivationType                            = GetObject<Type>(new IntPtr(p + 0x080), ReversePrism.DataModels.Type.FromPointer); // 0x80 ActivationType              ( ModelClassType Type Type Type Pointer )
            value.ActivationTypeName                        = GetString(new IntPtr(p + 0x088)); // 0x88 ActivationTypeName          ( ModelPrimitiveType string string string String )
            value.IsContextOk                               = GetBool(new IntPtr(p + 0x090)); // 0x90 IsContextOk                 ( ModelPrimitiveType bool bool bool Bool )
            value.SourceProxy                               = GetObject<RemotingProxy>(new IntPtr(p + 0x098), ReversePrism.DataModels.RemotingProxy.FromPointer); // 0x98 SourceProxy                 ( ModelClassType RemotingProxy RemotingProxy RemotingProxy Pointer )

            return value;
        }
    }
}
