using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleMenuContent                         ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer
    // 028 CacheClearContent                        ModelClassType CacheClearContent CacheClearContent CacheClearContent Pointer
    // 030 PlayerDataDeleteContent                  ModelClassType PlayerDataDeleteContent PlayerDataDeleteContent PlayerDataDeleteContent Pointer
    // 038 MenuContent                              ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer
    public partial class TitleMenuPopupView : DataModel
    {
        public TitleMenuContent?                        TitleMenuContent                        { get; set; }
        public CacheClearContent?                       CacheClearContent                       { get; set; }
        public PlayerDataDeleteContent?                 PlayerDataDeleteContent                 { get; set; }
        public TitleMenuContent?                        MenuContent                             { get; set; }

        public static TitleMenuPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleMenuPopupView() { Pointer= p0 };

            value.TitleMenuContent                          = GetObject<TitleMenuContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.TitleMenuContent.FromPointer); // 0x20 TitleMenuContent            ( ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer )
            value.CacheClearContent                         = GetObject<CacheClearContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.CacheClearContent.FromPointer); // 0x28 CacheClearContent           ( ModelClassType CacheClearContent CacheClearContent CacheClearContent Pointer )
            value.PlayerDataDeleteContent                   = GetObject<PlayerDataDeleteContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayerDataDeleteContent.FromPointer); // 0x30 PlayerDataDeleteContent     ( ModelClassType PlayerDataDeleteContent PlayerDataDeleteContent PlayerDataDeleteContent Pointer )
            value.MenuContent                               = GetObject<TitleMenuContent>(new IntPtr(p + 0x038), ReversePrism.DataModels.TitleMenuContent.FromPointer); // 0x38 MenuContent                 ( ModelClassType TitleMenuContent TitleMenuContent TitleMenuContent Pointer )

            return value;
        }
    }
}
