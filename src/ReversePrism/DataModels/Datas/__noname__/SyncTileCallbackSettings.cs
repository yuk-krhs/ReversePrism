using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HasSyncTileCallback                      000186595210 ModelPrimitiveType bool bool bool Bool
    // 011 HasPositionsChangedCallback              000186595210 ModelPrimitiveType bool bool bool Bool
    // 012 IsBufferSyncTile                         000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class SyncTileCallbackSettings : DataModel
    {
        public bool                                     HasSyncTileCallback                     { get; set; }
        public bool                                     HasPositionsChangedCallback             { get; set; }
        public bool                                     IsBufferSyncTile                        { get; set; }

        public static SyncTileCallbackSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncTileCallbackSettings() { Pointer= p0 };

            value.HasSyncTileCallback                       = GetBool(new IntPtr(p + 0x010)); // 0245A692A2B0 0x10 HasSyncTileCallback         ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.HasPositionsChangedCallback               = GetBool(new IntPtr(p + 0x011)); // 0245A692A2D0 0x11 HasPositionsChangedCallback ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsBufferSyncTile                          = GetBool(new IntPtr(p + 0x012)); // 0245A692A2F0 0x12 IsBufferSyncTile            ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
