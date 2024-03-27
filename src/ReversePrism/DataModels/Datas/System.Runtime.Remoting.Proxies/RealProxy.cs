using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Class_to_proxy                           000186692850 ModelClassType Type Type Type Pointer
    // 018 TargetContext                            000186613730 ModelClassType Context Context Context Pointer
    // 020 Server                                   0001865D71A0 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer
    // 028 TargetDomainId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 TargetUri                                000186671BA0 ModelPrimitiveType string string string String
    // 038 ObjectIdentity                           0001866A3D70 ModelClassType Identity Identity Identity Pointer
    // 040 _objTP                                   <object> IL2CPP_TYPE_OBJECT
    // 048 _stubData                                <object> IL2CPP_TYPE_OBJECT
    public partial class RealProxy
    {
        public Type?                                    Class_to_proxy                          { get; set; }
        public Context?                                 TargetContext                           { get; set; }
        public MarshalByRefObject?                      Server                                  { get; set; }
        public int                                      TargetDomainId                          { get; set; }
        public string                                   TargetUri                               { get; set; }
        public Identity?                                ObjectIdentity                          { get; set; }

        public static RealProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RealProxy();

            value.Class_to_proxy                            = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D6BB7F78 0x10 Class_to_proxy              ( 000186692850 ModelClassType Type Type Type Pointer )
            value.TargetContext                             = GetObject<Context>(new IntPtr(p + 0x018), ReversePrism.DataModels.Context.FromPointer); // 0270D6BB7F98 0x18 TargetContext               ( 000186613730 ModelClassType Context Context Context Pointer )
            value.Server                                    = GetObject<MarshalByRefObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.MarshalByRefObject.FromPointer); // 0270D6BB7FB8 0x20 Server                      ( 0001865D71A0 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer )
            value.TargetDomainId                            = GetInt32(new IntPtr(p + 0x028)); // 0270D6BB7FD8 0x28 TargetDomainId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TargetUri                                 = GetString(new IntPtr(p + 0x030)); // 0270D6BB7FF8 0x30 TargetUri                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ObjectIdentity                            = GetObject<Identity>(new IntPtr(p + 0x038), ReversePrism.DataModels.Identity.FromPointer); // 0270D6BB8018 0x38 ObjectIdentity              ( 0001866A3D70 ModelClassType Identity Identity Identity Pointer )

            return value;
        }
    }
}
