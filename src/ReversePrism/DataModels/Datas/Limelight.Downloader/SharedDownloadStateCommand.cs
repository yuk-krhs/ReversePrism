using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CapacityOverAlert                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 ResetConcurrencySettings                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 ForceReconnectRequest                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 013 SuppressBackgroundDownload               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 NeedsPauseWithError                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 015 NeedsPauseAlways                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SharedDownloadStateCommand : DataModel
    {
        public bool                                     CapacityOverAlert                       { get; set; }
        public bool                                     ResetConcurrencySettings                { get; set; }
        public bool                                     ForceReconnectRequest                   { get; set; }
        public bool                                     SuppressBackgroundDownload              { get; set; }
        public bool                                     NeedsPauseWithError                     { get; set; }
        public bool                                     NeedsPauseAlways                        { get; set; }

        public static SharedDownloadStateCommand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SharedDownloadStateCommand() { Pointer= p0 };

            value.CapacityOverAlert                         = GetBool(new IntPtr(p + 0x010)); // 0245A3E28BE0 0x10 CapacityOverAlert           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResetConcurrencySettings                  = GetBool(new IntPtr(p + 0x011)); // 0245A3E28C00 0x11 ResetConcurrencySettings    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ForceReconnectRequest                     = GetBool(new IntPtr(p + 0x012)); // 0245A3E28C20 0x12 ForceReconnectRequest       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SuppressBackgroundDownload                = GetBool(new IntPtr(p + 0x013)); // 0245A3E28C40 0x13 SuppressBackgroundDownload  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NeedsPauseWithError                       = GetBool(new IntPtr(p + 0x014)); // 0245A3E28C60 0x14 NeedsPauseWithError         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NeedsPauseAlways                          = GetBool(new IntPtr(p + 0x015)); // 0245A3E28C80 0x15 NeedsPauseAlways            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
