using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstIdolId                                ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 CurrentIdolLv                            ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 MaxIdolLv                                ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 CurrentIdolExp                           ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 030 MaxIdolExp                               ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 038 idolParameter                            ReactiveProperty`1<VoDaViMeViewModel> IL2CPP_TYPE_GENERICINST
    // 040 CurrentDearnessLv                        ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 048 MaxDearnessLv                            ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 050 CurrentDearnessLvExp                     ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 058 MaxDearnessLvExp                         ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer
    // 060 fan                                      ReactiveProperty`1<ulong> IL2CPP_TYPE_GENERICINST
    // 068 IdolLvObservable                         IObservable`1<IList`1<int>> IL2CPP_TYPE_GENERICINST
    // 070 IdolExpObservable                        IObservable`1<IList`1<long>> IL2CPP_TYPE_GENERICINST
    // 078 DearnessLvObservable                     IObservable`1<IList`1<int>> IL2CPP_TYPE_GENERICINST
    // 080 DearnessLvExpObservable                  IObservable`1<IList`1<long>> IL2CPP_TYPE_GENERICINST
    public partial class IdolBaseDetailStatusViewModel : DataModel
    {
        public IntReactiveProperty?                     MstIdolId                               { get; set; }
        public IntReactiveProperty?                     CurrentIdolLv                           { get; set; }
        public IntReactiveProperty?                     MaxIdolLv                               { get; set; }
        public LongReactiveProperty?                    CurrentIdolExp                          { get; set; }
        public LongReactiveProperty?                    MaxIdolExp                              { get; set; }
        public IntReactiveProperty?                     CurrentDearnessLv                       { get; set; }
        public IntReactiveProperty?                     MaxDearnessLv                           { get; set; }
        public LongReactiveProperty?                    CurrentDearnessLvExp                    { get; set; }
        public LongReactiveProperty?                    MaxDearnessLvExp                        { get; set; }

        public static IdolBaseDetailStatusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailStatusViewModel() { Pointer= p0 };

            value.MstIdolId                                 = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x10 MstIdolId                   ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.CurrentIdolLv                             = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x18 CurrentIdolLv               ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.MaxIdolLv                                 = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x20 MaxIdolLv                   ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.CurrentIdolExp                            = GetObject<LongReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x28 CurrentIdolExp              ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.MaxIdolExp                                = GetObject<LongReactiveProperty>(new IntPtr(p + 0x030), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x30 MaxIdolExp                  ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.CurrentDearnessLv                         = GetObject<IntReactiveProperty>(new IntPtr(p + 0x040), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x40 CurrentDearnessLv           ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.MaxDearnessLv                             = GetObject<IntReactiveProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x48 MaxDearnessLv               ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.CurrentDearnessLvExp                      = GetObject<LongReactiveProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x50 CurrentDearnessLvExp        ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )
            value.MaxDearnessLvExp                          = GetObject<LongReactiveProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.LongReactiveProperty.FromPointer); // 0x58 MaxDearnessLvExp            ( ModelClassType LongReactiveProperty LongReactiveProperty LongReactiveProperty Pointer )

            return value;
        }
    }
}
