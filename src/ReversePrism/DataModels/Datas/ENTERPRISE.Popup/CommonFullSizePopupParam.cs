using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    000186671910 ModelPrimitiveType string string string String
    // 018 ContentName                              000186671910 ModelPrimitiveType string string string String
    // 020 ContentPrefab                            000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 028 Priority                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C IsInfoButtonActive                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CommonFullSizePopupParam : DataModel
    {
        public string                                   Title                                   { get; set; }
        public string                                   ContentName                             { get; set; }
        public PopupContentBase?                        ContentPrefab                           { get; set; }
        public int                                      Priority                                { get; set; }
        public bool                                     IsInfoButtonActive                      { get; set; }

        public static CommonFullSizePopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonFullSizePopupParam() { Pointer= p0 };

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 02466534D3C8 0x10 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.ContentName                               = GetString(new IntPtr(p + 0x018)); // 02466534D3E8 0x18 ContentName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ContentPrefab                             = GetObject<PopupContentBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.PopupContentBase.FromPointer); // 02466534D408 0x20 ContentPrefab               ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x028)); // 02466534D428 0x28 Priority                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsInfoButtonActive                        = GetBool(new IntPtr(p + 0x02C)); // 02466534D448 0x2C IsInfoButtonActive          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
