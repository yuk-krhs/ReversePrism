using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DoneDelegate                             ModelClassType DoneDelegate DoneDelegate DoneDelegate Pointer
    // 028 IsDone                                   ModelPrimitiveType bool bool bool Bool
    // 030 Error                                    ModelPrimitiveType string string string String
    // 038 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    public partial class CriFsRequest : DataModel
    {
        public DoneDelegate?                            DoneDelegate                            { get; set; }
        public bool                                     IsDone                                  { get; set; }
        public string                                   Error                                   { get; set; }
        public bool                                     IsDisposed                              { get; set; }

        public static CriFsRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsRequest() { Pointer= p0 };

            value.DoneDelegate                              = GetObject<DoneDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.DoneDelegate.FromPointer); // 0x20 DoneDelegate                ( ModelClassType DoneDelegate DoneDelegate DoneDelegate Pointer )
            value.IsDone                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 IsDone                      ( ModelPrimitiveType bool bool bool Bool )
            value.Error                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Error                       ( ModelPrimitiveType string string string String )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x038)); // 0x38 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
