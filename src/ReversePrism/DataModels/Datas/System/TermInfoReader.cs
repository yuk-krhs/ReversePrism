using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BoolSize                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 NumSize                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 StrOffsets                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 BooleansOffset                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C IntOffset                                0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.BoolSize                                  = GetInt32(new IntPtr(p + 0x010)); // 024666ACA2C8 0x10 BoolSize                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumSize                                   = GetInt32(new IntPtr(p + 0x014)); // 024666ACA2E8 0x14 NumSize                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StrOffsets                                = GetInt32(new IntPtr(p + 0x018)); // 024666ACA308 0x18 StrOffsets                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x020)); // 024666ACA328 0x20 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BooleansOffset                            = GetInt32(new IntPtr(p + 0x028)); // 024666ACA348 0x28 BooleansOffset              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IntOffset                                 = GetInt32(new IntPtr(p + 0x02C)); // 024666ACA368 0x2C IntOffset                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
