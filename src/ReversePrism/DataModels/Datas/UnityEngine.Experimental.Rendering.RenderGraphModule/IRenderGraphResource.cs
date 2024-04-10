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
    public partial class IRenderGraphResource : DataModel
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
            var value   = new IRenderGraphResource() { Pointer= p0 };

            value.Imported                                  = GetBool(new IntPtr(p + 0x010)); // 024669138B30 0x10 Imported                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Shared                                    = GetBool(new IntPtr(p + 0x011)); // 024669138B50 0x11 Shared                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SharedExplicitRelease                     = GetBool(new IntPtr(p + 0x012)); // 024669138B70 0x12 SharedExplicitRelease       ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.RequestFallBack                           = GetBool(new IntPtr(p + 0x013)); // 024669138B90 0x13 RequestFallBack             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.WriteCount                                = GetUInt32(new IntPtr(p + 0x014)); // 024669138BB0 0x14 WriteCount                  ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CachedHash                                = GetInt32(new IntPtr(p + 0x018)); // 024669138BD0 0x18 CachedHash                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TransientPassIndex                        = GetInt32(new IntPtr(p + 0x01C)); // 024669138BF0 0x1C TransientPassIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SharedResourceLastFrameUsed               = GetInt32(new IntPtr(p + 0x020)); // 024669138C10 0x20 SharedResourceLastFrameUsed ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_Pool                                    = GetObject<IRenderGraphResourcePool>(new IntPtr(p + 0x028), ReversePrism.DataModels.IRenderGraphResourcePool.FromPointer); // 024669138C30 0x28 M_Pool                      ( 000186618C10 ModelClassType IRenderGraphResourcePool IRenderGraphResourcePool IRenderGraphResourcePool Pointer )

            return value;
        }
    }
}
