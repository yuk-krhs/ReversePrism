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
    public partial class MonoChunkParser
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
            var value   = new MonoChunkParser();

            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0270D7A8FC60 0x10 Headers                     ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D7A8FC80 0x18 ChunkSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChunkRead                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D7A8FCA0 0x1C ChunkRead                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalWritten                              = GetInt32(new IntPtr(p + 0x020)); // 0270D7A8FCC0 0x20 TotalWritten                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x024)); // 0270D7A8FCE0 0x24 State                       ( 000186742860 ModelEnumType State State State Int32 )
            value.Saved                                     = GetObject<StringBuilder>(new IntPtr(p + 0x028), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D7A8FD00 0x28 Saved                       ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.SawCR                                     = GetBool(new IntPtr(p + 0x030)); // 0270D7A8FD20 0x30 SawCR                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Gotit                                     = GetBool(new IntPtr(p + 0x031)); // 0270D7A8FD40 0x31 Gotit                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TrailerState                              = GetInt32(new IntPtr(p + 0x034)); // 0270D7A8FD60 0x34 TrailerState                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Chunks                                    = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D7A8FD80 0x38 Chunks                      ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
