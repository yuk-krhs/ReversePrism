using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Title                                    ModelPrimitiveType string string string String
    // 018 ContentName                              ModelPrimitiveType string string string String
    // 020 ContentPrefab                            ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 028 Priority                                 ModelPrimitiveType int int int Int32
    // 02C IsInfoButtonActive                       ModelPrimitiveType bool bool bool Bool
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

            value.Title                                     = GetString(new IntPtr(p + 0x010)); // 0x10 Title                       ( ModelPrimitiveType string string string String )
            value.ContentName                               = GetString(new IntPtr(p + 0x018)); // 0x18 ContentName                 ( ModelPrimitiveType string string string String )
            value.ContentPrefab                             = GetObject<PopupContentBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0x20 ContentPrefab               ( ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.Priority                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 Priority                    ( ModelPrimitiveType int int int Int32 )
            value.IsInfoButtonActive                        = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsInfoButtonActive          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
