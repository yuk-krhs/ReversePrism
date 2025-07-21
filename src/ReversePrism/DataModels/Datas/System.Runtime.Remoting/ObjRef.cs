using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel_info                             ModelClassType IChannelInfo IChannelInfo IChannelInfo Pointer
    // 018 Uri                                      ModelPrimitiveType string string string String
    // 020 TypeInfo                                 ModelClassType IRemotingTypeInfo IRemotingTypeInfo IRemotingTypeInfo Pointer
    // 028 EnvoyInfo                                ModelClassType IEnvoyInfo IEnvoyInfo IEnvoyInfo Pointer
    // 030 Flags                                    ModelPrimitiveType int int int Int32
    // 038 ServerType                               ModelClassType Type Type Type Pointer
    // 000 MarshalledObjectRef                      int IL2CPP_TYPE_I4
    // 004 WellKnowObjectRef                        int IL2CPP_TYPE_I4
    public partial class ObjRef : DataModel
    {
        public IChannelInfo?                            Channel_info                            { get; set; }
        public string                                   Uri                                     { get; set; }
        public IRemotingTypeInfo?                       TypeInfo                                { get; set; }
        public IEnvoyInfo?                              EnvoyInfo                               { get; set; }
        public int                                      Flags                                   { get; set; }
        public Type?                                    ServerType                              { get; set; }

        public static ObjRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjRef() { Pointer= p0 };

            value.Channel_info                              = GetObject<IChannelInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChannelInfo.FromPointer); // 0x10 Channel_info                ( ModelClassType IChannelInfo IChannelInfo IChannelInfo Pointer )
            value.Uri                                       = GetString(new IntPtr(p + 0x018)); // 0x18 Uri                         ( ModelPrimitiveType string string string String )
            value.TypeInfo                                  = GetObject<IRemotingTypeInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.IRemotingTypeInfo.FromPointer); // 0x20 TypeInfo                    ( ModelClassType IRemotingTypeInfo IRemotingTypeInfo IRemotingTypeInfo Pointer )
            value.EnvoyInfo                                 = GetObject<IEnvoyInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.IEnvoyInfo.FromPointer); // 0x28 EnvoyInfo                   ( ModelClassType IEnvoyInfo IEnvoyInfo IEnvoyInfo Pointer )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Flags                       ( ModelPrimitiveType int int int Int32 )
            value.ServerType                                = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 0x38 ServerType                  ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
