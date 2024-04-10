using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Channel_info                             000186729BB0 ModelClassType IChannelInfo IChannelInfo IChannelInfo Pointer
    // 018 Uri                                      000186671910 ModelPrimitiveType string string string String
    // 020 TypeInfo                                 000186617730 ModelClassType IRemotingTypeInfo IRemotingTypeInfo IRemotingTypeInfo Pointer
    // 028 EnvoyInfo                                000186760B90 ModelClassType IEnvoyInfo IEnvoyInfo IEnvoyInfo Pointer
    // 030 Flags                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 ServerType                               000186692850 ModelClassType Type Type Type Pointer
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

            value.Channel_info                              = GetObject<IChannelInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChannelInfo.FromPointer); // 024666AC83F8 0x10 Channel_info                ( 000186729BB0 ModelClassType IChannelInfo IChannelInfo IChannelInfo Pointer )
            value.Uri                                       = GetString(new IntPtr(p + 0x018)); // 024666AC8418 0x18 Uri                         ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeInfo                                  = GetObject<IRemotingTypeInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.IRemotingTypeInfo.FromPointer); // 024666AC8438 0x20 TypeInfo                    ( 000186617730 ModelClassType IRemotingTypeInfo IRemotingTypeInfo IRemotingTypeInfo Pointer )
            value.EnvoyInfo                                 = GetObject<IEnvoyInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.IEnvoyInfo.FromPointer); // 024666AC8458 0x28 EnvoyInfo                   ( 000186760B90 ModelClassType IEnvoyInfo IEnvoyInfo IEnvoyInfo Pointer )
            value.Flags                                     = GetInt32(new IntPtr(p + 0x030)); // 024666AC8478 0x30 Flags                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ServerType                                = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 024666AC8498 0x38 ServerType                  ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
