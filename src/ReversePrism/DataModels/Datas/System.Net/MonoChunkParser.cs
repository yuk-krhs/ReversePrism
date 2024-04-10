using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 018 ChunkSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C ChunkRead                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 TotalWritten                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 State                                    000186742860 ModelEnumType State State State Int32
    // 028 Saved                                    000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 030 SawCR                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 Gotit                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 TrailerState                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Chunks                                   00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    public partial class MonoChunkParser : DataModel
    {
        public WebHeaderCollection?                     Headers                                 { get; set; }
        public int                                      ChunkSize                               { get; set; }
        public int                                      ChunkRead                               { get; set; }
        public int                                      TotalWritten                            { get; set; }
        public State                                    State                                   { get; set; }
        public StringBuilder?                           Saved                                   { get; set; }
        public bool                                     SawCR                                   { get; set; }
        public bool                                     Gotit                                   { get; set; }
        public int                                      TrailerState                            { get; set; }
        public ArrayList?                               Chunks                                  { get; set; }

        public static MonoChunkParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoChunkParser() { Pointer= p0 };

            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 024667AE7C60 0x10 Headers                     ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x018)); // 024667AE7C80 0x18 ChunkSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChunkRead                                 = GetInt32(new IntPtr(p + 0x01C)); // 024667AE7CA0 0x1C ChunkRead                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalWritten                              = GetInt32(new IntPtr(p + 0x020)); // 024667AE7CC0 0x20 TotalWritten                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x024)); // 024667AE7CE0 0x24 State                       ( 000186742860 ModelEnumType State State State Int32 )
            value.Saved                                     = GetObject<StringBuilder>(new IntPtr(p + 0x028), ReversePrism.DataModels.StringBuilder.FromPointer); // 024667AE7D00 0x28 Saved                       ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.SawCR                                     = GetBool(new IntPtr(p + 0x030)); // 024667AE7D20 0x30 SawCR                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Gotit                                     = GetBool(new IntPtr(p + 0x031)); // 024667AE7D40 0x31 Gotit                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TrailerState                              = GetInt32(new IntPtr(p + 0x034)); // 024667AE7D60 0x34 TrailerState                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Chunks                                    = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 024667AE7D80 0x38 Chunks                      ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
