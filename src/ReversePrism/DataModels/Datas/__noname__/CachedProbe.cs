using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UpdateCount                              ModelPrimitiveType uint uint uint UInt32
    // 018 ImageContentsHash                        ModelEnumType Hash128 Hash128 Hash128 Int32
    // 028 Size                                     ModelPrimitiveType int int int Int32
    // 02C MipCount                                 ModelPrimitiveType int int int Int32
    // 030 DataIndices                              ModelEnumType <dataIndices>e__FixedBuffer <dataIndices>e__FixedBuffer <dataIndices>e__FixedBuffer Int32
    // 04C Levels                                   ModelEnumType <levels>e__FixedBuffer <levels>e__FixedBuffer <levels>e__FixedBuffer Int32
    // 068 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 070 LastUsed                                 ModelPrimitiveType int int int Int32
    // 074 HdrData                                  ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class CachedProbe : DataModel
    {
        public uint                                     UpdateCount                             { get; set; }
        public Hash128                                  ImageContentsHash                       { get; set; }
        public int                                      Size                                    { get; set; }
        public int                                      MipCount                                { get; set; }
        public <dataIndices>e__FixedBuffer              DataIndices                             { get; set; }
        public <levels>e__FixedBuffer                   Levels                                  { get; set; }
        public Texture?                                 Texture                                 { get; set; }
        public int                                      LastUsed                                { get; set; }
        public Vector4                                  HdrData                                 { get; set; }

        public static CachedProbe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedProbe() { Pointer= p0 };

            value.UpdateCount                               = GetUInt32(new IntPtr(p + 0x010)); // 0x10 UpdateCount                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.ImageContentsHash                         = (Hash128)GetInt32(new IntPtr(p + 0x018)); // 0x18 ImageContentsHash           ( ModelEnumType Hash128 Hash128 Hash128 Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Size                        ( ModelPrimitiveType int int int Int32 )
            value.MipCount                                  = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MipCount                    ( ModelPrimitiveType int int int Int32 )
            value.DataIndices                               = (<dataIndices>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0x30 DataIndices                 ( ModelEnumType <dataIndices>e__FixedBuffer <dataIndices>e__FixedBuffer <dataIndices>e__FixedBuffer Int32 )
            value.Levels                                    = (<levels>e__FixedBuffer)GetInt32(new IntPtr(p + 0x04C)); // 0x4C Levels                      ( ModelEnumType <levels>e__FixedBuffer <levels>e__FixedBuffer <levels>e__FixedBuffer Int32 )
            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x068), ReversePrism.DataModels.Texture.FromPointer); // 0x68 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.LastUsed                                  = GetInt32(new IntPtr(p + 0x070)); // 0x70 LastUsed                    ( ModelPrimitiveType int int int Int32 )
            value.HdrData                                   = (Vector4)GetInt32(new IntPtr(p + 0x074)); // 0x74 HdrData                     ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
