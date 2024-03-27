using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nativePlayerHn                           <int> IL2CPP_TYPE_I
    // 018 BasePlaybackId                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C TargetPlaybackId                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 CueLinkType                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CueLinkInfo
    {
        public uint                                     BasePlaybackId                          { get; set; }
        public uint                                     TargetPlaybackId                        { get; set; }
        public int                                      CueLinkType                             { get; set; }

        public static CueLinkInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CueLinkInfo();

            value.BasePlaybackId                            = GetUInt32(new IntPtr(p + 0x018)); // 0270DAC33370 0x18 BasePlaybackId              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.TargetPlaybackId                          = GetUInt32(new IntPtr(p + 0x01C)); // 0270DAC33390 0x1C TargetPlaybackId            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CueLinkType                               = GetInt32(new IntPtr(p + 0x020)); // 0270DAC333B0 0x20 CueLinkType                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
