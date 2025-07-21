using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<AttributeContext> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OriginFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Origin                                   ModelClassType Peer Peer Peer Pointer
    // 000 SourceFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Source                                   ModelClassType Peer Peer Peer Pointer
    // 000 DestinationFieldNumber                   int IL2CPP_TYPE_I4
    // 028 Destination                              ModelClassType Peer Peer Peer Pointer
    // 000 RequestFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Request                                  ModelClassType Request Request Request Pointer
    // 000 ResponseFieldNumber                      int IL2CPP_TYPE_I4
    // 038 Response                                 ModelClassType Response Response Response Pointer
    // 000 ResourceFieldNumber                      int IL2CPP_TYPE_I4
    // 040 Resource                                 ModelClassType Resource Resource Resource Pointer
    // 000 ApiFieldNumber                           int IL2CPP_TYPE_I4
    // 048 Api                                      ModelClassType Api Api Api Pointer
    // 000 ExtensionsFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_extensions_codec               FieldCodec`1<Any> IL2CPP_TYPE_GENERICINST
    // 050 Extensions                               ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer
    public partial class AttributeContext : DataModel
    {
        public Peer?                                    Origin                                  { get; set; }
        public Peer?                                    Source                                  { get; set; }
        public Peer?                                    Destination                             { get; set; }
        public Request?                                 Request                                 { get; set; }
        public Response?                                Response                                { get; set; }
        public Resource?                                Resource                                { get; set; }
        public Api?                                     Api                                     { get; set; }
        public List<Any>?                               Extensions                              { get; set; }

        public static AttributeContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttributeContext() { Pointer= p0 };

            value.Origin                                    = GetObject<Peer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Peer.FromPointer); // 0x18 Origin                      ( ModelClassType Peer Peer Peer Pointer )
            value.Source                                    = GetObject<Peer>(new IntPtr(p + 0x020), ReversePrism.DataModels.Peer.FromPointer); // 0x20 Source                      ( ModelClassType Peer Peer Peer Pointer )
            value.Destination                               = GetObject<Peer>(new IntPtr(p + 0x028), ReversePrism.DataModels.Peer.FromPointer); // 0x28 Destination                 ( ModelClassType Peer Peer Peer Pointer )
            value.Request                                   = GetObject<Request>(new IntPtr(p + 0x030), ReversePrism.DataModels.Request.FromPointer); // 0x30 Request                     ( ModelClassType Request Request Request Pointer )
            value.Response                                  = GetObject<Response>(new IntPtr(p + 0x038), ReversePrism.DataModels.Response.FromPointer); // 0x38 Response                    ( ModelClassType Response Response Response Pointer )
            value.Resource                                  = GetObject<Resource>(new IntPtr(p + 0x040), ReversePrism.DataModels.Resource.FromPointer); // 0x40 Resource                    ( ModelClassType Resource Resource Resource Pointer )
            value.Api                                       = GetObject<Api>(new IntPtr(p + 0x048), ReversePrism.DataModels.Api.FromPointer); // 0x48 Api                         ( ModelClassType Api Api Api Pointer )
            value.Extensions                                = GetObjectList<Any>(new IntPtr(p + 0x050), ReversePrism.DataModels.Any.FromPointer); // 0x50 Extensions                  ( ModelClassListType RepeatedField`1<Any> RepeatedField`1<Any> List<Any> Pointer )

            return value;
        }
    }
}
