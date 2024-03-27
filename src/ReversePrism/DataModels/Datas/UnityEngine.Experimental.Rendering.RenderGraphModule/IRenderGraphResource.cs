using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Imported                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 Shared                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 012 SharedExplicitRelease                    000186595960 ModelPrimitiveType bool bool bool Bool
    // 013 RequestFallBack                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 WriteCount                               0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 CachedHash                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C TransientPassIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 SharedResourceLastFrameUsed              0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 M_Pool                                   000186618C10 ModelClassType IRenderGraphResourcePool IRenderGraphResourcePool IRenderGraphResourcePool Pointer
    public partial class IRenderGraphResource
    {
        public bool                                     Imported                                { get; set; }
        public bool                                     Shared                                  { get; set; }
        public bool                                     SharedExplicitRelease                   { get; set; }
        public bool                                     RequestFallBack                         { get; set; }
        public uint                                     WriteCount                              { get; set; }
        public int                                      CachedHash                              { get; set; }
        public int                                      TransientPassIndex                      { get; set; }
        public int                                      SharedResourceLastFrameUsed             { get; set; }
        public IRenderGraphResourcePool?                M_Pool                                  { get; set; }

        public static IRenderGraphResource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IRenderGraphResource();

            value.Imported                                  = GetBool(new IntPtr(p + 0x010)); // 0270D90E6168 0x10 Imported                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Shared                                    = GetBool(new IntPtr(p + 0x011)); // 0270D90E6188 0x11 Shared                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SharedExplicitRelease                     = GetBool(new IntPtr(p + 0x012)); // 0270D90E61A8 0x12 SharedExplicitRelease       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RequestFallBack                           = GetBool(new IntPtr(p + 0x013)); // 0270D90E61C8 0x13 RequestFallBack             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.WriteCount                                = GetUInt32(new IntPtr(p + 0x014)); // 0270D90E61E8 0x14 WriteCount                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CachedHash                                = GetInt32(new IntPtr(p + 0x018)); // 0270D90E6208 0x18 CachedHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TransientPassIndex                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D90E6228 0x1C TransientPassIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SharedResourceLastFrameUsed               = GetInt32(new IntPtr(p + 0x020)); // 0270D90E6248 0x20 SharedResourceLastFrameUsed ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_Pool                                    = GetObject<IRenderGraphResourcePool>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRenderGraphResourcePool.FromPointer); // 0270D90E6268 0x28 M_Pool                      ( 000186618C10 ModelClassType IRenderGraphResourcePool IRenderGraphResourcePool IRenderGraphResourcePool Pointer )

            return value;
        }
    }
}
