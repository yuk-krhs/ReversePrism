using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CapacityOverAlert                        ModelPrimitiveType bool bool bool Bool
    // 011 ResetConcurrencySettings                 ModelPrimitiveType bool bool bool Bool
    // 012 ForceReconnectRequest                    ModelPrimitiveType bool bool bool Bool
    // 013 SuppressBackgroundDownload               ModelPrimitiveType bool bool bool Bool
    // 014 NeedsPauseWithError                      ModelPrimitiveType bool bool bool Bool
    // 015 NeedsPauseAlways                         ModelPrimitiveType bool bool bool Bool
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

            value.CapacityOverAlert                         = GetBool(new IntPtr(p + 0x010)); // 0x10 CapacityOverAlert           ( ModelPrimitiveType bool bool bool Bool )
            value.ResetConcurrencySettings                  = GetBool(new IntPtr(p + 0x011)); // 0x11 ResetConcurrencySettings    ( ModelPrimitiveType bool bool bool Bool )
            value.ForceReconnectRequest                     = GetBool(new IntPtr(p + 0x012)); // 0x12 ForceReconnectRequest       ( ModelPrimitiveType bool bool bool Bool )
            value.SuppressBackgroundDownload                = GetBool(new IntPtr(p + 0x013)); // 0x13 SuppressBackgroundDownload  ( ModelPrimitiveType bool bool bool Bool )
            value.NeedsPauseWithError                       = GetBool(new IntPtr(p + 0x014)); // 0x14 NeedsPauseWithError         ( ModelPrimitiveType bool bool bool Bool )
            value.NeedsPauseAlways                          = GetBool(new IntPtr(p + 0x015)); // 0x15 NeedsPauseAlways            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
