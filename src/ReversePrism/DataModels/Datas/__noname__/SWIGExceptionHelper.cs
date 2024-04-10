using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 applicationDelegate                      ExceptionDelegate IL2CPP_TYPE_CLASS
    // 008 arithmeticDelegate                       ExceptionDelegate IL2CPP_TYPE_CLASS
    // 010 DivideByZeroDelegate                     0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 018 IndexOutOfRangeDelegate                  0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 020 InvalidCastDelegate                      0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 028 InvalidOperationDelegate                 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 030 IoDelegate                               0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 038 NullReferenceDelegate                    0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 040 OutOfMemoryDelegate                      0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 048 OverflowDelegate                         0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 050 SystemDelegate                           0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 058 ArgumentDelegate                         000186512FC0 ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer
    // 060 ArgumentNullDelegate                     000186512FC0 ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer
    // 068 ArgumentOutOfRangeDelegate               000186512FC0 ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer
    public partial class SWIGExceptionHelper : DataModel
    {
        public ExceptionDelegate?                       DivideByZeroDelegate                    { get; set; }
        public ExceptionDelegate?                       IndexOutOfRangeDelegate                 { get; set; }
        public ExceptionDelegate?                       InvalidCastDelegate                     { get; set; }
        public ExceptionDelegate?                       InvalidOperationDelegate                { get; set; }
        public ExceptionDelegate?                       IoDelegate                              { get; set; }
        public ExceptionDelegate?                       NullReferenceDelegate                   { get; set; }
        public ExceptionDelegate?                       OutOfMemoryDelegate                     { get; set; }
        public ExceptionDelegate?                       OverflowDelegate                        { get; set; }
        public ExceptionDelegate?                       SystemDelegate                          { get; set; }
        public ExceptionArgumentDelegate?               ArgumentDelegate                        { get; set; }
        public ExceptionArgumentDelegate?               ArgumentNullDelegate                    { get; set; }
        public ExceptionArgumentDelegate?               ArgumentOutOfRangeDelegate              { get; set; }

        public static SWIGExceptionHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SWIGExceptionHelper() { Pointer= p0 };

            value.DivideByZeroDelegate                      = GetObject<ExceptionDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E188 0x10 DivideByZeroDelegate        ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.IndexOutOfRangeDelegate                   = GetObject<ExceptionDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E1A8 0x18 IndexOutOfRangeDelegate     ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.InvalidCastDelegate                       = GetObject<ExceptionDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E1C8 0x20 InvalidCastDelegate         ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.InvalidOperationDelegate                  = GetObject<ExceptionDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E1E8 0x28 InvalidOperationDelegate    ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.IoDelegate                                = GetObject<ExceptionDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E208 0x30 IoDelegate                  ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.NullReferenceDelegate                     = GetObject<ExceptionDelegate>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E228 0x38 NullReferenceDelegate       ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.OutOfMemoryDelegate                       = GetObject<ExceptionDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E248 0x40 OutOfMemoryDelegate         ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.OverflowDelegate                          = GetObject<ExceptionDelegate>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E268 0x48 OverflowDelegate            ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.SystemDelegate                            = GetObject<ExceptionDelegate>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 02466BE0E288 0x50 SystemDelegate              ( 0001865134C0 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.ArgumentDelegate                          = GetObject<ExceptionArgumentDelegate>(new IntPtr(p + 0x058), ReversePrism.DataModels.ExceptionArgumentDelegate.FromPointer); // 02466BE0E2A8 0x58 ArgumentDelegate            ( 000186512FC0 ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer )
            value.ArgumentNullDelegate                      = GetObject<ExceptionArgumentDelegate>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExceptionArgumentDelegate.FromPointer); // 02466BE0E2C8 0x60 ArgumentNullDelegate        ( 000186512FC0 ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer )
            value.ArgumentOutOfRangeDelegate                = GetObject<ExceptionArgumentDelegate>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExceptionArgumentDelegate.FromPointer); // 02466BE0E2E8 0x68 ArgumentOutOfRangeDelegate  ( 000186512FC0 ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer )

            return value;
        }
    }
}
