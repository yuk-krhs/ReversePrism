using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Boolean                                CastInstruction IL2CPP_TYPE_CLASS
    // 008 s_Byte                                   CastInstruction IL2CPP_TYPE_CLASS
    // 010 S_Char                                   000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 018 S_DateTime                               000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 020 S_Decimal                                000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 028 S_Double                                 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 030 S_Int16                                  000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 038 S_Int32                                  000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 040 S_Int64                                  000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 048 S_SByte                                  000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 050 S_Single                                 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 058 S_String                                 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 060 S_UInt16                                 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 068 S_UInt32                                 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    // 070 S_UInt64                                 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer
    public partial class CastInstruction
    {
        public CastInstruction?                         S_Char                                  { get; set; }
        public CastInstruction?                         S_DateTime                              { get; set; }
        public CastInstruction?                         S_Decimal                               { get; set; }
        public CastInstruction?                         S_Double                                { get; set; }
        public CastInstruction?                         S_Int16                                 { get; set; }
        public CastInstruction?                         S_Int32                                 { get; set; }
        public CastInstruction?                         S_Int64                                 { get; set; }
        public CastInstruction?                         S_SByte                                 { get; set; }
        public CastInstruction?                         S_Single                                { get; set; }
        public CastInstruction?                         S_String                                { get; set; }
        public CastInstruction?                         S_UInt16                                { get; set; }
        public CastInstruction?                         S_UInt32                                { get; set; }
        public CastInstruction?                         S_UInt64                                { get; set; }

        public static CastInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CastInstruction();

            value.S_Char                                    = GetObject<CastInstruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039DA0 0x10 S_Char                      ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_DateTime                                = GetObject<CastInstruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039DC0 0x18 S_DateTime                  ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_Decimal                                 = GetObject<CastInstruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039DE0 0x20 S_Decimal                   ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_Double                                  = GetObject<CastInstruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039E00 0x28 S_Double                    ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_Int16                                   = GetObject<CastInstruction>(new IntPtr(p + 0x030), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039E20 0x30 S_Int16                     ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_Int32                                   = GetObject<CastInstruction>(new IntPtr(p + 0x038), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039E40 0x38 S_Int32                     ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_Int64                                   = GetObject<CastInstruction>(new IntPtr(p + 0x040), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039E60 0x40 S_Int64                     ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_SByte                                   = GetObject<CastInstruction>(new IntPtr(p + 0x048), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039E80 0x48 S_SByte                     ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_Single                                  = GetObject<CastInstruction>(new IntPtr(p + 0x050), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039EA0 0x50 S_Single                    ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_String                                  = GetObject<CastInstruction>(new IntPtr(p + 0x058), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039EC0 0x58 S_String                    ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_UInt16                                  = GetObject<CastInstruction>(new IntPtr(p + 0x060), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039EE0 0x60 S_UInt16                    ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_UInt32                                  = GetObject<CastInstruction>(new IntPtr(p + 0x068), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039F00 0x68 S_UInt32                    ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )
            value.S_UInt64                                  = GetObject<CastInstruction>(new IntPtr(p + 0x070), ReversePrism.DataModels.CastInstruction.FromPointer); // 0270DA039F20 0x70 S_UInt64                    ( 000186549860 ModelClassType CastInstruction CastInstruction CastInstruction Pointer )

            return value;
        }
    }
}
