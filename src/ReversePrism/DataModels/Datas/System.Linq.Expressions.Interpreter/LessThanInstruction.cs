using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _nullValue                               <object> IL2CPP_TYPE_OBJECT
    // 000 s_SByte                                  Instruction IL2CPP_TYPE_CLASS
    // 008 s_Int16                                  Instruction IL2CPP_TYPE_CLASS
    // 010 S_Char                                   00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 018 S_Int32                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 020 S_Int64                                  00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 028 S_Byte                                   00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 030 S_UInt16                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 038 S_UInt32                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 040 S_UInt64                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 048 S_Single                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 050 S_Double                                 00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 058 S_liftedToNullSByte                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 060 S_liftedToNullInt16                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 068 S_liftedToNullChar                       00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 070 S_liftedToNullInt32                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 078 S_liftedToNullInt64                      00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 080 S_liftedToNullByte                       00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 088 S_liftedToNullUInt16                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 090 S_liftedToNullUInt32                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 098 S_liftedToNullUInt64                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0A0 S_liftedToNullSingle                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    // 0A8 S_liftedToNullDouble                     00018670E060 ModelClassType Instruction Instruction Instruction Pointer
    public partial class LessThanInstruction : DataModel
    {
        public Instruction?                             S_Char                                  { get; set; }
        public Instruction?                             S_Int32                                 { get; set; }
        public Instruction?                             S_Int64                                 { get; set; }
        public Instruction?                             S_Byte                                  { get; set; }
        public Instruction?                             S_UInt16                                { get; set; }
        public Instruction?                             S_UInt32                                { get; set; }
        public Instruction?                             S_UInt64                                { get; set; }
        public Instruction?                             S_Single                                { get; set; }
        public Instruction?                             S_Double                                { get; set; }
        public Instruction?                             S_liftedToNullSByte                     { get; set; }
        public Instruction?                             S_liftedToNullInt16                     { get; set; }
        public Instruction?                             S_liftedToNullChar                      { get; set; }
        public Instruction?                             S_liftedToNullInt32                     { get; set; }
        public Instruction?                             S_liftedToNullInt64                     { get; set; }
        public Instruction?                             S_liftedToNullByte                      { get; set; }
        public Instruction?                             S_liftedToNullUInt16                    { get; set; }
        public Instruction?                             S_liftedToNullUInt32                    { get; set; }
        public Instruction?                             S_liftedToNullUInt64                    { get; set; }
        public Instruction?                             S_liftedToNullSingle                    { get; set; }
        public Instruction?                             S_liftedToNullDouble                    { get; set; }

        public static LessThanInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LessThanInstruction() { Pointer= p0 };

            value.S_Char                                    = GetObject<Instruction>(new IntPtr(p + 0x010), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058CB0 0x10 S_Char                      ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int32                                   = GetObject<Instruction>(new IntPtr(p + 0x018), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058CD0 0x18 S_Int32                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Int64                                   = GetObject<Instruction>(new IntPtr(p + 0x020), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058CF0 0x20 S_Int64                     ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Byte                                    = GetObject<Instruction>(new IntPtr(p + 0x028), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058D10 0x28 S_Byte                      ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt16                                  = GetObject<Instruction>(new IntPtr(p + 0x030), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058D30 0x30 S_UInt16                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt32                                  = GetObject<Instruction>(new IntPtr(p + 0x038), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058D50 0x38 S_UInt32                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_UInt64                                  = GetObject<Instruction>(new IntPtr(p + 0x040), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058D70 0x40 S_UInt64                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Single                                  = GetObject<Instruction>(new IntPtr(p + 0x048), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058D90 0x48 S_Single                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_Double                                  = GetObject<Instruction>(new IntPtr(p + 0x050), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058DB0 0x50 S_Double                    ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullSByte                       = GetObject<Instruction>(new IntPtr(p + 0x058), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058DD0 0x58 S_liftedToNullSByte         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullInt16                       = GetObject<Instruction>(new IntPtr(p + 0x060), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058DF0 0x60 S_liftedToNullInt16         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullChar                        = GetObject<Instruction>(new IntPtr(p + 0x068), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058E10 0x68 S_liftedToNullChar          ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullInt32                       = GetObject<Instruction>(new IntPtr(p + 0x070), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058E30 0x70 S_liftedToNullInt32         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullInt64                       = GetObject<Instruction>(new IntPtr(p + 0x078), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058E50 0x78 S_liftedToNullInt64         ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullByte                        = GetObject<Instruction>(new IntPtr(p + 0x080), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058E70 0x80 S_liftedToNullByte          ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullUInt16                      = GetObject<Instruction>(new IntPtr(p + 0x088), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058E90 0x88 S_liftedToNullUInt16        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullUInt32                      = GetObject<Instruction>(new IntPtr(p + 0x090), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058EB0 0x90 S_liftedToNullUInt32        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullUInt64                      = GetObject<Instruction>(new IntPtr(p + 0x098), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058ED0 0x98 S_liftedToNullUInt64        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullSingle                      = GetObject<Instruction>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058EF0 0xA0 S_liftedToNullSingle        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )
            value.S_liftedToNullDouble                      = GetObject<Instruction>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Instruction.FromPointer); // 02466A058F10 0xA8 S_liftedToNullDouble        ( 00018670E060 ModelClassType Instruction Instruction Instruction Pointer )

            return value;
        }
    }
}
