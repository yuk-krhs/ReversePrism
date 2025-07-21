using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Headers                                  ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 018 ChunkSize                                ModelPrimitiveType int int int Int32
    // 01C ChunkRead                                ModelPrimitiveType int int int Int32
    // 020 TotalWritten                             ModelPrimitiveType int int int Int32
    // 024 State                                    ModelEnumType State State State Int32
    // 028 Saved                                    ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 030 SawCR                                    ModelPrimitiveType bool bool bool Bool
    // 031 Gotit                                    ModelPrimitiveType bool bool bool Bool
    // 034 TrailerState                             ModelPrimitiveType int int int Int32
    // 038 Chunks                                   ModelClassType ArrayList ArrayList ArrayList Pointer
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

            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x10 Headers                     ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.ChunkSize                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 ChunkSize                   ( ModelPrimitiveType int int int Int32 )
            value.ChunkRead                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ChunkRead                   ( ModelPrimitiveType int int int Int32 )
            value.TotalWritten                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalWritten                ( ModelPrimitiveType int int int Int32 )
            value.State                                     = (State)GetInt32(new IntPtr(p + 0x024)); // 0x24 State                       ( ModelEnumType State State State Int32 )
            value.Saved                                     = GetObject<StringBuilder>(new IntPtr(p + 0x028), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x28 Saved                       ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.SawCR                                     = GetBool(new IntPtr(p + 0x030)); // 0x30 SawCR                       ( ModelPrimitiveType bool bool bool Bool )
            value.Gotit                                     = GetBool(new IntPtr(p + 0x031)); // 0x31 Gotit                       ( ModelPrimitiveType bool bool bool Bool )
            value.TrailerState                              = GetInt32(new IntPtr(p + 0x034)); // 0x34 TrailerState                ( ModelPrimitiveType int int int Int32 )
            value.Chunks                                    = GetObject<ArrayList>(new IntPtr(p + 0x038), ReversePrism.DataModels.ArrayList.FromPointer); // 0x38 Chunks                      ( ModelClassType ArrayList ArrayList ArrayList Pointer )

            return value;
        }
    }
}
