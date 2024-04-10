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
    public partial class RealProxy : DataModel
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
            var value   = new RealProxy() { Pointer= p0 };

            value.Class_to_proxy                            = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024666C2FF78 0x10 Class_to_proxy              ( 000186692850 ModelClassType Type Type Type Pointer )
            value.TargetContext                             = GetObject<Context>(new IntPtr(p + 0x018), ReversePrism.DataModels.Context.FromPointer); // 024666C2FF98 0x18 TargetContext               ( 000186613730 ModelClassType Context Context Context Pointer )
            value.Server                                    = GetObject<MarshalByRefObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.MarshalByRefObject.FromPointer); // 024666C2FFB8 0x20 Server                      ( 0001865D71A0 ModelClassType MarshalByRefObject MarshalByRefObject MarshalByRefObject Pointer )
            value.TargetDomainId                            = GetInt32(new IntPtr(p + 0x028)); // 024666C2FFD8 0x28 TargetDomainId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TargetUri                                 = GetString(new IntPtr(p + 0x030)); // 024666C2FFF8 0x30 TargetUri                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.ObjectIdentity                            = GetObject<Identity>(new IntPtr(p + 0x038), ReversePrism.DataModels.Identity.FromPointer); // 024666C30018 0x38 ObjectIdentity              ( 0001866A3D70 ModelClassType Identity Identity Identity Pointer )

            return value;
        }
    }
}
