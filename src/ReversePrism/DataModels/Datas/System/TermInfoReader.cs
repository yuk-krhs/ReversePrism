using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BoolSize                                 ModelPrimitiveType int int int Int32
    // 014 NumSize                                  ModelPrimitiveType int int int Int32
    // 018 StrOffsets                               ModelPrimitiveType int int int Int32
    // 020 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 BooleansOffset                           ModelPrimitiveType int int int Int32
    // 02C IntOffset                                ModelPrimitiveType int int int Int32
    public partial class TermInfoReader : DataModel
    {
        public int                                      BoolSize                                { get; set; }
        public int                                      NumSize                                 { get; set; }
        public int                                      StrOffsets                              { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      BooleansOffset                          { get; set; }
        public int                                      IntOffset                               { get; set; }

        public static TermInfoReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TermInfoReader() { Pointer= p0 };

            value.BoolSize                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 BoolSize                    ( ModelPrimitiveType int int int Int32 )
            value.NumSize                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 NumSize                     ( ModelPrimitiveType int int int Int32 )
            value.StrOffsets                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 StrOffsets                  ( ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BooleansOffset                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 BooleansOffset              ( ModelPrimitiveType int int int Int32 )
            value.IntOffset                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C IntOffset                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
