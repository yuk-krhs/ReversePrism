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
    // 010 DivideByZeroDelegate                     ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 018 IndexOutOfRangeDelegate                  ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 020 InvalidCastDelegate                      ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 028 InvalidOperationDelegate                 ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 030 IoDelegate                               ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 038 NullReferenceDelegate                    ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 040 OutOfMemoryDelegate                      ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 048 OverflowDelegate                         ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 050 SystemDelegate                           ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer
    // 058 ArgumentDelegate                         ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer
    // 060 ArgumentNullDelegate                     ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer
    // 068 ArgumentOutOfRangeDelegate               ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer
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

            value.DivideByZeroDelegate                      = GetObject<ExceptionDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x10 DivideByZeroDelegate        ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.IndexOutOfRangeDelegate                   = GetObject<ExceptionDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x18 IndexOutOfRangeDelegate     ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.InvalidCastDelegate                       = GetObject<ExceptionDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x20 InvalidCastDelegate         ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.InvalidOperationDelegate                  = GetObject<ExceptionDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x28 InvalidOperationDelegate    ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.IoDelegate                                = GetObject<ExceptionDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x30 IoDelegate                  ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.NullReferenceDelegate                     = GetObject<ExceptionDelegate>(new IntPtr(p + 0x038), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x38 NullReferenceDelegate       ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.OutOfMemoryDelegate                       = GetObject<ExceptionDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x40 OutOfMemoryDelegate         ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.OverflowDelegate                          = GetObject<ExceptionDelegate>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x48 OverflowDelegate            ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.SystemDelegate                            = GetObject<ExceptionDelegate>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExceptionDelegate.FromPointer); // 0x50 SystemDelegate              ( ModelClassType ExceptionDelegate ExceptionDelegate ExceptionDelegate Pointer )
            value.ArgumentDelegate                          = GetObject<ExceptionArgumentDelegate>(new IntPtr(p + 0x058), ReversePrism.DataModels.ExceptionArgumentDelegate.FromPointer); // 0x58 ArgumentDelegate            ( ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer )
            value.ArgumentNullDelegate                      = GetObject<ExceptionArgumentDelegate>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExceptionArgumentDelegate.FromPointer); // 0x60 ArgumentNullDelegate        ( ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer )
            value.ArgumentOutOfRangeDelegate                = GetObject<ExceptionArgumentDelegate>(new IntPtr(p + 0x068), ReversePrism.DataModels.ExceptionArgumentDelegate.FromPointer); // 0x68 ArgumentOutOfRangeDelegate  ( ModelClassType ExceptionArgumentDelegate ExceptionArgumentDelegate ExceptionArgumentDelegate Pointer )

            return value;
        }
    }
}
