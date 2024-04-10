using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 ObjectType                               000186692D10 ModelClassType Type Type Type Pointer
    // 050 ServerObject                             0001865D7400 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer
    // 058 ServerSink                               0001865B0D10 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 060 Context                                  0001866139D0 ModelClassType Context Context Context Pointer
    // 068 Lease                                    000186512580 ModelClassType Lease Lease Lease Pointer
    public partial class ServerIdentity : DataModel
    {
        public Type?                                    ObjectType                              { get; set; }
        public MarshalByRefObject?                      ServerObject                            { get; set; }
        public IMessageSink?                            ServerSink                              { get; set; }
        public Context?                                 Context                                 { get; set; }
        public Lease?                                   Lease                                   { get; set; }

        public static ServerIdentity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerIdentity() { Pointer= p0 };

            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 024666AC7B28 0x48 ObjectType                  ( 000186692D10 ModelClassType Type Type Type Pointer )
            value.ServerObject                              = GetObject<MarshalByRefObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.MarshalByRefObject.FromPointer); // 024666AC7B48 0x50 ServerObject                ( 0001865D7400 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer )
            value.ServerSink                                = GetObject<IMessageSink>(new IntPtr(p + 0x058), ReversePrism.DataModels.IMessageSink.FromPointer); // 024666AC7B68 0x58 ServerSink                  ( 0001865B0D10 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x060), ReversePrism.DataModels.Context.FromPointer); // 024666AC7B88 0x60 Context                     ( 0001866139D0 ModelClassType Context Context Context Pointer )
            value.Lease                                     = GetObject<Lease>(new IntPtr(p + 0x068), ReversePrism.DataModels.Lease.FromPointer); // 024666AC7BA8 0x68 Lease                       ( 000186512580 ModelClassType Lease Lease Lease Pointer )

            return value;
        }
    }
}
